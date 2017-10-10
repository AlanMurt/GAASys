using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Net.Mail;


namespace GAASys
{
    public partial class frmRegisterTeam : Form
    {
        //initialise variables
        private Team newTeam = new Team();
        private int nextTeamIdAsInt;


        //form constructor
        public frmRegisterTeam()
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


        //Back button click event
        private void buttonBack_Click(object sender, EventArgs e)
        {
            closeAndOpenTeamsForm();
        }


        //reset form
        private void resetForm()
        {
            txtTeamId.Text = "";
            txtTeamName.Text = "";
            txtTeamVenue.Text = "";
            txtTeamEmail.Text = "";
            txtTeamContactName.Text = "";
            txtTeamContactNumber.Text = "";
            txtTeamName.Focus();
        }


        //check if any data is left null
        private bool isDataNull()
        {
            if (String.IsNullOrEmpty(txtTeamId.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtTeamName.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeamVenue.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeamEmail.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeamContactName.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtTeamContactNumber.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //check is the email valid
        public bool IsEmailValid()
        {
            try
            {
                MailAddress m = new MailAddress(txtTeamEmail.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        //attempt to register the team when the register button is clicked
        private void regButton_Click(object sender, EventArgs e)
        {
       
           
            //Check if there is any empty fields
            if (isDataNull())
            {
                //Checks if the email address is valid
                if (IsEmailValid())
                {
                    //set the text box details as this teams details
                    newTeam.setTeamId(nextTeamIdAsInt);
                    newTeam.setTeamName(txtTeamName.Text);
                    newTeam.setTeamVenue(txtTeamVenue.Text);
                    newTeam.setTeamEmail(txtTeamEmail.Text);
                    newTeam.setTeamContactName(txtTeamContactName.Text);
                    newTeam.setTeamContactNumber(txtTeamContactNumber.Text);

                    //insert team into the database
                    newTeam.insTeam();
                   

                   //Display confirmation message
                    MessageBox.Show("Your team have been registered", "Registering...", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                                      

                }
                else
                {
                    //Display confirmation message
                    MessageBox.Show("The details you entered are invalid\nHint - Check that your email address is correct", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                //Display confirmation message
                MessageBox.Show("The details you entered are invalid\nHint - Don't leave any fields blank", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Reset UI
            resetForm();

            //open last form
            closeAndOpenTeamsForm();
        }

        
        //put next team id into textbox
        private void putNextTeamIdIntoTextbox()
        {
            int txtTeamIdAsInt = newTeam.getNextTeamId();
           // txtTeamId.Text = txtTeamIdAsInt.ToString("00");

            txtTeamId.Text = newTeam.getNextTeamId().ToString("00");

            //convert team id from string to int                     
            nextTeamIdAsInt = int.Parse(txtTeamId.Text);


            //check if the next team id is greater than the maximum 12
            if (txtTeamIdAsInt > 12)
            {
                //check if each teamid between 1 and 12 exists, if not then return the teamid that doesn't
                int newTeamId = newTeam.doesEachTeamIdExist();

                //0 is returned if max teams already exist
                if (newTeamId == 0)
                {
                    MessageBox.Show("Maximum number of teams have already been registered", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeAndOpenTeamsForm();
                }
                //set the new id if not all between 1 and 12 already exist
                else if (newTeamId > 0)
                {
                    txtTeamIdAsInt = newTeamId;
                    txtTeamId.Text = newTeamId.ToString();
                    nextTeamIdAsInt = int.Parse(txtTeamId.Text); 

                }
            }

        }

        private void frmRegisterTeam_Load(object sender, EventArgs e)
        {
            putNextTeamIdIntoTextbox();
        }

    }
}
