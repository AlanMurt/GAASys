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
    public partial class frmViewTeamProfile : Form
    {

        private Team viewTeam = new Team();

        public frmViewTeamProfile()
        {
            InitializeComponent();
        }

        //close this and open analysis form
        public void closeAndOpenAnalysisForm()
        {
            this.Close();

            frmAnalysis analysisForm = new frmAnalysis();
            analysisForm.Show();
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

                while (myReader.Read())
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


        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenAnalysisForm();
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
                    viewTeam.setTeamId(myReader.GetInt32(0));
                    viewTeam.setTeamName(myReader.GetString(1));
                    viewTeam.setTeamVenue(myReader.GetString(2));
                    viewTeam.setTeamEmail(myReader.GetString(3));
                    viewTeam.setTeamWon(myReader.GetInt32(6));
                    viewTeam.setTeamLost(myReader.GetInt32(7));
                    viewTeam.setTeamDrawn(myReader.GetInt32(8));
                    viewTeam.setScoresFor(myReader.GetInt32(9));
                    viewTeam.setScoresAgainst(myReader.GetInt32(10));
                    viewTeam.setPoints(myReader.GetInt32(11));

                    txtTeamId.Text = viewTeam.getTeamId().ToString();
                    txtTeamName.Text = viewTeam.getTeamName();
                    txtTeamVenue.Text = viewTeam.getTeamVenue();
                    txtTeamEmail.Text = viewTeam.getTeamEmail();
                    txtTeamWon.Text = viewTeam.getWon().ToString();
                    txtTeamLost.Text = viewTeam.getLost().ToString();
                    txtTeamDrawn.Text = viewTeam.getDrawn().ToString();
                    txtTeamScoresFor.Text = viewTeam.getScoresFor().ToString();
                    txtTeamScoresAgainst.Text = viewTeam.getScoresAgainst().ToString();
                    txtTeamPoints.Text = viewTeam.getPoints().ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void frmViewTeamProfile_Load(object sender, EventArgs e)
        {
            fillComboWithTeams();
        }
    }
}
