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
    public partial class FormRegisterStaff : Form
    {
        public FormRegisterStaff()
        {
            InitializeComponent();
        }

        private void btnSudmit_Click(object sender, EventArgs e)
        {
            LoginAccount staff = new LoginAccount();
            staff.sex = rbnM.Text;
            if (rbnM.Checked)
            {
                staff.sex = rbnF.Text;
            }
    
            staff.username = txtUser.Text;
            staff.Pass = txtPass.Text;
            staff.name = txtName.Text;
     
            staff.birthday = dtpBirthday.Text;
            staff.joined = DateTime.Now.ToString();
            staff.address = txtAddress.Text;
            staff.phone = txtPhone.Text;
            try
            {

                DatabaseConnect.db.LoginAccounts.Add(staff);
                DatabaseConnect.db.SaveChanges();
                MessageBox.Show("Complete!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Username had been registered");
            }
         
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
