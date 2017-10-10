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
    public partial class frmShowLeagueTable : Form
    {
        public frmShowLeagueTable()
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


        //get the leage position for each team as a column
        private void setRowNumber(DataGridView lT)
        {
            foreach (DataGridViewRow row in lT.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void frmShowLeagueTable_Load(object sender, EventArgs e)
        {
            //Connect to db
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "select name, won, lost, drawn, scoresfor, scoresagainst, points from teams order by points desc";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            try
            {
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                oda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                leagueTable.DataSource = bSource;
                oda.Update(dbdataset);
                setRowNumber(leagueTable);
                leagueTable.AllowUserToAddRows = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

    }
}
