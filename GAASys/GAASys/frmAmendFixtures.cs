using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAASys
{
    public partial class frmAmendFixtures : Form
    {
        private Team thisTeam = new Team();
        private Fixture thisFixture = new Fixture();

        private int selectedFixtureId;
        private String dateFormat = "dd-MMM-yy";

        public frmAmendFixtures()
        {
            InitializeComponent();
        }

        private void FillComboWithTeamsAndIds()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select * from teams order by teamid";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();

            OracleDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    int iId = myReader.GetInt32(0);
                    String sName = myReader.GetString(1);
                    String comboDisplayFormat = iId + " - " + sName;
                    teamComboBox.Items.Add(comboDisplayFormat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }


        //close this and open fixtures form
        public void closeAndOpenFixturesForm()
        {
            this.Close();

            frmFixtures lastForm = new frmFixtures();
            lastForm.Show();
        }

        //close this and open this form
        public void closeAndOpenThisForm()
        {
            this.Close();

            frmAmendFixtures thisForm = new frmAmendFixtures();
            thisForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenFixturesForm();
        }

        private bool isDateInputValid()
        {
            DateTime dateTime;
            if (DateTime.TryParseExact(txtFixtureDate.Text, dateFormat, new CultureInfo("en-US"), DateTimeStyles.None, out dateTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isDataNull()
        {
            if (String.IsNullOrEmpty(txtFixtureVenue.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtFixtureDate.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtFixtureTime.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isTimeInputValid()
        {
            Regex checktime = new Regex(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");

            return checktime.IsMatch(txtFixtureTime.Text);
        }

        private void amendFixtureButton_Click(object sender, EventArgs e)
        {
            
            //Check if there is any empty fields
            if (isDataNull())
            {
                
                //check if all fields are valid
                if (isDateInputValid())
                {

                    if (isTimeInputValid())
                    {
                        //set the text box details as this teams details
                        thisFixture.setVenue(txtFixtureVenue.Text);
                        thisFixture.setFixtureDate(txtFixtureDate.Text);
                        thisFixture.setFixtureTime(txtFixtureTime.Text);


                        //update fixture details in the database
                        thisFixture.updateFixture(fixtureComboBox.Text[0].ToString());

                        //Display confirmation message
                        MessageBox.Show("This fixture has been updated", "Updating...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        grpFixture.Visible = false;
                    }
                    else
                    {
                        //Display error message
                        MessageBox.Show("The details you entered are invalid\nHint - Check that the time entered is the correct format", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    //Display error message
                    MessageBox.Show("The details you entered are invalid\nHint - Check that the date entered is the correct format", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                //Display error message
                MessageBox.Show("The details you entered are invalid\nHint - Don't leave any fields blank", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            closeAndOpenThisForm();
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset combobox with list of team fixtures
            fixtureComboBox.Items.Clear();
        
            //set the fixture combo box to visible when a team is selected
            fixtureComboBox.Visible = true;
            label2.Visible = true;

            //set the text to blank for the fixtre combobox
            //this is for if the user wants to change a different teams fixture after already selecting a team
            fixtureComboBox.Text = "";

            //set the fixture group box to not visible when the team is selected as a fixture needs to be selected before the group box
            //details can be changed
            //this is for if the user wants to change a different teams fixture after already selecting a team
            grpFixture.Visible = false;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String selectedTeamId = teamComboBox.Text[0].ToString() + teamComboBox.Text[1].ToString();
            int selectedTeamIdAsInt = Int32.Parse(selectedTeamId);

            //Define SQL Query
            String strSQL = "select * from fixtures where team1id='" + selectedTeamId + "' or team2id='" + selectedTeamId + "' order by fixturesid ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    int firstTeamId = myReader.GetInt32(1);
                    int secondTeamId = myReader.GetInt32(2);
                    selectedFixtureId = myReader.GetInt32(0);

                    
                    String firstTeamName = thisTeam.getTeamNameFromId(firstTeamId);
                    String secondTeamName = thisTeam.getTeamNameFromId(secondTeamId);
                    

                    String sFixture = selectedFixtureId + " - " + firstTeamName + " vs " + secondTeamName;
                    fixtureComboBox.Items.Add(sFixture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

        }

        private void fixtureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpFixture.Visible = true;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select * from fixtures where fixturesid=" + fixtureComboBox.Text[0] + fixtureComboBox.Text[1];

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    String sFixVenue = myReader.GetString(7);
                    DateTime dtFixDate = myReader.GetDateTime(8);
                    String sFixTime = myReader.GetString(9);
                    txtFixtureVenue.Text = sFixVenue;
                    String sFixDate = dtFixDate.ToString();
                    txtFixtureDate.Text = DateTime.Parse(sFixDate).ToString("dd-MMM-yy");
                    txtFixtureTime.Text = sFixTime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void frmAmendFixtures_Load(object sender, EventArgs e)
        {
            FillComboWithTeamsAndIds();
        }

    }
}
