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
    public partial class SignIn : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public static string id, name, email, password,country;

        //private void InitializeMyControl()
        //{
        //    // Set to no text.
        //    txtPasswordLogin.Text = "";
        //    // The password character is an asterisk.
        //    txtPasswordLogin.PasswordChar = '*';
        //    // The control will allow no more than 14 characters.
            
        //}


        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();

        }

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

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count==1)
                {

                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();



                    MessageBox.Show("Logged In Successfully");
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
