using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace GAASys
{
    public class Team
    {
        //instance variables
        private int teamId;
        private String teamName;
        private String teamVenue;
        private String teamEmail;
        private String teamContactName;
        private String teamContactNumber;
        private int won;
        private int lost;
        private int drawn;
        private int scoresFor;
        private int scoresAgainst;
        private int points;


        //constructor
        public Team()
        {
            
        }



        //Setters
        public void setTeamId(int TeamId)
        {
            teamId = TeamId;
        }

        public void setTeamName(String TeamName)
        {
            teamName = TeamName;
        }

        public void setTeamVenue(String TeamVenue)
        {
            teamVenue = TeamVenue;
        }

        public void setTeamEmail(String TeamEmail)
        {
            teamEmail = TeamEmail;
        }

        public void setTeamContactName(String TeamContactName)
        {
            teamContactName = TeamContactName;
        }

        public void setTeamContactNumber(String TeamContactNumber)
        {
            teamContactNumber = TeamContactNumber;
        }

        public void setTeamWon(int Won)
        {
            won = Won;
        }   

        public void setTeamLost(int Lost)
        {
            lost = Lost;
        }

        public void setTeamDrawn(int Drawn)
        {
            drawn = Drawn;
        }

        public void setScoresFor(int ScoresFor)
        {
            scoresFor = ScoresFor;
        }

        public void setScoresAgainst(int ScoresAgainst)
        {
            scoresAgainst = ScoresAgainst;
        }

        public void setPoints(int Points)
        {
            points = Points;
        }



        //Getters
        public int getTeamId()
        {
            return teamId;
        }
        public String getTeamName()
        {
            return teamName;
        }

        public String getTeamVenue()
        {
            return teamVenue;
        }

        public String getTeamEmail()
        {
            return teamEmail;
        }

        public String getTeamContactName()
        {
            return teamContactName;
        }


        public String getTeamContactNumber()
        {
            return teamContactNumber;
        }
        public int getWon()
        {
            return won;
        }

       public int getLost()
        {
            return lost;
        }

        public int getDrawn()
        {
            return drawn;
        }

        public int getScoresFor()
        {
            return scoresFor;
        }

        public int getScoresAgainst()
        {
            return scoresAgainst;
        }

        public int getPoints()
        {
            return points;
        }


        //Other methods for this class
        

        //get the next team id
        public int getNextTeamId()
        {
            //next TeamId
            int teamId;
            
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT MAX(TeamId) FROM Teams";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //if no data present set team id to 1
            if (dr.IsDBNull(0))
            {
                teamId = 1;
            }
            //Otherwise, set next TeamId to MAX + 1
            else
            {
                teamId = dr.GetInt32(0) + 1;
            }

            //Close DB connection
            conn.Close();
            return teamId;
        }


        //insert this team into the database
        public void insTeam()
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "INSERT INTO Teams (TeamId, Name, Venue, Email, ContactName, ContactNumber, won, lost, drawn, scoresFor, scoresAgainst, points) VALUES (" +
            teamId + ",'" + teamName + "','" + teamVenue + "','" + teamEmail + "','" +
            teamContactName + "','" + teamContactNumber + "', 0, 0, 0, 0, 0, 0)";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        //update team
        public void updateTeamFromName(String teamToChange)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "update Teams set Name='" + teamName +
                                           "', Venue='" + teamVenue +
                                           "', Email='" + teamEmail +
                                           "', ContactName='" + teamContactName +
                                           "', ContactNumber='" + teamContactNumber +
                                           "' where name='" + teamToChange + "' ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //update team
        public void updateTeamResultsFromId(int teamToChange)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "update Teams set won= won + " + won +
                                           ", lost= lost + " + lost +
                                           ", drawn= drawn + " + drawn +
                                           ", scoresfor= scoresfor + " + scoresFor +
                                           ", scoresagainst= scoresagainst + " + scoresAgainst +
                                           ", points= points + " + points +
                                           " where teamid=" + teamToChange.ToString();

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //remove team
        public String removeTeam(String teamToRemove)
        {
            String sReturn;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "delete from Teams where Name='" + teamToRemove + "' ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            //Execute
            
            try
            {
                cmd.ExecuteNonQuery();
                sReturn = "The selected team has been removed";
            }
            catch (Exception ex)
            {
                sReturn = "An error has occured. \n\n" + ex.Message;
            }

            conn.Close();

            return sReturn;
        }


        //get the number of teams in the database
        public int getNoOfTeamsInDB()
        {
            //variable
            int noOfTeamsInDb; 

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select count(teamid) from teams";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            noOfTeamsInDb = dr.GetInt32(0);

            conn.Close();

            return noOfTeamsInDb;

        }

        public Boolean doesTwelveTeamsExistInDB()
        {
            int noOfTeamsInDB = getNoOfTeamsInDB();

            if (noOfTeamsInDB == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if each teamid between 1 and 12 has team data
        public int doesEachTeamIdExist()
        {
            

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            for(int checkTeamId = 1; checkTeamId <=12 ; checkTeamId++ )
            {
                // Define SQL Query
                String strSQL = "Select teamid from teams where teamid = " + checkTeamId ;

                //Define Oracle command
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                conn.Open();

                //Execute
                if(cmd.ExecuteScalar() == null)
                {
                    return checkTeamId;
                }
                

                conn.Close();

            }

            //return 0 if all teamid's exist in the database
            return 0;
        }


        //return parameters teams venue 
        public String getVenue(int teamid)
        {
            //
            String venue;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT venue FROM Teams where teamid = " + teamid;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            venue = dr.GetString(0);

            return venue;
            
        }

        //return team id from team name
        public int getTeamIdFromName(String tName)
        {
            int tId;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT teamid FROM Teams where name = '" + tName + "'";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            tId = dr.GetInt32(0);
            conn.Close();
            return tId;
        }

        //return team name from id
        public String getTeamNameFromId(int tId)
        {
            String tName;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT name FROM Teams where teamId = " + tId ;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            tName = dr.GetString(0);
            conn.Close();
            return tName;
        }

        public int getTeamIdFromFixID(int fId)
        {
            int teamId;

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT * FROM Fixtures where FixturesId = " + fId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            teamId = dr.GetInt32(2);
            conn.Close();
            return teamId;
        }

        public void enterResults(int tId, int Won, int Lost, int Drawn, int ScoresFor, int ScoresAgainst, int Points )
        {

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT * FROM Teams where teamId = " + tId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            /*        //Define SQL Query
                    strSQL = "update Teams set won= " + Won + dr.GetInt32(6) +
                                                   ", lost= " + Lost + dr.GetInt32(7) +
                                                   ", drawn= " + Drawn + dr.GetInt32(8) +
                                                   ", scoresfor= " + ScoresFor + dr.GetInt32(9) +
                                                   ", scoresagainst= " + ScoresAgainst + dr.GetInt32(10) +
                                                   ", points= " + Points + dr.GetInt32(11) +
                                                   " where teamid=" + tId.ToString();
                                                   */

            //Define SQL Query
            strSQL = "insert into Teams(won,lost, drawn, scoresfor, scoresagainst, points) " +
                                          "values (" + Won + dr.GetInt32(6) + 
                                           ","  + Lost + dr.GetInt32(7) +
                                           "," + Drawn + dr.GetInt32(8) +
                                           "," + ScoresFor + dr.GetInt32(9) +
                                           "," + ScoresAgainst + dr.GetInt32(10) +
                                           "," + Points + dr.GetInt32(11) +
                                           ") where teamid=" + tId.ToString();

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Team getThisTeamsPerformanceDataFromId(int tId)
        {
            Team teamPD = new Team();

            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT * FROM Teams where teamId = " + tId;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            teamPD.setTeamWon(dr.GetInt32(6));
            teamPD.setTeamLost(dr.GetInt32(7));
            teamPD.setTeamDrawn(dr.GetInt32(8));
            teamPD.setScoresFor(dr.GetInt32(9));
            teamPD.setScoresAgainst(dr.GetInt32(10));
            teamPD.setPoints(dr.GetInt32(11));

            conn.Close();

            return teamPD;
        }


    }
}
