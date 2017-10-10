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
using System.Runtime.InteropServices;

namespace GAASys
{
    public partial class frmGenerateFixtures : Form
    {

        private Fixture newFixture = new Fixture();
        private Team newTeam = new Team();
        
        //Define attributes
        private int firstTeamId;
        private int nextTeamId = 0;

        public frmGenerateFixtures()
        {
            InitializeComponent();
        }


        //close this and open fixtures form
        public void closeAndOpenFixturesForm()
        {
            this.Close();

            frmFixtures fixturesForm = new frmFixtures();
            fixturesForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenFixturesForm();
        }

      /*  private int getFirstTeamId()
        {

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "Select teamid from teams where teamid=1";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            firstTeamId = Convert.ToInt32(cmd.ExecuteScalar());
            return firstTeamId;
        }   */

        private int getNextTeamId()
        {
            if (nextTeamId == 0)
            {
                nextTeamId = firstTeamId+1;
            }
            else
            {
                nextTeamId = nextTeamId+1;
            }

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "Select teamid from teams where teamid=" + nextTeamId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            nextTeamId = Convert.ToInt32(cmd.ExecuteScalar());

            //check if the first teamid and the second teamid for this fixture are different
            if (isFirstAndNextTeamIdDifferent())
            {
                return nextTeamId;
            }
            else
            {
                Application.Exit();
                return nextTeamId;
                
            }

            
        }

        private bool isFirstAndNextTeamIdDifferent()
        {
            if (firstTeamId == nextTeamId)
            {                
                return false;
            }
            else
                return true;
        }

        //Fixture venue is randomly decided
        private String decideFixtureVenue(int team1Id, int team2Id)
        {
            Random rndm = new Random();

            int homeVenue = rndm.Next(1, 3);
            String homeVenueAsString;
            if (homeVenue == 1)
            {
                homeVenueAsString = newTeam.getVenue(team1Id);
            }
            else
            {
                homeVenueAsString = newTeam.getVenue(team2Id);
            }

            return homeVenueAsString;
        }


        //Fixture Date is decided
        private String decideFixtureDate(int team1id, int team2id)
        {
            //returns the max fixture date of either team as a string
            String maxFixDate = newFixture.getMaxFixtureDate(team1id, team2id);

            DateTime dt;
            String fixtureDateForThisFixture;

            //check if no previous date exists for a fixture
            if (maxFixDate == null)
            {
                //if no previous date exists for a fixture set dt as todays date and add 7 days 
                dt = DateTime.Today;
                dt = dt.AddDays(7);
                fixtureDateForThisFixture = dt.ToString("dd-MMM-yy");      
            }
            else
            {
                //set the fixture date to the either teams furthest away fixture date + 7 days
                dt = Convert.ToDateTime(maxFixDate);
                dt = dt.AddDays(7);
                fixtureDateForThisFixture = dt.ToString("dd-MMM-yy");
            }

            return fixtureDateForThisFixture;
        }   

     /*   private void genTeamId1Fixtures()
        {
            //Get Team1id
            int team1id = 1;

            //Get team2id
            LinkedList<int> team1OpponentIds = new LinkedList<int>(); // { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            team1OpponentIds.AddLast(2);
            team1OpponentIds.AddLast(3);
            team1OpponentIds.AddLast(4);
            team1OpponentIds.AddLast(5);
            team1OpponentIds.AddLast(6);
            team1OpponentIds.AddLast(7);
            team1OpponentIds.AddLast(8);
            team1OpponentIds.AddLast(9);
            team1OpponentIds.AddLast(10);
            team1OpponentIds.AddLast(11);
            team1OpponentIds.AddLast(12);


            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            MessageBox.Show(team1OpponentIds.Count().ToString());

            for (int i=0; i<team1OpponentIds.Count(); i++)
            {
                //Get the fixture id
                int fixtureId = newFixture.getNextFixtureId();

                MessageBox.Show(team1OpponentIds.ElementAt(i).ToString());

                //Define SQL Query
                String strSQL = "INSERT INTO Fixtures (FixturesID, team1id, team2id, team1goals, team1points, team2goals, team2points, venue, fixturedate, fixturetime) VALUES (" +
                fixtureId + "," + team1id + "," + team1OpponentIds.ElementAt(i) + ",0, 0, 0, 0, '" + decideFixtureVenue(team1id, team1OpponentIds.ElementAt(i)) + "' , '29-May-16', '7.30')";

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                //Execute
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            

            

        }


        private void genTeamId2Fixtures()
        {
            //Get Team1id
            int team2id = 2;

            //Get team2id
            LinkedList<int> team2OpponentIds = new LinkedList<int>(); // { 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            team2OpponentIds.AddLast(1);
            team2OpponentIds.AddLast(3);
            team2OpponentIds.AddLast(4);
            team2OpponentIds.AddLast(5);
            team2OpponentIds.AddLast(6);
            team2OpponentIds.AddLast(7);
            team2OpponentIds.AddLast(8);
            team2OpponentIds.AddLast(9);
            team2OpponentIds.AddLast(10);
            team2OpponentIds.AddLast(11);
            team2OpponentIds.AddLast(12);


            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            MessageBox.Show(team2OpponentIds.Count().ToString());

            for (int i = 0; i < team2OpponentIds.Count(); i++)
            {
                //Get the fixture id
                int fixtureId = newFixture.getNextFixtureId();

                MessageBox.Show(team2OpponentIds.ElementAt(i).ToString());

                //Define SQL Query
                String strSQL = "INSERT INTO Fixtures (FixturesID, team1id, team2id, team1goals, team1points, team2goals, team2points, venue, fixturedate, fixturetime) VALUES (" +
                fixtureId + "," + team2id + "," + team2OpponentIds.ElementAt(i) + ",0, 0, 0, 0, '" + decideFixtureVenue(team2id, team2OpponentIds.ElementAt(i)) + "' , '29-May-16', '7.30')";

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                //Execute
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
        */

        private void genTeamFixtures()
        {
            //if no - generate its fixtures
            //if yes - skip this iteration
            //why? fixtures already generated for that team as the iterator

            //get teamid for this iteration
            for (int teamid = 1; teamid<= 12; teamid++)
            {

                //does a fixture exist where this teamid is team1id
                if (newFixture.doesFixtureExistWithThisTeamIdAsTeam1Id(teamid) == false)
                {
                    //Make team2id list
                    LinkedList<int> teamOpponentIdsList = new LinkedList<int>(); 

                    //add ids for team2id to list from 1 to 12 unless except for the team1id(variable called teamid here)
                    for (int teamOpponentId = 1; teamOpponentId <= 12; teamOpponentId++)
                    {
                        if (teamOpponentId > teamid)
                        {
                            teamOpponentIdsList.AddLast(teamOpponentId);
                        }
                    }

                    //Connect to db
                    OracleConnection conn = new OracleConnection(DBConnect.oradb);

                    //make fixture for each opponent in the list
                    for (int i = 0; i < teamOpponentIdsList.Count(); i++)
                    {
                        //Get the fixture id
                        int fixtureId = newFixture.getNextFixtureId();


                        //Define SQL Query
                        String strSQL = "INSERT INTO Fixtures (FixturesID, team1id, team2id, team1goals, team1points, team2goals, team2points, venue, fixturedate, fixturetime) VALUES (" +
                        fixtureId + "," + teamid + "," + teamOpponentIdsList.ElementAt(i) + ",0, 0, 0, 0, '" + decideFixtureVenue(teamid, teamOpponentIdsList.ElementAt(i)) + "' , '" + decideFixtureDate(teamid, teamOpponentIdsList.ElementAt(i)) + "', '7:30')";

                        //Define Oracle command
                        OracleCommand cmd = new OracleCommand(strSQL, conn);
                        conn.Open();

                        //Execute
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        hbProgress.Value++;
                    }

                }
                
            }

}


        //check if 12 teams exist in database
        private bool areTeamsInDBValid()
        {
            if (newTeam.doesTwelveTeamsExistInDB())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      /*  private void makeFixtures()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Get the fixture id
            int fixtureId = newFixture.getNextFixtureId();

            //Get Team1id
            

            //Define SQL Query
            String strSQL = "INSERT INTO Fixtures (FixturesID, team1id, team2id, team1goals, team1points, team2goals, team2points, venue, fixturedate, fixturetime) VALUES (" +
            fixtureId + "," + getFirstTeamId() + "," + getNextTeamId() + ",0, 0, 0, 0, 'Direen', '29-May-16', '7.30')";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    */

        private void genFixturesButton_Click(object sender, EventArgs e)
        {
            decideFixtureDate(1, 2);
            hbProgress.Visible = true;

            if (!newFixture.doesFixtureExist())
            {
                if (areTeamsInDBValid())
                {
                    genTeamFixtures();

                    MessageBox.Show("The fixtures for next season have been generated", "Generating Fixtures...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    closeAndOpenFixturesForm();
                }
                else
                {
                    //Display error message
                    MessageBox.Show("Twelve teams must be registered to generate fixtures", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    closeAndOpenFixturesForm();
                }
            }
            else
            {
                MessageBox.Show("The fixtures for this season have already been generated", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                closeAndOpenFixturesForm();
            }

            
        }

        private void frmGenerateFixtures_Load(object sender, EventArgs e)
        {
            hbProgress.ForeColor = Color.Gold;
            hbProgress.Minimum = 0;
            hbProgress.Maximum = 66;
            hbProgress.Value = 0;
            hbProgress.Visible = false;
        }
    }
}
