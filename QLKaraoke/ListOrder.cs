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
    public partial class ListOrder : Form
    {
        String ordervalue;

        public ListOrder()
        {
            InitializeComponent();
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.FoodServices' table. You can move, or remove it, as needed.
            this.foodServicesTableAdapter.Fill(this.qLResortDataSet.FoodServices);

        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure ?", "DELETE ORDER?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //open connection
     
                DatabaseConnect.myConn.Open();
                //excecute command

                String sql = "delete from foodservices" + " where ordervalue =" + ordervalue + "";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myCommand.ExecuteNonQuery();
                //close connection
                DatabaseConnect.myConn.Close();
                //load again datagriview
                loadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
        void loadData()
        {
            //Open database

            DatabaseConnect.myConn.Open();
            //Load database
            String sql = "select * from foodservices";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dataGridView1.DataSource = myDT;
            //Close 
            DatabaseConnect.myConn.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            ordervalue = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }
    }
}
