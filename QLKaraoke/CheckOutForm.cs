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
    public partial class CheckOutForm : Form
    {
        int tienroom = 0;
        int tienfood = 0;
        int tienservice = 0;
        int tongtien = 0;
        public CheckOutForm()
        {
            InitializeComponent();
            dgvFoodBeverage.Visible = false;
            dgvRoom.Visible = false;
            lbstaff.Text = "Staff : " + FormLogin.Name;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            //try
            //{
                dgvFoodBeverage.Visible = true;
                dgvRoom.Visible = true;
                //Open database

                DatabaseConnect.myConn.Open();
                //Load database
                String sql = "select * from member where idcard='" + txtId.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                if (myDT.Rows[0]["idcard"].ToString() == txtId.Text)
                {
                    txtId.Enabled = false;
                    lbName.Text = myDT.Rows[0]["name"].ToString();
                    lbName.Visible = true;
                }
                //Load number Invoice
                sql = "select top 1 idinvoice from Invoice order by idinvoice desc";
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);


                lbInvoice.Text = (Int16.Parse(myDT.Rows[0]["idinvoice"].ToString()) + 1).ToString();


                //Load database Room
                sql = "select r.idroom,cash,checkin,checkout,r.paid from room r, RoomBooking b where b.idcard like('%" + txtId.Text + "%') and r.idroom = b.idroom and checked IS NULL";

                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvRoom.DataSource = myDT;
                double thanhtienphong = 0;
                int vv = dgvRoom.Rows.Count;
                for (int i = 0; i < vv; i++)
                {
                    double moneyper = Int32.Parse(dgvRoom.Rows[i].Cells["cash"].Value.ToString());
                    double paid = Int32.Parse(dgvRoom.Rows[i].Cells["paid"].Value.ToString());
                    String first = dgvRoom.Rows[i].Cells["checkin"].Value.ToString();
                    String last = dgvRoom.Rows[i].Cells["checkout"].Value.ToString();
                    if (last == "")
                    {
                        last = DateTime.Now.ToString();
                        sql = "  update RoomBooking set checkout='"+last+"' where idcard='" + txtId.Text + "'";
                        myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                        SqlDataReader dta = myCommand.ExecuteReader();
                        dta.Close();
                    }
                    TimeSpan duration = DateTime.Parse(last).Subtract(DateTime.Parse(first));
                    double totaltime = duration.TotalHours;
                    thanhtienphong += totaltime * moneyper - paid;

                }
                lbMoneyRoom.Text = "" + thanhtienphong.ToString("C");



                //Load database Food and Beverage
                sql = "select * from foodservices where idcard like('%" + txtId.Text + "%')  and checked IS NULL";
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvFoodBeverage.DataSource = myDT;
                int sc = dgvFoodBeverage.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                    thanhtien += float.Parse(dgvFoodBeverage.Rows[i].Cells["value"].Value.ToString());
                lbMoneyFood.Text = "" + thanhtien.ToString("C");



                double total = thanhtienphong + thanhtien;
                // bien an
                tienroom = (int)thanhtienphong;
                tienfood = (int)thanhtien;
                tongtien = tienfood + tienroom + tienservice;

                lbTotal.Text = "" + total.ToString("C");
                //Close
                DatabaseConnect.myConn.Close();
            //}
            //catch
            //{
            //    dgvFoodBeverage.Visible = false;
            //    dgvRoom.Visible = false;
            //    MessageBox.Show("This Member is not Register yet");
            //}
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.FoodServices' table. You can move, or remove it, as needed.
            this.foodServicesTableAdapter.Fill(this.qLResortDataSet.FoodServices);
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.qLResortDataSet.Room);
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);


        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            DatabaseConnect.myConn.Open();

            String sql = "insert into Invoice(member,room,foodandbeverage,service,total,daycreate,staff) values('" + txtId.Text + "'," + tienroom + "," + tienfood + "," + tienservice + "," + tongtien + ",'" + DateTime.Now + "','" + lbstaff.Text + "')";
            SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataReader dta = myCommand.ExecuteReader();
            dta.Close();

            sql = "  update FoodServices set checked=(select top 1 idinvoice from Invoice order by idinvoice desc ) where idcard='" + txtId.Text + "' and checked IS NULL";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            dta = myCommand.ExecuteReader();
            dta.Close();

            sql = "  update room set idcard=NULL,timestart=NULL,timeend=NULL where idcard='" + txtId.Text + "'";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            dta = myCommand.ExecuteReader();
            dta.Close();

            sql = "  update roombooking set checked=(select top 1 idinvoice from Invoice order by idinvoice desc ) where idcard='" + txtId.Text + "' and checked IS NULL";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            dta = myCommand.ExecuteReader();
            dta.Close();


            //-------------------------------------------------------------------------------------
            //Load database
            sql = "select * from member where idcard='" + txtId.Text + "'";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            SqlDataAdapter myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            DataTable myDT = new DataTable();
            myDa.Fill(myDT);
            if (myDT.Rows[0]["idcard"].ToString() == txtId.Text)
            {
                txtId.Enabled = false;
                lbName.Text = myDT.Rows[0]["name"].ToString();
                lbName.Visible = true;
            }

            //Load database Room
            sql = "select * from room where idcard like('%" + txtId.Text + "%')";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvRoom.DataSource = myDT;
            double thanhtienphong = 0;
            int vv = dgvRoom.Rows.Count;
            for (int i = 0; i < vv; i++)
            {
                double moneyper = Int32.Parse(dgvRoom.Rows[i].Cells["cash"].Value.ToString());
                double paid = Int32.Parse(dgvRoom.Rows[i].Cells["paid"].Value.ToString());
                DateTime dt = Convert.ToDateTime(dgvRoom.Rows[i].Cells["timestart"].Value.ToString());
                DateTime dt2 = Convert.ToDateTime(dgvRoom.Rows[i].Cells["timeend"].Value.ToString());
                TimeSpan dt3 = dt2 - dt;
                double totalday = dt3.TotalDays;
                thanhtienphong += totalday * moneyper - paid;

            }
            lbMoneyRoom.Text = "" + thanhtienphong;



            //Load database Food and Beverage
            sql = "select * from foodservices where idcard like('%" + txtId.Text + "%')  and checked IS NULL";
            myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
            myDa = new SqlDataAdapter();
            myDa.SelectCommand = myCommand;
            myDT = new DataTable();
            myDa.Fill(myDT);
            //Load Data into datagridview
            dgvFoodBeverage.DataSource = myDT;
            int sc = dgvFoodBeverage.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dgvFoodBeverage.Rows[i].Cells["value"].Value.ToString());
            lbMoneyFood.Text = "" + thanhtien;


            //Load Data into datagridview

            double thanhtien2 = 0;
            double total = thanhtienphong + thanhtien + thanhtien2;
            lbTotal.Text = "" + total;

            //-----------------------------------


            //Close
            DatabaseConnect.myConn.Close();
        }
        //--------------------------------------------------------------------------
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;

        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;
        private string InvImage;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;
        private string CustomerName;
        private string CustomerCity;
        private string SellerName;
        private string SaleID;
        private string SaleDate;
        private decimal SaleFreight;
        private decimal SubTotal;
        private decimal InvoiceTotal;
        private bool ReadInvoice;
        private int AmountPosition;

        // Font and Color:------------------
        // Title Font
        private Font InvTitleFont = new Font("Arial", 24, FontStyle.Regular);
        // Title Font height
        private int InvTitleHeight;
        // SubTitle Font
        private Font InvSubTitleFont = new Font("Arial", 14, FontStyle.Regular);
        // SubTitle Font height
        private int InvSubTitleHeight;
        // Invoice Font
        private Font InvoiceFont = new Font("Arial", 12, FontStyle.Regular);
        // Invoice Font height
        private int InvoiceFontHeight;
        // Blue Color
        private SolidBrush BlueBrush = new SolidBrush(Color.Blue);
        // Red Color
        private SolidBrush RedBrush = new SolidBrush(Color.Red);
        // Black Color
        private SolidBrush BlackBrush = new SolidBrush(Color.Black);
        private void SetInvoiceHead(Graphics g)
        {
            //Titles and Image of invoice:
            InvTitle = "International Food Company";
            InvSubTitle1 = "23 Abo Naga street";
            InvSubTitle2 = "Cairo, Egypt";
            InvSubTitle3 = "Phone 2233445566";

            CurrentY = topMargin;
            CurrentX = leftMargin;
            int ImageHeight = 0;



            InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            InvSubTitleHeight = (int)(InvSubTitleFont.GetHeight(g));

            // Get Titles Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            int lenInvSubTitle1 = (int)g.MeasureString(InvSubTitle1, InvSubTitleFont).Width;
            int lenInvSubTitle2 = (int)g.MeasureString(InvSubTitle2, InvSubTitleFont).Width;
            int lenInvSubTitle3 = (int)g.MeasureString(InvSubTitle3, InvSubTitleFont).Width;
            // Set Titles Left:
            int xInvTitle = CurrentX + (InvoiceWidth - lenInvTitle) / 2;
            int xInvSubTitle1 = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2;
            int xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2;
            int xInvSubTitle3 = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2;

            // Draw Invoice Head:
            if (InvTitle != "")
            {
                CurrentY = CurrentY + ImageHeight;
                g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY);
            }
            if (InvSubTitle1 != "")
            {
                CurrentY = CurrentY + InvTitleHeight;
                g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY);
            }
            if (InvSubTitle2 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY);
            }
            if (InvSubTitle3 != "")
            {
                CurrentY = CurrentY + InvSubTitleHeight;
                g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY);
            }

            // Draw line:
            CurrentY = CurrentY + InvSubTitleHeight + 8;
            g.DrawLine(new Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY);
        }
        private void SetOrderData(Graphics g)
        {// Set Company Name, City, Salesperson, Order ID and Order Date
            string FieldValue = "";
            InvoiceFontHeight = (int)(InvoiceFont.GetHeight(g));
            // Set Company Name:
            CurrentX = leftMargin;
            CurrentY = CurrentY + 8;
            FieldValue = "Staff Name: " + FormLogin.Name;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set City:
            CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            FieldValue = "City: " + "HCM City Q7";
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Salesperson:
            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Guest: " + lbName.Text;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Order ID:
            CurrentX = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            FieldValue = "Order ID: " + lbInvoice.Text;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);
            // Set Order Date:
            CurrentX = CurrentX + (int)g.MeasureString(FieldValue, InvoiceFont).Width + 16;
            FieldValue = "Order Date: " + DateTime.Now;
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY);

            // Draw line:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
        }
        private void SetInvoiceData(Graphics g, System.Drawing.Printing.PrintPageEventArgs e)
        {// Set Invoice Table:
            string FieldValue = "";
            int CurrentRecord = 0;
            int RecordsPerPage = 20; // twenty items in a page
            decimal Amount = 0;
            bool StopReading = false;

            // Set Table Head:
            int xProductID = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Room", InvoiceFont, BlueBrush, xProductID, CurrentY);

            int xProductName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 4;
            g.DrawString("Cash/Hour", InvoiceFont, BlueBrush, xProductName, CurrentY);

            int xUnitPrice = xProductName + (int)g.MeasureString("Product Name", InvoiceFont).Width + 4;
            g.DrawString("Checkin", InvoiceFont, BlueBrush, xUnitPrice, CurrentY);

            int xQuantity = xUnitPrice + (int)g.MeasureString("Unit Price", InvoiceFont).Width + 90;
            g.DrawString("Checkout", InvoiceFont, BlueBrush, xQuantity, CurrentY);

            int xDiscount = xQuantity + (int)g.MeasureString("Quantity", InvoiceFont).Width + 70;
            g.DrawString("Paid", InvoiceFont, BlueBrush, xDiscount, CurrentY);


            // Set Invoice Table:
            CurrentY = CurrentY + InvoiceFontHeight + 8;

            for (int i = 0; i < dgvRoom.RowCount; i++)
            {
                FieldValue = dgvRoom[0, i].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);

                FieldValue = Int64.Parse(dgvRoom[1, i].Value.ToString()).ToString("C");
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);

                FieldValue = dgvRoom[2, i].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xUnitPrice, CurrentY);

                FieldValue = dgvRoom[3, i].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity, CurrentY);

                FieldValue = Int64.Parse(dgvRoom[4, i].Value.ToString()).ToString("C");
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xDiscount, CurrentY);

                CurrentY = CurrentY + InvoiceFontHeight;
            }
            // Draw line:
            CurrentY = CurrentY + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);

            xProductID = leftMargin;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Name", InvoiceFont, BlueBrush, xProductID, CurrentY);

            xProductName = xProductID + (int)g.MeasureString("Product ID", InvoiceFont).Width + 40;
            g.DrawString("Quantity", InvoiceFont, BlueBrush, xProductName, CurrentY);

            xUnitPrice = xProductName + (int)g.MeasureString("Product Name", InvoiceFont).Width + 4;
            g.DrawString("Money/Per", InvoiceFont, BlueBrush, xUnitPrice, CurrentY);

            xQuantity = xUnitPrice + (int)g.MeasureString("Unit Price", InvoiceFont).Width + 90;
            g.DrawString("Total", InvoiceFont, BlueBrush, xQuantity, CurrentY);

            // Set Invoice Table:
            CurrentY = CurrentY + InvoiceFontHeight + 8;
            for (int i = 0; i < dgvFoodBeverage.RowCount; i++)
            {
                FieldValue = dgvFoodBeverage[0, i].Value.ToString();
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductID, CurrentY);

                FieldValue = String.Format("{0:0.00%}", dgvFoodBeverage[1, i].Value.ToString());
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY);

                FieldValue = Int64.Parse(dgvFoodBeverage[2, i].Value.ToString()).ToString("C");
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xUnitPrice, CurrentY);

                FieldValue = Int64.Parse(dgvFoodBeverage[3, i].Value.ToString()).ToString("C");
                g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity, CurrentY);

                CurrentY = CurrentY + InvoiceFontHeight;
            }


        }
        private void SetInvoiceTotal(Graphics g)
        {// Set Invoice Total:
         // Draw line:
            CurrentY = CurrentY + 8;
            g.DrawLine(new Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY);
            // Get Right Edge of Invoice:
            AmountPosition = 400;
            int xRightEdg = AmountPosition + 250;

            // Write Sub Total:
            int xSubTotal = AmountPosition - (int)g.MeasureString("Sub Total", InvoiceFont).Width;
            CurrentY = CurrentY + 8;
            g.DrawString("Room Money", InvoiceFont, RedBrush, 300, CurrentY);
            string TotalValue = lbMoneyRoom.Text;
            int xTotalValue = xRightEdg - (int)g.MeasureString(TotalValue, InvoiceFont).Width;
            g.DrawString(TotalValue, InvoiceFont, BlackBrush, xTotalValue, CurrentY);

            // Write Order Freight:
            int xOrderFreight = AmountPosition - (int)g.MeasureString("Order Freight", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Services", InvoiceFont, RedBrush, 300, CurrentY);
            string FreightValue = lbMoneyFood.Text;
            int xFreight = xRightEdg - (int)g.MeasureString(FreightValue, InvoiceFont).Width;
            g.DrawString(FreightValue, InvoiceFont, BlackBrush, xFreight, CurrentY);

            // Write Invoice Total:
            int xInvoiceTotal = AmountPosition - (int)g.MeasureString("Invoice Total", InvoiceFont).Width;
            CurrentY = CurrentY + InvoiceFontHeight;
            g.DrawString("Invoice Total", InvoiceFont, RedBrush, 300, CurrentY);
            string InvoiceValue = lbTotal.Text;
            int xInvoiceValue = xRightEdg - (int)g.MeasureString(InvoiceValue, InvoiceFont).Width;
            g.DrawString(InvoiceValue, InvoiceFont, BlackBrush, xInvoiceValue, CurrentY);
        }
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;



            SetInvoiceHead(e.Graphics); // Draw Invoice Head
            SetOrderData(e.Graphics); // Draw Order Head
            SetInvoiceData(e.Graphics, e); // Draw Data Head
            SetInvoiceTotal(e.Graphics); // Draw Total Head

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                prnDocument.Print();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtId.Text = comboBox1.Text;
            txtId.Enabled = false;
        }
    }
}
