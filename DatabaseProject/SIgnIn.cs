using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class SignIn : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dbtable = new DataTable();

        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;

            if(userEmail.Equals(""))
            {
                MessageBox.Show("Email Field cannot be Empty.");
            }
            else if(userPassword.Equals(""))
            {
                MessageBox.Show("Password Field cannot be Empty.");
            }
            else
            {
                //SqlCommand sqlCommand = new SqlCommand("select Email,Password from Users where Email = @userEmail && Password = @userPassword");
                //sqlCommand.Parameters.AddWithValue("@userEmail", userEmail);
                //sqlCommand.Parameters.AddWithValue("@userPassword", userPassword);
                //int row = objDBAccess.executeQuery(sqlCommand);

                string query = "Select * from Users where Email = '" + userEmail + "' AND Password = '" + userPassword + "'";

                objDBAccess.readDatathroughAdapter(query, dbtable);

                if(dbtable.Rows.Count==1)
                {
                    MessageBox.Show("Logined Successfully");
                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Logined Failed! Wrong Email or Password");
                }

            }
        }
    }
}
