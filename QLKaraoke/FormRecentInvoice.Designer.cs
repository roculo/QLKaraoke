namespace QLKaraoke
{
    partial class FormRecentInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResortDataSet = new QLKaraoke_DBDataSet();
            this.invoiceTableAdapter = new QLKaraoke_DBDataSetTableAdapters.InvoiceTableAdapter();
            this.detailInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailInvoiceTableAdapter = new QLKaraoke_DBDataSetTableAdapters.InvoiceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idinvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodandbeverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.qLResortDataSet;
            // 
            // qLResortDataSet
            // 
            this.qLResortDataSet.DataSetName = "QLResortDataSet";
            this.qLResortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // 
            // detailInvoiceTableAdapter
            // 
            this.detailInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinvoiceDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.foodandbeverageDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.daycreateDataGridViewTextBoxColumn,
            this.staffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(896, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // idinvoiceDataGridViewTextBoxColumn
            // 
            this.idinvoiceDataGridViewTextBoxColumn.DataPropertyName = "idinvoice";
            this.idinvoiceDataGridViewTextBoxColumn.HeaderText = "Invoice";
            this.idinvoiceDataGridViewTextBoxColumn.Name = "idinvoiceDataGridViewTextBoxColumn";
            this.idinvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "member";
            this.memberDataGridViewTextBoxColumn.HeaderText = "Id Member";
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            this.memberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room cost";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodandbeverageDataGridViewTextBoxColumn
            // 
            this.foodandbeverageDataGridViewTextBoxColumn.DataPropertyName = "foodandbeverage";
            this.foodandbeverageDataGridViewTextBoxColumn.HeaderText = "Food and Drink cost";
            this.foodandbeverageDataGridViewTextBoxColumn.Name = "foodandbeverageDataGridViewTextBoxColumn";
            this.foodandbeverageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service cost";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daycreateDataGridViewTextBoxColumn
            // 
            this.daycreateDataGridViewTextBoxColumn.DataPropertyName = "daycreate";
            this.daycreateDataGridViewTextBoxColumn.HeaderText = "Day";
            this.daycreateDataGridViewTextBoxColumn.Name = "daycreateDataGridViewTextBoxColumn";
            this.daycreateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffDataGridViewTextBoxColumn
            // 
            this.staffDataGridViewTextBoxColumn.DataPropertyName = "staff";
            this.staffDataGridViewTextBoxColumn.HeaderText = "Staff Name";
            this.staffDataGridViewTextBoxColumn.Name = "staffDataGridViewTextBoxColumn";
            this.staffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceBindingSource1
            // 
            this.invoiceBindingSource1.DataMember = "Invoice";
            this.invoiceBindingSource1.DataSource = this.qLResortDataSet;
            // 
            // invoiceBindingSource2
            // 
            this.invoiceBindingSource2.DataMember = "Invoice";
            this.invoiceBindingSource2.DataSource = this.qLResortDataSet;
            // 
            // FormRecentInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 501);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRecentInvoice";
            this.Text = "FormRecentInvoice";
            this.Load += new System.EventHandler(this.FormRecentInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLKaraoke_DBDataSet qLResortDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource detailInvoiceBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.InvoiceTableAdapter detailInvoiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoiceBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodandbeverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daycreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invoiceBindingSource2;
    }
}