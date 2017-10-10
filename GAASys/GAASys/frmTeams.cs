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
    public partial class frmTeams : Form
    {
        frmWelcome parent = new frmWelcome();

        public frmTeams()
        {
            InitializeComponent();
        }

        public frmTeams(frmWelcome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Visible = true;
        }


        private void regTeamButton_Click(object sender, EventArgs e)
        {           
            this.Hide();
            frmRegisterTeam nextForm = new frmRegisterTeam();

            nextForm.Show();
        }

        private void changeTeamButton_Click(object sender, EventArgs e)
        {
            this.Close();

            frmChangeTeam nextForm = new frmChangeTeam();
            nextForm.Show();
        }

        private void remTeamButton_Click(object sender, EventArgs e)
        {
            this.Close();

            frmRemoveTeam nextForm = new frmRemoveTeam();
            nextForm.Show();
        }

    }
}
