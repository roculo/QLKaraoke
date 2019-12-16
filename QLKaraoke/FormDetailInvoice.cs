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
    public partial class FormDetailInvoice : Form
    {
        public FormDetailInvoice()
        {
            InitializeComponent();
        }
        int tienroom = 0;
        int tienfood = 0;
        int tienservice = 0;
        int tongtien = 0;
        double discount = 0;

        private void btnFind(object sender, EventArgs e)
        {
       
            dgvFoodBeverage.Visible = true;
            dgvRoom.Visible = true;
            //Open database
            DatabaseConnect.myConn.Close();
            DatabaseConnect.myConn.Open();
            try
            {
                //Load database Invoice
                int txtidinvoice= Int16.Parse(txtId.Text);
                var invoice = DatabaseConnect.db.Invoices.Where(s => s.idinvoice ==txtidinvoice ).SingleOrDefault();
                lbName.Text = invoice.member;
                lbStaff.Text = invoice.staff;
                lbDay.Text = invoice.daycreate;



                //Load database Room
                String sql = "select r.idroom,cash,checkin,checkout,r.paid from room r, RoomBooking b where checked=" + txtId.Text + " and r.idroom = b.idroom";
                SqlCommand myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                SqlDataAdapter myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                DataTable myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvRoom.DataSource = myDT;
                double thanhtienphong = 0;
                int vv = dgvRoom.Rows.Count ;
                for (int i = 0; i < vv; i++)
                {
                    double moneyper = Int32.Parse(dgvRoom.Rows[i].Cells["cash"].Value.ToString());
                    double paid = Int32.Parse(dgvRoom.Rows[i].Cells["paid"].Value.ToString());
                    String first = dgvRoom.Rows[i].Cells["checkin"].Value.ToString();
                    String last = dgvRoom.Rows[i].Cells["checkout"].Value.ToString();
                    if (last == "")
                    {
                        last = DateTime.Now.ToString();
                        sql = "  update RoomBooking set checkout='" + last + "' where idcard='" + txtId.Text + "'";
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
                sql = "select * from foodservices where checked=" + txtId.Text;
                myCommand = new SqlCommand(sql, DatabaseConnect.myConn);
                myDa = new SqlDataAdapter();
                myDa.SelectCommand = myCommand;
                myDT = new DataTable();
                myDa.Fill(myDT);
                //Load Data into datagridview
                dgvFoodBeverage.DataSource = myDT;
                int sc = dgvFoodBeverage.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < sc; i++)
                    thanhtien += float.Parse(dgvFoodBeverage.Rows[i].Cells["value"].Value.ToString());
                lbMoneyFood.Text = "" + thanhtien.ToString("C");


                //Load Data into datagridview

                double total = thanhtienphong + thanhtien;

                // bien an
                tienroom = (int)thanhtienphong;
                tienfood = (int)thanhtien;
                tongtien = tienfood + tienroom + tienservice;

                lbTotal.Text = "" + total.ToString("C");
                //Close
                DatabaseConnect.myConn.Close();
                lbDay.Visible = true;
                lbMoneyFood.Visible = true;
                lbMoneyRoom.Visible = true;
                lbName.Visible = true;
                lbStaff.Visible = true;
                lbTotal.Visible = true;
                dgvFoodBeverage.Visible = true;
                dgvRoom.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
            }
            catch
            {
                lbDay.Visible = false;
                lbMoneyFood.Visible = false;
                lbMoneyRoom.Visible = false;
                lbName.Visible = false;
                lbStaff.Visible = false;
                lbTotal.Visible = false;
                dgvFoodBeverage.Visible = false;
                dgvRoom.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                MessageBox.Show("Invalid Invoice Number");

<<<<<<< HEAD
            }
            if (lbName.Text.Count() > 4)
            {
                lbDiscount.Text = "Discount 10%";
                discount = 0.9;
                double saleprice = tongtien * discount;
                lbTotal.Text= "" + saleprice.ToString("C");
=======
>>>>>>> d6ad624263c68ce9f7ef15d4b378ea928129048a
            }

        }


        private void FormDetailInvoice_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'QLKaraoke_DBDataSet.FoodServices' table. You can move, or remove it, as needed.
            this.foodServicesTableAdapter.Fill(this.qLResortDataSet.FoodServices);
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prnDocument_PrintPage);

        }

        //--------------------------------------------------------------------------
        // for PrintDialog, PrintPreviewDialog and PrintDocument:
        private System.Drawing.Printing.PrintDocument prnDocument;

        // for Invoice Head:
        private string InvTitle;
        private string InvSubTitle1;
        private string InvSubTitle2;
        private string InvSubTitle3;

        // for Report:
        private int CurrentY;
        private int CurrentX;
        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;
        private int InvoiceWidth;
        private int InvoiceHeight;

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
            InvTitle = "Karaoke Sinh Vien";
            InvSubTitle1 = "23 Nguyen Huu Tho ";
            InvSubTitle2 = "Q7, TP HCM";
            InvSubTitle3 = "Phone 0773606106";

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
            FieldValue = "Staff Name: " + lbStaff.Text;
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
            FieldValue = "Order ID: " + txtId.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
                prnDocument.Print();
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.ToString());
            //}

        }
    }
}

