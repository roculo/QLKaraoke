using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    public partial class FormChangePass : Form
    {
        public FormChangePass()
        {
            InitializeComponent();
            txtNewPass.UseSystemPasswordChar = true;
            txtNewPassAgain.UseSystemPasswordChar = true;
            txtOldPass.UseSystemPasswordChar = true;
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text!=FormLogin.staffPass)
            {
                MessageBox.Show("Wrong pass");
                return;
            }
            var acc=DatabaseConnect.db.LoginAccounts.Find(FormLogin.staffUserName);
            acc.Pass = txtNewPass.Text;
            DatabaseConnect.db.SaveChanges();
            MessageBox.Show("Password Changed");

        }

        private void txtNewPassAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtNewPassAgain.Text)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }
    }
}
