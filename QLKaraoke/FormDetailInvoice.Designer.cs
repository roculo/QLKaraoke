namespace QLKaraoke
{
    partial class FormDetailInvoice
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.dgvFoodBeverage = new System.Windows.Forms.DataGridView();
            this.foodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResortDataSet = new QLKaraoke.QLKaraoke_DBDataSet();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.lbMoneyRoom = new System.Windows.Forms.Label();
            this.lbMoneyFood = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.foodServicesTableAdapter = new QLKaraoke.QLKaraoke_DBDataSetTableAdapters.FoodServicesTableAdapter();
            this.lbDay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(274, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Id :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFind);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(12, 70);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Size = new System.Drawing.Size(766, 182);
            this.dgvRoom.TabIndex = 3;
            this.dgvRoom.Visible = false;
            // 
            // dgvFoodBeverage
            // 
            this.dgvFoodBeverage.AllowUserToAddRows = false;
            this.dgvFoodBeverage.AllowUserToDeleteRows = false;
            this.dgvFoodBeverage.AutoGenerateColumns = false;
            this.dgvFoodBeverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodBeverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodBeverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodnameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.moneyperDataGridViewTextBoxColumn,
            this.value,
            this.timecallDataGridViewTextBoxColumn});
            this.dgvFoodBeverage.DataSource = this.foodServicesBindingSource;
            this.dgvFoodBeverage.Location = new System.Drawing.Point(12, 286);
            this.dgvFoodBeverage.Name = "dgvFoodBeverage";
            this.dgvFoodBeverage.ReadOnly = true;
            this.dgvFoodBeverage.Size = new System.Drawing.Size(766, 182);
            this.dgvFoodBeverage.TabIndex = 3;
            this.dgvFoodBeverage.Visible = false;
            // 
            // foodnameDataGridViewTextBoxColumn
            // 
            this.foodnameDataGridViewTextBoxColumn.DataPropertyName = "foodname";
            this.foodnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.foodnameDataGridViewTextBoxColumn.Name = "foodnameDataGridViewTextBoxColumn";
            this.foodnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyperDataGridViewTextBoxColumn
            // 
            this.moneyperDataGridViewTextBoxColumn.DataPropertyName = "moneyper";
            this.moneyperDataGridViewTextBoxColumn.HeaderText = "Cash";
            this.moneyperDataGridViewTextBoxColumn.Name = "moneyperDataGridViewTextBoxColumn";
            this.moneyperDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // value
            // 
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "Total";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // timecallDataGridViewTextBoxColumn
            // 
            this.timecallDataGridViewTextBoxColumn.DataPropertyName = "timecall";
            this.timecallDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timecallDataGridViewTextBoxColumn.Name = "timecallDataGridViewTextBoxColumn";
            this.timecallDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodServicesBindingSource
            // 
            this.foodServicesBindingSource.DataMember = "FoodServices";
            this.foodServicesBindingSource.DataSource = this.qLResortDataSet;
            // 
            // qLResortDataSet
            // 
            this.qLResortDataSet.DataSetName = "QLResortDataSet";
            this.qLResortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(574, 11);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(89, 29);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name ";
            this.lbName.Visible = false;
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(620, 51);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(34, 16);
            this.lbStaff.TabIndex = 1;
            this.lbStaff.Text = "Staff";
            this.lbStaff.Visible = false;
            // 
            // lbMoneyRoom
            // 
            this.lbMoneyRoom.AutoSize = true;
            this.lbMoneyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyRoom.Location = new System.Drawing.Point(603, 255);
            this.lbMoneyRoom.Name = "lbMoneyRoom";
            this.lbMoneyRoom.Size = new System.Drawing.Size(51, 20);
            this.lbMoneyRoom.TabIndex = 4;
            this.lbMoneyRoom.Text = "label2";
            this.lbMoneyRoom.Visible = false;
            // 
            // lbMoneyFood
            // 
            this.lbMoneyFood.AutoSize = true;
            this.lbMoneyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyFood.Location = new System.Drawing.Point(91, 471);
            this.lbMoneyFood.Name = "lbMoneyFood";
            this.lbMoneyFood.Size = new System.Drawing.Size(45, 16);
            this.lbMoneyFood.TabIndex = 4;
            this.lbMoneyFood.Text = "label2";
            this.lbMoneyFood.Visible = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(339, 492);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 20);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "label2";
            this.lbTotal.Visible = false;
            // 
            // foodServicesTableAdapter
            // 
            this.foodServicesTableAdapter.ClearBeforeFill = true;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(9, 492);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(38, 14);
            this.lbDay.TabIndex = 5;
            this.lbDay.Text = "label2";
            this.lbDay.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(663, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Food and Beverage";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room";
            this.label4.Visible = false;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(372, 45);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(122, 24);
            this.lbDiscount.TabIndex = 9;
            this.lbDiscount.Text = "discount 0%";
            // 
            // FormDetailInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 514);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbMoneyFood);
            this.Controls.Add(this.lbMoneyRoom);
            this.Controls.Add(this.dgvFoodBeverage);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbStaff);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "FormDetailInvoice";
            this.Text = "FormDetailInvoice";
            this.Load += new System.EventHandler(this.FormDetailInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridView dgvFoodBeverage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Label lbMoneyRoom;
        private System.Windows.Forms.Label lbMoneyFood;
        private System.Windows.Forms.Label lbTotal;
        private QLKaraoke_DBDataSet qLResortDataSet;
        private System.Windows.Forms.BindingSource foodServicesBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.FoodServicesTableAdapter foodServicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecallDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDiscount;
    }
}