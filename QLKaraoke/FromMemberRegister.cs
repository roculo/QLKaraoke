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
  

            //open connection

            DatabaseConnect.myConn.Open();
            //excecute command
            try
            {
                String sql = "insert into Member (idcard,name,sex,born,phone,address,daycreate) values ('" + txtId.Text + "','" + txtName.Text + "','" + sex + "','" + dtpAge.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + lbTime.Text + "')";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                //close connection
                DatabaseConnect.myConn.Close();
                //load again datagriview
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
