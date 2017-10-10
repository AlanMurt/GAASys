using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAASys
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }


        private void TeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmTeams nextForm = new frmTeams(this);
            nextForm.Show();
        }

        private void FixturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmFixtures nextForm = new frmFixtures(this);
            nextForm.Show();
        }

        private void AnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAnalysis nextForm = new frmAnalysis(this);
            nextForm.Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
