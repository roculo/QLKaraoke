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
        int ordervalue;

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
              
                var foodServices = DatabaseConnect.db.FoodServices.Where(s => s.OrderValue == ordervalue).SingleOrDefault();
                DatabaseConnect.db.FoodServices.Remove(foodServices);
                DatabaseConnect.db.SaveChanges();
                 loadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
        void loadData()
        {
            var lstFoodServices = DatabaseConnect.db.FoodServices.ToList();
            //Load Data into datagridview
            dataGridView1.DataSource = lstFoodServices;
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            ordervalue =Int16.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }
    }
}
