using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    public partial class FormLogin : Form
    {
        public static string Name;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;
            
            DatabaseConnect.myConn.Open();

            String sql = "select * from LoginAccount where username='" + username + "' and pass='" + password + "'";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataReader dta = myCommand.ExecuteReader();
            if (dta.Read() == true)
            {
                dta.Close();
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                Name = myDT.Rows[0]["Name"].ToString();
                this.Hide();
                FormMenu newform = new FormMenu();
                newform.Show();
            }
            else
            {
                MessageBox.Show("Login Fail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



            DatabaseConnect.myConn.Close();

        }
    }
}
