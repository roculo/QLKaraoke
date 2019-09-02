namespace QLKaraoke
{
    partial class CheckOutForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMoneyRoom = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResortDataSet = new QLKaraoke.QLKaraoke_DBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMoneyFood = new System.Windows.Forms.Label();
            this.dgvFoodBeverage = new System.Windows.Forms.DataGridView();
            this.foodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asda = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.roomTableAdapter = new QLKaraoke.QLKaraoke_DBDataSetTableAdapters.RoomTableAdapter();
            this.foodServicesTableAdapter = new QLKaraoke.QLKaraoke_DBDataSetTableAdapters.FoodServicesTableAdapter();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dtpNow = new System.Windows.Forms.DateTimePicker();
            this.lbstaff = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbInvoice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodServicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbMoneyRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room :";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(3, 22);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Size = new System.Drawing.Size(888, 176);
            this.dgvRoom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cash:";
            // 
            // lbMoneyRoom
            // 
            this.lbMoneyRoom.AutoSize = true;
            this.lbMoneyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyRoom.Location = new System.Drawing.Point(627, 201);
            this.lbMoneyRoom.Name = "lbMoneyRoom";
            this.lbMoneyRoom.Size = new System.Drawing.Size(51, 20);
            this.lbMoneyRoom.TabIndex = 4;
            this.lbMoneyRoom.Text = "label1";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.qLResortDataSet;
            // 
            // qLResortDataSet
            // 
            this.qLResortDataSet.DataSetName = "QLResortDataSet";
            this.qLResortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbMoneyFood);
            this.groupBox2.Controls.Add(this.dgvFoodBeverage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 256);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Food And Beverage :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cash:";
            // 
            // lbMoneyFood
            // 
            this.lbMoneyFood.AutoSize = true;
            this.lbMoneyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyFood.Location = new System.Drawing.Point(329, 224);
            this.lbMoneyFood.Name = "lbMoneyFood";
            this.lbMoneyFood.Size = new System.Drawing.Size(51, 20);
            this.lbMoneyFood.TabIndex = 4;
            this.lbMoneyFood.Text = "label1";
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
            this.value});
            this.dgvFoodBeverage.DataSource = this.foodServicesBindingSource;
            this.dgvFoodBeverage.Location = new System.Drawing.Point(6, 25);
            this.dgvFoodBeverage.Name = "dgvFoodBeverage";
            this.dgvFoodBeverage.ReadOnly = true;
            this.dgvFoodBeverage.Size = new System.Drawing.Size(882, 184);
            this.dgvFoodBeverage.TabIndex = 1;
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
            this.moneyperDataGridViewTextBoxColumn.HeaderText = "Money per each";
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
            // foodServicesBindingSource
            // 
            this.foodServicesBindingSource.DataMember = "FoodServices";
            this.foodServicesBindingSource.DataSource = this.qLResortDataSet;
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asda.Location = new System.Drawing.Point(112, 594);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(94, 33);
            this.asda.TabIndex = 4;
            this.asda.Text = "Total:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(677, 587);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(232, 59);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(227, 26);
            this.txtId.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(257, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(56, 44);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(432, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(188, 31);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Bui Hai Duong";
            this.lbName.Visible = false;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // foodServicesTableAdapter
            // 
            this.foodServicesTableAdapter.ClearBeforeFill = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(239, 594);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(86, 31);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "label1";
            // 
            // dtpNow
            // 
            this.dtpNow.Enabled = false;
            this.dtpNow.Location = new System.Drawing.Point(451, 626);
            this.dtpNow.Name = "dtpNow";
            this.dtpNow.Size = new System.Drawing.Size(200, 20);
            this.dtpNow.TabIndex = 5;
            // 
            // lbstaff
            // 
            this.lbstaff.AutoSize = true;
            this.lbstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstaff.Location = new System.Drawing.Point(614, 60);
            this.lbstaff.Name = "lbstaff";
            this.lbstaff.Size = new System.Drawing.Size(51, 20);
            this.lbstaff.TabIndex = 6;
            this.lbstaff.Text = "label2";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(458, 587);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(193, 33);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.Location = new System.Drawing.Point(789, 12);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(35, 13);
            this.lbInvoice.TabIndex = 9;
            this.lbInvoice.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "N0_0",
            "N0_1",
            "N2_0",
            "N2_1",
            "N4_0",
            "N4_1",
            "N8_0",
            "N8_1",
            "V0_0",
            "V0_1",
            "V2_0",
            "V2_1",
            "V4_0",
            "V4_1",
            "V8_0",
            "V8_1"});
            this.comboBox1.Location = new System.Drawing.Point(319, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 649);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbInvoice);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lbstaff);
            this.Controls.Add(this.dtpNow);
            this.Controls.Add(this.asda);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodServicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFoodBeverage;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbName;
        private QLKaraoke_DBDataSet qLResortDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource foodServicesBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.FoodServicesTableAdapter foodServicesTableAdapter;
        private System.Windows.Forms.Label lbMoneyFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Label lbMoneyRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DateTimePicker dtpNow;
        private System.Windows.Forms.Label lbstaff;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Label lbInvoice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}