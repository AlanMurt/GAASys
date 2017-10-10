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
    public partial class frmRemoveTeam : Form
    {
        Team removeTeam = new Team();

        public frmRemoveTeam()
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
                   // int iId = myReader.GetInt32(0);
                    //String sName = myReader.GetString(1);
                    //String comboDisplayFormat = iId + " - " + sName;
                    selectTeamCombo.Items.Add(myReader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void remTeamButton_Click(object sender, EventArgs e)
        {

            String returnedMessage = removeTeam.removeTeam(selectTeamCombo.Text);

            //Display confirmation message
             MessageBox.Show(returnedMessage, "Removing...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            closeAndOpenTeamsForm();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenTeamsForm();
        }

        private void frmRemoveTeam_Load(object sender, EventArgs e)
        {
            FillComboWithTeamsAndIds();
        }

    }
}
