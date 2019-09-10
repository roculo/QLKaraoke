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
    public partial class FormMemberEdit : Form
    {
        public FormMemberEdit()
        {
            InitializeComponent();
        }
        public void RemoveText(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = "Enter text here...";
        }
        private void FormEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.qLResortDataSet.Member);
            txtSearch.Text = "Search.......By Name";

            txtSearch.GotFocus += new System.EventHandler(RemoveText);
            txtSearch.LostFocus += new System.EventHandler(AddText);
        }

        private void dgvMember_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvMember.CurrentCell.RowIndex;
            txtId.Text = dgvMember.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvMember.Rows[index].Cells[1].Value.ToString();
            txtPhone.Text = dgvMember.Rows[index].Cells[4].Value.ToString();
            txtAddress.Text = dgvMember.Rows[index].Cells[5].Value.ToString();

            if (dgvMember.Rows[index].Cells[2].Value.ToString() == "Male")
            {
                rbnMale.Checked = true;
            }
            if (dgvMember.Rows[index].Cells[2].Value.ToString() == "Female")
            {
                rbnFemale.Checked = true; ;
            }

            DateTime dt = DateTime.Parse(dgvMember.Rows[index].Cells[3].Value.ToString());
            dtpAge.Value = dt;
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadData()
        {
            var lstMember = DatabaseConnect.db.Members.ToList();
            //Load Data into datagridview
            dgvMember.DataSource = lstMember;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            String sex = "";
            if (rbnMale.Checked)
                sex = "Male";
            else
                sex = "Female";


            var member = DatabaseConnect.db.Members.Where(s=>s.idcard==txtId.Text).SingleOrDefault();
            member.name = txtName.Text;
            member.phone = txtPhone.Text;
            member.address = txtAddress.Text;
            member.born = dtpAge.Text;
            member.sex = sex;
            DatabaseConnect.db.SaveChanges();
    
            //load again datagriview
            loadData();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var member = DatabaseConnect.db.Members.Where(s => s.idcard == txtId.Text).SingleOrDefault();
            DatabaseConnect.db.Members.Remove(member);
            DatabaseConnect.db.SaveChanges();
            //load again datagriview
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            var lstMember = DatabaseConnect.db.Members.Where(s => s.name.Contains(txtSearch.Text)).ToList();
            //Load Data into datagridview
            dgvMember.DataSource = lstMember;
  
        }
    }
}
