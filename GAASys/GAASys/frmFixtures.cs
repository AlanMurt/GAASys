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
    public partial class frmFixtures : Form
    {
        frmWelcome parent = new frmWelcome();

        public frmFixtures()
        {
            InitializeComponent();
        }

        public frmFixtures(frmWelcome Parent)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmGenerateFixtures x = new frmGenerateFixtures();
            x.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAmendFixtures x = new frmAmendFixtures();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmEnterResults x = new frmEnterResults();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmShowLeagueTable x = new frmShowLeagueTable();
            x.Show();
        }

    }
}
