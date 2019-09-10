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
    public partial class FromMemberRegister : Form
    {
        public FromMemberRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lbTime.Text = time.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String sex = "";
            if (rbnSex.Checked)
                sex = "Male";
            else
                sex = "Female";
  

        
            try
            {
                var member = new Member();
                member.idcard = txtId.Text;
                member.name = txtName.Text;
                member.phone = txtPhone.Text;
                member.address = txtAddress.Text;
                member.sex = sex;
                member.born = dtpAge.Text;
                member.daycreate = DateTime.Now.ToString();
                DatabaseConnect.db.Members.Add(member);
                DatabaseConnect.db.SaveChanges();
                MessageBox.Show("Complete");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Member registed");
            }
        }
    }
}
