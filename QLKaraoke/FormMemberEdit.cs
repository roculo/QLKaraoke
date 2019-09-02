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
            //Open database

            DatabaseConnect.myConn.Open();
            //Load database
            String sql = "select * from Member";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvMember.DataSource = myDT;
            //Close 
            DatabaseConnect.myConn.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            String sex = "";
            if (rbnMale.Checked)
                sex = "Male";
            else
                sex = "Female";
            //open connection

            DatabaseConnect.myConn.Open();
            //excecute command

            String sql = "update Member set  name='" + txtName.Text + "',phone='" + txtPhone.Text + "',address='" + txtAddress.Text + "',born='" + dtpAge.Text + "',sex='" + sex + "'where idcard ='" + txtId.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            myCommand.ExecuteNonQuery();
            //close connection
            DatabaseConnect.myConn.Close();
            //load again datagriview
            loadData();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //open connection

            DatabaseConnect.myConn.Open();
            //excecute command

            String sql = "delete from member" + " where idcard ='" + txtId.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            myCommand.ExecuteNonQuery();
            //close connection
            DatabaseConnect.myConn.Close();
            //load again datagriview
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Open database
            String ConnStr = "Server=DESKTOP-UNV9GNN\\SQLEXPRESS;Initial Catalog=QLKaraoke_DB;Integrated Security=True";
            SqlConnection myConn = new SqlConnection(ConnStr);
            myConn.Open();
            //Load database
            String sql = "select * from Member where name like('%" + txtSearch.Text + "%')";
            SqlCommand myCommand = new SqlCommand(sql, myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvMember.DataSource = myDT;
            //Close 
            myConn.Close();
        }
    }
}
