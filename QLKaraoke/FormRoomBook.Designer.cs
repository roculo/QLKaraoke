namespace QLKaraoke
{
    partial class FormRoomBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomBook));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnNormal = new System.Windows.Forms.RadioButton();
            this.rbnVip = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnPeople8 = new System.Windows.Forms.RadioButton();
            this.rbnPeople2 = new System.Windows.Forms.RadioButton();
            this.rbnPeople4 = new System.Windows.Forms.RadioButton();
            this.rbnPeople1 = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeposite = new System.Windows.Forms.NumericUpDown();
            this.btnRoomCheck = new System.Windows.Forms.Button();
            this.rbnNewGuest = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Card :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(270, 20);
            this.txtId.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheck.Location = new System.Drawing.Point(419, 81);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(58, 34);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(35, 324);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(265, 36);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book Now";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnNormal);
            this.groupBox1.Controls.Add(this.rbnVip);
            this.groupBox1.Location = new System.Drawing.Point(16, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 61);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type :";
            // 
            // rbnNormal
            // 
            this.rbnNormal.AutoSize = true;
            this.rbnNormal.Location = new System.Drawing.Point(6, 19);
            this.rbnNormal.Name = "rbnNormal";
            this.rbnNormal.Size = new System.Drawing.Size(58, 17);
            this.rbnNormal.TabIndex = 7;
            this.rbnNormal.TabStop = true;
            this.rbnNormal.Text = "Normal";
            this.rbnNormal.UseVisualStyleBackColor = true;
            // 
            // rbnVip
            // 
            this.rbnVip.AutoSize = true;
            this.rbnVip.Location = new System.Drawing.Point(99, 19);
            this.rbnVip.Name = "rbnVip";
            this.rbnVip.Size = new System.Drawing.Size(40, 17);
            this.rbnVip.TabIndex = 7;
            this.rbnVip.TabStop = true;
            this.rbnVip.Text = "Vip";
            this.rbnVip.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnPeople8);
            this.groupBox2.Controls.Add(this.rbnPeople2);
            this.groupBox2.Controls.Add(this.rbnPeople4);
            this.groupBox2.Controls.Add(this.rbnPeople1);
            this.groupBox2.Location = new System.Drawing.Point(226, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People :";
            // 
            // rbnPeople8
            // 
            this.rbnPeople8.AutoSize = true;
            this.rbnPeople8.Location = new System.Drawing.Point(55, 42);
            this.rbnPeople8.Name = "rbnPeople8";
            this.rbnPeople8.Size = new System.Drawing.Size(37, 17);
            this.rbnPeople8.TabIndex = 7;
            this.rbnPeople8.TabStop = true;
            this.rbnPeople8.Text = "20";
            this.rbnPeople8.UseVisualStyleBackColor = true;
            this.rbnPeople8.CheckedChanged += new System.EventHandler(this.rbnPeople8_CheckedChanged);
            // 
            // rbnPeople2
            // 
            this.rbnPeople2.AutoSize = true;
            this.rbnPeople2.Location = new System.Drawing.Point(55, 19);
            this.rbnPeople2.Name = "rbnPeople2";
            this.rbnPeople2.Size = new System.Drawing.Size(31, 17);
            this.rbnPeople2.TabIndex = 7;
            this.rbnPeople2.TabStop = true;
            this.rbnPeople2.Text = "8";
            this.rbnPeople2.UseVisualStyleBackColor = true;
            this.rbnPeople2.CheckedChanged += new System.EventHandler(this.rbnPeople2_CheckedChanged);
            // 
            // rbnPeople4
            // 
            this.rbnPeople4.AutoSize = true;
            this.rbnPeople4.Location = new System.Drawing.Point(6, 42);
            this.rbnPeople4.Name = "rbnPeople4";
            this.rbnPeople4.Size = new System.Drawing.Size(37, 17);
            this.rbnPeople4.TabIndex = 7;
            this.rbnPeople4.TabStop = true;
            this.rbnPeople4.Text = "15";
            this.rbnPeople4.UseVisualStyleBackColor = true;
            this.rbnPeople4.CheckedChanged += new System.EventHandler(this.rbnPeople4_CheckedChanged);
            // 
            // rbnPeople1
            // 
            this.rbnPeople1.AutoSize = true;
            this.rbnPeople1.Location = new System.Drawing.Point(6, 19);
            this.rbnPeople1.Name = "rbnPeople1";
            this.rbnPeople1.Size = new System.Drawing.Size(31, 17);
            this.rbnPeople1.TabIndex = 7;
            this.rbnPeople1.TabStop = true;
            this.rbnPeople1.Text = "4";
            this.rbnPeople1.UseVisualStyleBackColor = true;
            this.rbnPeople1.CheckedChanged += new System.EventHandler(this.rbnPeople1_CheckedChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "hh:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(12, 282);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(298, 282);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "End :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deposite :";
            // 
            // numDeposite
            // 
            this.numDeposite.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDeposite.Location = new System.Drawing.Point(378, 203);
            this.numDeposite.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDeposite.Name = "numDeposite";
            this.numDeposite.Size = new System.Drawing.Size(120, 20);
            this.numDeposite.TabIndex = 12;
            // 
            // btnRoomCheck
            // 
            this.btnRoomCheck.Location = new System.Drawing.Point(396, 326);
            this.btnRoomCheck.Name = "btnRoomCheck";
            this.btnRoomCheck.Size = new System.Drawing.Size(102, 36);
            this.btnRoomCheck.TabIndex = 13;
            this.btnRoomCheck.Text = "Room Checking";
            this.btnRoomCheck.UseVisualStyleBackColor = true;
            // 
            // rbnNewGuest
            // 
            this.rbnNewGuest.AutoSize = true;
            this.rbnNewGuest.Location = new System.Drawing.Point(111, 121);
            this.rbnNewGuest.Name = "rbnNewGuest";
            this.rbnNewGuest.Size = new System.Drawing.Size(53, 17);
            this.rbnNewGuest.TabIndex = 14;
            this.rbnNewGuest.TabStop = true;
            this.rbnNewGuest.Text = "Guest";
            this.rbnNewGuest.UseVisualStyleBackColor = true;
            this.rbnNewGuest.CheckedChanged += new System.EventHandler(this.rbnNewGuest_CheckedChanged);
            // 
            // FormRoomBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 372);
            this.Controls.Add(this.rbnNewGuest);
            this.Controls.Add(this.btnRoomCheck);
            this.Controls.Add(this.numDeposite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRoomBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoomBook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnNormal;
        private System.Windows.Forms.RadioButton rbnVip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnPeople8;
        private System.Windows.Forms.RadioButton rbnPeople2;
        private System.Windows.Forms.RadioButton rbnPeople4;
        private System.Windows.Forms.RadioButton rbnPeople1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDeposite;
        private System.Windows.Forms.Button btnRoomCheck;
        private System.Windows.Forms.RadioButton rbnNewGuest;
    }
}