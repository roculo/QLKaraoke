namespace QLKaraoke
{
    partial class FormRoomBooking
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
            this.dgvRB = new System.Windows.Forms.DataGridView();
            this.orderroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResortDataSet = new QLKaraoke_DBDataSet();
            this.roomBookingTableAdapter = new QLKaraoke_DBDataSetTableAdapters.roombookingTableAdapter();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRB
            // 
            this.dgvRB.AllowUserToAddRows = false;
            this.dgvRB.AllowUserToDeleteRows = false;
            this.dgvRB.AutoGenerateColumns = false;
            this.dgvRB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderroomDataGridViewTextBoxColumn,
            this.idroomDataGridViewTextBoxColumn,
            this.idcardDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.dgvRB.DataSource = this.roomBookingBindingSource;
            this.dgvRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRB.Location = new System.Drawing.Point(0, 0);
            this.dgvRB.Name = "dgvRB";
            this.dgvRB.ReadOnly = true;
            this.dgvRB.Size = new System.Drawing.Size(796, 424);
            this.dgvRB.TabIndex = 0;
            this.dgvRB.SelectionChanged += new System.EventHandler(this.dgvRB_SelectionChanged);
            // 
            // orderroomDataGridViewTextBoxColumn
            // 
            this.orderroomDataGridViewTextBoxColumn.DataPropertyName = "orderroom";
            this.orderroomDataGridViewTextBoxColumn.HeaderText = "orderroom";
            this.orderroomDataGridViewTextBoxColumn.Name = "orderroomDataGridViewTextBoxColumn";
            this.orderroomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idroomDataGridViewTextBoxColumn
            // 
            this.idroomDataGridViewTextBoxColumn.DataPropertyName = "idroom";
            this.idroomDataGridViewTextBoxColumn.HeaderText = "idroom";
            this.idroomDataGridViewTextBoxColumn.Name = "idroomDataGridViewTextBoxColumn";
            this.idroomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcardDataGridViewTextBoxColumn
            // 
            this.idcardDataGridViewTextBoxColumn.DataPropertyName = "idcard";
            this.idcardDataGridViewTextBoxColumn.HeaderText = "idcard";
            this.idcardDataGridViewTextBoxColumn.Name = "idcardDataGridViewTextBoxColumn";
            this.idcardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "checkin";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            this.checkinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "checkout";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            this.checkoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBookingBindingSource
            // 
            this.roomBookingBindingSource.DataMember = "RoomBooking";
            this.roomBookingBindingSource.DataSource = this.qLResortDataSet;
            // 
            // qLResortDataSet
            // 
            this.qLResortDataSet.DataSetName = "QLResortDataSet";
            this.qLResortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBookingTableAdapter
            // 
            this.roomBookingTableAdapter.ClearBeforeFill = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(679, 389);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 35);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 424);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvRB);
            this.Name = "RoomBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomBooking";
            this.Load += new System.EventHandler(this.RoomBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResortDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRB;
        private QLKaraoke_DBDataSet qLResortDataSet;
        private System.Windows.Forms.BindingSource roomBookingBindingSource;
        private QLKaraoke_DBDataSetTableAdapters.roombookingTableAdapter roomBookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;
    }
}