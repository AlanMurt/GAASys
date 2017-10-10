using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASys
{
    public class Fixture
    {

        //instance variables
        private int fixtureId;
        private int team1Id;
        private int team2Id;
        private int team1Goals;
        private int team1Points;
        private int team2Goals;
        private int team2Points;
        private String venue;
        private String date;
        private String time;


        //constructor
        public Fixture()
        {

        }


        //Setters
        public void setfixtureId(int FixtureId)
        {
            fixtureId = FixtureId;
        }

        public void setTeam1Id(int Team1Id)
        {
            team1Id = Team1Id;
        }

        public void setTeam2Id(int Team2Id)
        {
            team2Id = Team2Id;
        }

        public void setTeam1Goals(int Team1Goals)
        {
            team1Goals = Team1Goals;
        }

        public void setTeam1Points(int Team1Points)
        {
            team1Points = Team1Points;
        }

        public void setTeam2Goals(int Team2Goals)
        {
            team2Goals = Team2Goals;
        }

        public void setTeam2Points(int Team2Points)
        {
            team2Points = Team2Points;
        }

        public void setVenue(String Venue)
        {
            venue = Venue;
        }

        public void setFixtureDate(String Date)
        {
            date = Date;
        }

        public void setFixtureTime(String Time)
        {
            time = Time;
        }


        //Getters

        public int getFixtureId()
        {
            return fixtureId;
        }

        public int getTeam1Id()
        {
            return team1Id;
        }

        public int getTeam2Id()
        {
            return team2Id;
        }

        public int getTeam1Goals()
        {
            return team1Goals;
        }

        public int getTeam1Points()
        {
            return team1Points;
        }

        public int getTeam2Goals()
        {
            return team1Goals;
        }

        public int getTeam2Points()
        {
            return team2Goals;
        }

        public String getVenue()
        {
            return venue;
        }

        public String getFixtureDate()
        {
            return date;
        }

        public String getFixtureTime()
        {
            return time;
        }

        //other methods for this class

        //check if a fixture already exits
        public Boolean doesFixtureExist()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT FixturesID FROM Fixtures";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            if(cmd.ExecuteScalar() == null)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }

            
        }

        //update fixture
        public void updateFixture(String fixtureToChange)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "update fixtures set venue='" + venue +
                                           "', fixtureDate='" + date +
                                           "', fixtureTime='" + time + "' where fixturesid = '" + fixtureToChange + "'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public Boolean doesFixtureExistWithThisTeamIdAsTeam1Id(int teamId)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT team1id FROM Fixtures where team1id =" + teamId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public int getNextFixtureId()
        {
            //next FixtureId
            int fixtureId;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT MAX(FixturesId) FROM Fixtures";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //check if fixture already exits
            if (doesFixtureExist() == true)
            {
                //get max and new id is old id+1
                fixtureId = dr.GetInt32(0) + 1;
            }
            else
            {
                //if no new id is 1
                fixtureId = 1;
            }
           

            //Close DB connection
            conn.Close();
            return fixtureId;
        }

        /*   public List<int> getListOfTeamIds()
           {
               //variables
               Team newTeam = new Team();
               int noOfTeamsInDb = newTeam.getNoOfTeamsInDB();
               String teamIdAsString;

               Console.WriteLine(noOfTeamsInDb);
               List<int> list = new List<int>();

               //Connect to db
               OracleConnection conn = new OracleConnection(DBConnect.oradb);



               for (int i = 1; i == noOfTeamsInDb; i++)
               {
                   //Define SQL Query
                   String strSQL = "Select * from teams where teamid = " + i;

                   //Define Oracle command
                   OracleCommand cmd = new OracleCommand(strSQL, conn);
                   conn.Open();


                   teamIdAsString = cmd.ExecuteScalar().ToString();

                   list.Add(Int32.Parse(teamIdAsString));


                   conn.Close();

               }


               return list;
           } */


        //update results of fixture
        public void enterResult(String fixtureToChange)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "update fixtures set team1goals='" + team1Goals +
                                           "', team1Points='" + team1Points +
                                           "', team2Goals='" + team2Goals + 
                                           "', team2Points='" + team2Points +
                                           "' where fixturesid = '" + fixtureToChange +
                                           "' ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //return the maximum date for teams fixture
        public String getMaxFixtureDate(int t1Id, int t2Id)
        {
            //variable
            String maxDate;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select max(fixturedate) from fixtures where team1id in (" + t1Id + "," + t2Id + ") or team2id in (" + t1Id + "," + t2Id + ")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            try
            {
               maxDate = dr.GetDateTime(0).ToString("dd-MMM-yy");
            }
            catch
            {
                maxDate = null;
            }
                    

            conn.Close();

            return maxDate;
        }
    }
}
