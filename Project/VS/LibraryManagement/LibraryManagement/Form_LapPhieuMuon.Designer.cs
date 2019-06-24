namespace LibraryManagement
{
    partial class Form_LapPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LapPhieuMuon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_tensach = new System.Windows.Forms.ComboBox();
            this.cmb_masach = new System.Windows.Forms.ComboBox();
            this.bt_xoasach = new System.Windows.Forms.Button();
            this.bt_themsach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmb_hoten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_lpm_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.cmb_lpm_madg = new System.Windows.Forms.ComboBox();
            this.label_ctpm_ngaymuon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_lpm_thoat = new System.Windows.Forms.Button();
            this.button_lpm_lapphieumuon = new System.Windows.Forms.Button();
            this.panel_lpm = new System.Windows.Forms.Panel();
            this.listView_sach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_lpm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel_lpm);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 782);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmb_tensach);
            this.panel1.Controls.Add(this.cmb_masach);
            this.panel1.Controls.Add(this.bt_xoasach);
            this.panel1.Controls.Add(this.bt_themsach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 107);
            this.panel1.TabIndex = 9;
            // 
            // cmb_tensach
            // 
            this.cmb_tensach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_tensach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tensach.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tensach.FormattingEnabled = true;
            this.cmb_tensach.Location = new System.Drawing.Point(234, 56);
            this.cmb_tensach.Name = "cmb_tensach";
            this.cmb_tensach.Size = new System.Drawing.Size(364, 45);
            this.cmb_tensach.TabIndex = 10;
            // 
            // cmb_masach
            // 
            this.cmb_masach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_masach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_masach.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_masach.FormattingEnabled = true;
            this.cmb_masach.Location = new System.Drawing.Point(234, 5);
            this.cmb_masach.Name = "cmb_masach";
            this.cmb_masach.Size = new System.Drawing.Size(364, 45);
            this.cmb_masach.TabIndex = 9;
            // 
            // bt_xoasach
            // 
            this.bt_xoasach.BackColor = System.Drawing.Color.Orange;
            this.bt_xoasach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoasach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoasach.Location = new System.Drawing.Point(862, 5);
            this.bt_xoasach.Name = "bt_xoasach";
            this.bt_xoasach.Size = new System.Drawing.Size(159, 97);
            this.bt_xoasach.TabIndex = 7;
            this.bt_xoasach.Text = "Xóa";
            this.bt_xoasach.UseVisualStyleBackColor = false;
            this.bt_xoasach.Click += new System.EventHandler(this.bt_xoasach_Click);
            // 
            // bt_themsach
            // 
            this.bt_themsach.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_themsach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_themsach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themsach.Location = new System.Drawing.Point(622, 5);
            this.bt_themsach.Name = "bt_themsach";
            this.bt_themsach.Size = new System.Drawing.Size(159, 97);
            this.bt_themsach.TabIndex = 6;
            this.bt_themsach.Text = "Thêm";
            this.bt_themsach.UseVisualStyleBackColor = false;
            this.bt_themsach.Click += new System.EventHandler(this.bt_themsach_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Sách:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Sách:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.cmb_hoten);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.dateTimePicker_lpm_ngaymuon);
            this.panel8.Controls.Add(this.cmb_lpm_madg);
            this.panel8.Controls.Add(this.label_ctpm_ngaymuon);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1044, 115);
            this.panel8.TabIndex = 7;
            // 
            // cmb_hoten
            // 
            this.cmb_hoten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_hoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hoten.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_hoten.FormattingEnabled = true;
            this.cmb_hoten.Location = new System.Drawing.Point(234, 58);
            this.cmb_hoten.Name = "cmb_hoten";
            this.cmb_hoten.Size = new System.Drawing.Size(364, 45);
            this.cmb_hoten.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ Tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_lpm_ngaymuon
            // 
            this.dateTimePicker_lpm_ngaymuon.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker_lpm_ngaymuon.Enabled = false;
            this.dateTimePicker_lpm_ngaymuon.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_lpm_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_lpm_ngaymuon.Location = new System.Drawing.Point(810, 28);
            this.dateTimePicker_lpm_ngaymuon.Name = "dateTimePicker_lpm_ngaymuon";
            this.dateTimePicker_lpm_ngaymuon.Size = new System.Drawing.Size(211, 45);
            this.dateTimePicker_lpm_ngaymuon.TabIndex = 3;
            // 
            // cmb_lpm_madg
            // 
            this.cmb_lpm_madg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_lpm_madg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lpm_madg.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_lpm_madg.FormattingEnabled = true;
            this.cmb_lpm_madg.Location = new System.Drawing.Point(234, 3);
            this.cmb_lpm_madg.Name = "cmb_lpm_madg";
            this.cmb_lpm_madg.Size = new System.Drawing.Size(364, 45);
            this.cmb_lpm_madg.TabIndex = 1;
            this.cmb_lpm_madg.SelectedIndexChanged += new System.EventHandler(this.cmb_lpm_madg_SelectedIndexChanged);
            // 
            // label_ctpm_ngaymuon
            // 
            this.label_ctpm_ngaymuon.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ctpm_ngaymuon.Location = new System.Drawing.Point(615, 4);
            this.label_ctpm_ngaymuon.Name = "label_ctpm_ngaymuon";
            this.label_ctpm_ngaymuon.Size = new System.Drawing.Size(434, 97);
            this.label_ctpm_ngaymuon.TabIndex = 6;
            this.label_ctpm_ngaymuon.Text = "Ngày Mượn:";
            this.label_ctpm_ngaymuon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.button_lpm_thoat);
            this.panel7.Controls.Add(this.button_lpm_lapphieumuon);
            this.panel7.Location = new System.Drawing.Point(3, 690);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1044, 81);
            this.panel7.TabIndex = 1;
            // 
            // button_lpm_thoat
            // 
            this.button_lpm_thoat.BackColor = System.Drawing.Color.Yellow;
            this.button_lpm_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_lpm_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_lpm_thoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lpm_thoat.Location = new System.Drawing.Point(646, 3);
            this.button_lpm_thoat.Name = "button_lpm_thoat";
            this.button_lpm_thoat.Size = new System.Drawing.Size(293, 67);
            this.button_lpm_thoat.TabIndex = 9;
            this.button_lpm_thoat.Text = "Thoát";
            this.button_lpm_thoat.UseVisualStyleBackColor = false;
            this.button_lpm_thoat.Click += new System.EventHandler(this.button_lpm_thoat_Click);
            // 
            // button_lpm_lapphieumuon
            // 
            this.button_lpm_lapphieumuon.BackColor = System.Drawing.Color.LimeGreen;
            this.button_lpm_lapphieumuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_lpm_lapphieumuon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lpm_lapphieumuon.Location = new System.Drawing.Point(148, 3);
            this.button_lpm_lapphieumuon.Name = "button_lpm_lapphieumuon";
            this.button_lpm_lapphieumuon.Size = new System.Drawing.Size(302, 67);
            this.button_lpm_lapphieumuon.TabIndex = 8;
            this.button_lpm_lapphieumuon.Text = "Lập Phiếu Mượn";
            this.button_lpm_lapphieumuon.UseVisualStyleBackColor = false;
            this.button_lpm_lapphieumuon.Click += new System.EventHandler(this.button_lpm_lapphieumuon_Click);
            // 
            // panel_lpm
            // 
            this.panel_lpm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lpm.Controls.Add(this.listView_sach);
            this.panel_lpm.Location = new System.Drawing.Point(3, 237);
            this.panel_lpm.Name = "panel_lpm";
            this.panel_lpm.Size = new System.Drawing.Size(1044, 447);
            this.panel_lpm.TabIndex = 1;
            // 
            // listView_sach
            // 
            this.listView_sach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView_sach.CheckBoxes = true;
            this.listView_sach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_sach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_sach.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_sach.Location = new System.Drawing.Point(0, 0);
            this.listView_sach.Name = "listView_sach";
            this.listView_sach.Size = new System.Drawing.Size(1040, 443);
            this.listView_sach.TabIndex = 0;
            this.listView_sach.UseCompatibleStateImageBehavior = false;
            this.listView_sach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sách";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sách";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 367;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể Loại";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác Giả";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 333;
            // 
            // Form_LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.button_lpm_thoat;
            this.ClientSize = new System.Drawing.Size(1066, 789);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_LapPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Mượn";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_lpm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_lpm_thoat;
        private System.Windows.Forms.Panel panel_lpm;
        private System.Windows.Forms.ComboBox cmb_lpm_madg;
        private System.Windows.Forms.Label label_ctpm_ngaymuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_xoasach;
        private System.Windows.Forms.Button bt_themsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lpm_ngaymuon;
        private System.Windows.Forms.Button button_lpm_lapphieumuon;
        private System.Windows.Forms.ListView listView_sach;
        private System.Windows.Forms.ComboBox cmb_tensach;
        private System.Windows.Forms.ComboBox cmb_masach;
        private System.Windows.Forms.ComboBox cmb_hoten;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}