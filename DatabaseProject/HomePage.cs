using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

       

        DBAccess objDbAccess = new DBAccess();

        private void HomePage_Load(object sender, EventArgs e)
        {


            lblWelcomeTitle.Text = "Welcome " + SignIn.name;

            txtNameUpdate.Text = SignIn.name;
            txtEmailUpdate.Text = SignIn.email;
            txtPasswordUpdate.Text = SignIn.password;
            txtCountryUpdate.Text = SignIn.country;
            
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

            string newUserName = txtNameUpdate.Text;
            string newPassword = txtPasswordUpdate.Text;
            string newEmail = txtEmailUpdate.Text;
            string newCountry = txtCountryUpdate.Text;

            if(newUserName.Equals(""))
            {
                MessageBox.Show("Kindly Insert the UserName to Update.");
            }
            else if (newEmail.Equals(""))
            {
                MessageBox.Show("Kindly Insert the Email to Update.");
            }
            else if (newPassword.Equals(""))
            {
                MessageBox.Show("Kindly Insert the Password to Update.");
            }
            else if (newCountry.Equals(""))
            {
                MessageBox.Show("Kindly Insert the Country to Update.");
            }
            else
            {

                string query = "Update Users SET Name = '" + @newUserName + "', Password = '" + @newPassword + "', Email = '" + @newEmail + "', Country = '" + @newCountry + "' where ID = '" + SignIn.id + "'";

                SqlCommand updateQuery = new SqlCommand(query);

                int rows = objDbAccess.executeQuery(updateQuery);

                updateQuery.Parameters.AddWithValue("@newUserName", @newUserName);
                updateQuery.Parameters.AddWithValue("@newEmail", @newEmail);
                updateQuery.Parameters.AddWithValue("@newPassword", @newPassword);
                updateQuery.Parameters.AddWithValue("@newCountry", @newCountry);

                if(rows==1)
                {
                    MessageBox.Show("Account Updated Successfully");

                    this.Hide();
                    SignIn logIn = new SignIn();
                    logIn.Show();
                }

                else
                {
                    MessageBox.Show("Update Failed");
                }

            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {


                string query = "Delete from Users where ID = '" + SignIn.id + "'";
                SqlCommand deleteQuery = new SqlCommand(query);

                int rows = objDbAccess.executeQuery(deleteQuery);


                if (rows == 1)
                {
                    MessageBox.Show("Account Deleted Successfully");

                    this.Hide();
                    SignIn logIn = new SignIn();
                    logIn.Show();
                }

                else
                {
                    MessageBox.Show("Delete Failed");
                }
            }

        }
    }
}
