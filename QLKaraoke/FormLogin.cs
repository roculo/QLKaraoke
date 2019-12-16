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
        public static String staffName;
<<<<<<< HEAD
        public static String staffUserName;
        public static String staffPass;
=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
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
            
               if (DatabaseConnect.db.LoginAccounts.Any(s => s.username == username && s.Pass == password))
            {
                var loginAcc = DatabaseConnect.db.LoginAccounts.Where(s => s.username == username).Single();
                staffName = loginAcc.name;
<<<<<<< HEAD
                staffUserName = loginAcc.username;
                staffPass = loginAcc.Pass;
               
=======

                this.Hide();
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
                FormMenu newform = new FormMenu();
                newform.Show();
                newform.Focus();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



            DatabaseConnect.myConn.Close();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegisterStaff newform = new FormRegisterStaff();
            newform.Show();
        }
<<<<<<< HEAD

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = "duongbui";
            txtPass.Text = "123";
        }
=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
    }
}
