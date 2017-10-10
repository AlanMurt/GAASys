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
    public partial class frmAnalysis : Form
    {
        frmWelcome parent = new frmWelcome();

        public frmAnalysis()
        {
            InitializeComponent();
        }

        public frmAnalysis(frmWelcome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmWelcome x = new frmWelcome();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmViewTeamProfile x = new frmViewTeamProfile();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmWeeklyFixtures x = new frmWeeklyFixtures();
            x.Show();
        }

    }
}
