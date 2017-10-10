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
    public partial class frmWeeklyFixtures : Form
    {
        public frmWeeklyFixtures()
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenAnalysisForm();
        }

        private void viwFixturesButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
