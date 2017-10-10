using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Net.Mail;

namespace GAASys
{
    public partial class frmChangeTeam : Form
    {
        Team changeTeam = new Team();

        public frmChangeTeam()
        {
            InitializeComponent();           
        }

        //close this and open teams form
        public void closeAndOpenTeamsForm()
        {
            this.Close();

            frmTeams teamsForm = new frmTeams();
            teamsForm.Show();
        }


        //get list of teams for the combo box
        private void fillComboWithTeams()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
          
            //Define SQL Query
            String strSQL = "select * from teams order by name";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();

            OracleDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                selectTeamCombo.Items.Clear();
                while(myReader.Read())
                {
                    String sName = myReader.GetString(1);
                    selectTeamCombo.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }


        //check if any data is left null
        private bool isDataNull()
        {
            if (String.IsNullOrEmpty(txtTeamName.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeamVenue.Text))
            {
                return false;
            }      
            else
            {
                return true;
            }
        }


        //check is the email valid
        public bool IsEmailValid()
        {
            if (String.IsNullOrEmpty(txtTeamEmail.Text))
            {
                return false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(txtTeamEmail.Text);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }


        //Back button click event
        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenTeamsForm();
        }


        private void selectTeamCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select * from teams where name='" + selectTeamCombo.Text + "' ";

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
                    changeTeam.setTeamId(myReader.GetInt32(0));
                    changeTeam.setTeamName(myReader.GetString(1));
                    changeTeam.setTeamVenue(myReader.GetString(2));
                    changeTeam.setTeamEmail(myReader.GetString(3));
                    changeTeam.setTeamContactName(myReader.GetString(4));
                    changeTeam.setTeamContactNumber(myReader.GetString(5));
                    txtTeamId.Text = changeTeam.getTeamId().ToString();
                    txtTeamName.Text = changeTeam.getTeamName();
                    txtTeamVenue.Text = changeTeam.getTeamVenue();
                    txtTeamEmail.Text = changeTeam.getTeamEmail();
                    txtTeamContactName.Text = changeTeam.getTeamContactName();
                    txtTeamContactNumber.Text = changeTeam.getTeamContactNumber();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

            grpTeam.Visible = true;
        }


        //attempt to alter the team


        private void frmChangeTeam_Load(object sender, EventArgs e)
        {
            fillComboWithTeams();
        }

        private void changeTeamButton_Click(object sender, EventArgs e)
        {

            //Check if there is any empty fields
            if (isDataNull())
            {
                //Checks if the email address is valid
                if (IsEmailValid())
                {

                    //set the text box details as this teams details
                    changeTeam.setTeamName(txtTeamName.Text);
                    changeTeam.setTeamVenue(txtTeamVenue.Text);
                    changeTeam.setTeamEmail(txtTeamEmail.Text);
                    changeTeam.setTeamContactName(txtTeamContactName.Text);
                    changeTeam.setTeamContactNumber(txtTeamContactNumber.Text);

                    //update team details in the database
                    changeTeam.updateTeamFromName(selectTeamCombo.Text);

                    //Display confirmation message
                    MessageBox.Show("Your team have been updated", "Updating...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    selectTeamCombo.SelectedIndex = -1;

                    //reset UI
                    grpTeam.Visible = false;
                    

                }
                else
                {
                    //Display error message
                    MessageBox.Show("The details you entered are invalid\nHint - Check that your email address is correct", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTeamEmail.Focus();
                }
            }
            else
            {
                //Display error message
                MessageBox.Show("The details you entered are invalid\nHint - Don't leave any fields blank", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }
    }
    }
    

