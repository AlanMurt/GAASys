using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAASys
{
    public partial class frmEnterResults : Form
    {
        public frmEnterResults()
        {
            InitializeComponent();
        }

        private Fixture fixResult = new Fixture();
        private Team teamResult = new Team();

        private int selectedFixtureId;
        private int sFixtureId;
        private int selectedTeam1IdAsInt;
        private int selectedTeam2IdAsInt;

        //close this and open fixtures form
        public void closeAndOpenFixturesForm()
        {
            this.Close();

            frmFixtures fixturesForm = new frmFixtures();
            fixturesForm.Show();
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

        private void fillComboWithFixtures()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select * from fixtures order by fixturesid";

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
                    sFixtureId = myReader.GetInt32(0);
                    int sTeam1Id = myReader.GetInt32(1);
                    int sTeam2Id = myReader.GetInt32(2);
                    

                    String sTeam1Name = teamResult.getTeamNameFromId(sTeam1Id);
                    String sTeam2Name = teamResult.getTeamNameFromId(sTeam2Id);
                    String fixtureDetails = sFixtureId + " - " + sTeam1Name + " v " + sTeam2Name;
                    selectedTeam2IdAsInt = teamResult.getTeamIdFromFixID(sFixtureId);
                    fixtureComboBox.Items.Add(fixtureDetails);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void updateTeamsResults()
        {
            //variables
            int team1score = Convert.ToInt32(txtTeam1Goals.Text) * 3 + Convert.ToInt32(txtTeam1Points.Text);
            int team2score = Convert.ToInt32(txtTeam2Goals.Text) * 3 + Convert.ToInt32(txtTeam2Points.Text);

           

            //MessageBox.Show(teamResult.getWon().ToString());

            if (team1score > team2score)
            {
                teamResult.enterResults(selectedTeam1IdAsInt, 1, 0, 0, team1score, team2score, 2);
            }
            else if (team1score == team2score)
            {
                teamResult.setTeamDrawn(1);
                teamResult.setScoresFor(team1score);
                teamResult.setScoresAgainst(team2score);
                teamResult.setPoints(1);
            }
            else
            {
                teamResult.setTeamLost(1);
                teamResult.setScoresFor(team1score);
                teamResult.setScoresAgainst(team2score);
                teamResult.setPoints(0);
            }

            teamResult.updateTeamResultsFromId(selectedTeam1IdAsInt);

            //update team2 in the db

           

        }

     /*   private void updateTeamsResults()
        {
            //variables
            int team1score = Convert.ToInt32(txtTeam1Goals.Text) * 3 + Convert.ToInt32(txtTeam1Points.Text);
            int team2score = Convert.ToInt32(txtTeam2Goals.Text) * 3 + Convert.ToInt32(txtTeam2Points.Text);



            //update team1 in db
            teamResult.enterResults()

            //get team1 data from db
            teamResult = teamResult.getThisTeamsPerformanceDataFromId(selectedTeam1IdAsInt);

            //MessageBox.Show(teamResult.getWon().ToString());

            if (team1score > team2score)
            {
                teamResult.setTeamWon(1);
                teamResult.setScoresFor(team1score);
                teamResult.setScoresAgainst(team2score);
                teamResult.setPoints(2);
            }
            else if (team1score == team2score)
            {
                teamResult.setTeamDrawn(1);
                teamResult.setScoresFor(team1score);
                teamResult.setScoresAgainst(team2score);
                teamResult.setPoints(1);
            }
            else
            {
                teamResult.setTeamLost(1);
                teamResult.setScoresFor(team1score);
                teamResult.setScoresAgainst(team2score);
                teamResult.setPoints(0);
            }
            

            teamResult.updateTeamResultsFromId(selectedTeam1IdAsInt);

            //update team2 in the db

            //get team2 data from db
            teamResult = teamResult.getThisTeamsPerformanceDataFromId(selectedTeam2IdAsInt);

            if (team2score > team1score)
            {
                teamResult.setTeamWon(1);
                teamResult.setScoresFor(team2score);
                teamResult.setScoresAgainst(team1score);
                teamResult.setPoints(2);
            }
            else if (team1score == team2score)
            {
                teamResult.setTeamDrawn(1);
                teamResult.setScoresFor(team2score);
                teamResult.setScoresAgainst(team1score);
                teamResult.setPoints(1);
            }
            else
            {
                teamResult.setTeamLost(1);
                teamResult.setScoresFor(team2score);
                teamResult.setScoresAgainst(team1score);
                teamResult.setPoints(0);
            }


            teamResult.updateTeamResultsFromId(selectedTeam2IdAsInt);

        }   */

        private void updateFixtureResults()
        {
            fixResult.setTeam1Goals(Convert.ToInt32(txtTeam1Goals.Text));
            fixResult.setTeam1Points(Convert.ToInt32(txtTeam1Points.Text));
            fixResult.setTeam2Goals(Convert.ToInt32(txtTeam2Goals.Text));
            fixResult.setTeam2Points(Convert.ToInt32(txtTeam2Points.Text));
            fixResult.enterResult(fixtureComboBox.Text[0].ToString());
        }

        private bool isDataNull()
        {
            if (String.IsNullOrEmpty(txtTeam1Goals.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeam1Points.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeam2Goals.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeam2Points.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isInputValid()
        {
            if(Int32.Parse(txtTeam1Goals.Text) < 0 || Int32.Parse(txtTeam1Goals.Text) > 99)
            {
                return false;
            }
            else if(Int32.Parse(txtTeam1Points.Text) < 0 || Int32.Parse(txtTeam1Points.Text) > 99)
            {
                return false;
            }
            else if(Int32.Parse(txtTeam2Goals.Text) < 0 || Int32.Parse(txtTeam2Goals.Text) > 99)
            {
                return false;
            }
            else if (Int32.Parse(txtTeam2Points.Text) < 0 || Int32.Parse(txtTeam2Points.Text) > 99)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenFixturesForm();
        }

        private void submitResultsButton_Click(object sender, EventArgs e)
        {
            
            
            //Check if there is any empty fields
            if (isDataNull())
            {
                if (isInputValid())
                {
                    //update fixture details in the teams table
                    updateTeamsResults();

                    //update fixture details in fixtures table
                    updateFixtureResults();
                    
                    MessageBox.Show("The result has been stored", "Storing Result...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Display error message
                    MessageBox.Show("The details you entered are invalid\nHint - All input must be number only between 0 and 99", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //Display error message
                MessageBox.Show("The details you entered are invalid\nHint - Don't leave any fields blank", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            closeAndOpenFixturesForm();
        }

        private void frmEnterResults_Load(object sender, EventArgs e)
        {
            FillComboWithTeamsAndIds();
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset combobox with list of team fixtures
            fixtureComboBox.Items.Clear();

            //set the fixture combo box to visible when a team is selected
            fixtureComboBox.Visible = true;
            fixtureLabel.Visible = true;
            

            //set the text to blank for the fixtre combobox
            //this is for if the user wants to change a different teams fixture after already selecting a team
            fixtureComboBox.Text = "";

            //set the fixture group box to not visible when the team is selected as a fixture needs to be selected before the group box
            //details can be changed
            //this is for if the user wants to change a different teams fixture after already selecting a team
            grpResults.Visible = false;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String selectedTeamId = teamComboBox.Text[0].ToString() + teamComboBox.Text[1].ToString();
            selectedTeam1IdAsInt = Int32.Parse(selectedTeamId);

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


                    String firstTeamName = teamResult.getTeamNameFromId(firstTeamId);
                    String secondTeamName = teamResult.getTeamNameFromId(secondTeamId);


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
            grpResults.Visible = true;            
        }


        /*     private void selectFixtureCombo_SelectedIndexChanged(object sender, EventArgs e)
             {
                 //Connect to db
                 OracleConnection conn = new OracleConnection(DBConnect.oradb);

                 //Define SQL Query
                 String strSQL = "select * from fixtures where fixturesid=" + sFixtureId.ToString();

                 //Define Oracle command
                 OracleCommand cmd = new OracleCommand(strSQL, conn);
                 conn.Open();

                 OracleDataReader myReader;
                 try
                 {
                     myReader = cmd.ExecuteReader();

                     while (myReader.Read())
                     {
                         int team1Goals = myReader.GetInt32(3);
                         int team1Points = myReader.GetInt32(4);
                         int team2Goals = myReader.GetInt32(5);
                         int team2Points = myReader.GetInt32(6);

                         txtTeam1Goals.Text = team1Goals.ToString();
                         txtTeam1Points.Text = team1Points.ToString();
                         txtTeam2Goals.Text = team2Goals.ToString();
                         txtTeam2Points.Text = team2Points.ToString();
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 conn.Close();
             }   */

    }
}
