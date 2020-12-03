using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace frmDashboard
{
    public partial class frmCreateTeam : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public frmCreateTeam()
        {
            InitializeComponent();

        //    CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Andrei" , LastName="Serban" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Carl", LastName = "Serban" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Serban" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Mihai", LastName = "Serban" });
        }

        private void WireUpLists()
        {
          selectTeamDropDown.DataSource = null;

          selectTeamDropDown.DataSource = availableTeamMembers;
          selectTeamDropDown.DisplayMember = "FullName";

          teamMemberListBox.DataSource = null;

          teamMemberListBox.DataSource = selectedTeamMembers;
          teamMemberListBox.DisplayMember = "FullName";

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if(lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if(emailValue.Text.Length == 0)
            {
                return false;
            }
            if(cellPhoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
     
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }
    }
}
