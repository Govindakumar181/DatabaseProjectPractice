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
    public partial class SignUp : Form
    {

        DBAccess objdbAccess = new DBAccess();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userPassword = txtPassword.Text;
            string userEmail = txtEmail.Text;
            string userCountry = txtCountry.Text;


            if (userName.Equals(""))
            {
                MessageBox.Show("Please Enter the UserName");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please Enter the Password");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please Enter the Email");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please Enter the Country");
            }
            else
            {
                //MessageBox.Show("Alright");
                SqlCommand insertQuery = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@userName,@userEmail,@userPassword,@userCountry)");

                insertQuery.Parameters.AddWithValue("@userName",userName);
                insertQuery.Parameters.AddWithValue("@userEmail", userEmail);
                insertQuery.Parameters.AddWithValue("@userPassword", userPassword);
                insertQuery.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objdbAccess.executeQuery(insertQuery);

                if(row==1)
                {
                    MessageBox.Show("Account Created Successfully..");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();

                }
                else
                {
                    MessageBox.Show("Error, Try Again...");
                }

            }

        }

        
    }
}
