﻿namespace LibraryManagement
{
    partial class Form_ChiTietPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietPhieuMuon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_giahan = new System.Windows.Forms.Button();
            this.cmb_tensach = new System.Windows.Forms.ComboBox();
            this.cmb_masach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmb_hoten = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_lpm_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.cmb_madg = new System.Windows.Forms.ComboBox();
            this.label_ctpm_ngaymuon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_lpm = new System.Windows.Forms.Panel();
            this.listView_sach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_ctpm_huy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel_lpm.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel_lpm);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 790);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_giahan);
            this.panel2.Controls.Add(this.cmb_tensach);
            this.panel2.Controls.Add(this.cmb_masach);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 107);
            this.panel2.TabIndex = 13;
            // 
            // button_giahan
            // 
            this.button_giahan.BackColor = System.Drawing.Color.LimeGreen;
            this.button_giahan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_giahan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_giahan.Location = new System.Drawing.Point(666, 5);
            this.button_giahan.Name = "button_giahan";
            this.button_giahan.Size = new System.Drawing.Size(346, 97);
            this.button_giahan.TabIndex = 11;
            this.button_giahan.Text = "Gia Hạn";
            this.button_giahan.UseVisualStyleBackColor = false;
            this.button_giahan.Click += new System.EventHandler(this.button_giahan_Click);
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
            this.panel8.Controls.Add(this.cmb_madg);
            this.panel8.Controls.Add(this.label_ctpm_ngaymuon);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1044, 115);
            this.panel8.TabIndex = 12;
            // 
            // cmb_hoten
            // 
            this.cmb_hoten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_hoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hoten.Enabled = false;
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
            // cmb_madg
            // 
            this.cmb_madg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_madg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_madg.Enabled = false;
            this.cmb_madg.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_madg.FormattingEnabled = true;
            this.cmb_madg.Location = new System.Drawing.Point(234, 3);
            this.cmb_madg.Name = "cmb_madg";
            this.cmb_madg.Size = new System.Drawing.Size(364, 45);
            this.cmb_madg.TabIndex = 1;
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
            // panel_lpm
            // 
            this.panel_lpm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lpm.Controls.Add(this.listView_sach);
            this.panel_lpm.Location = new System.Drawing.Point(3, 237);
            this.panel_lpm.Name = "panel_lpm";
            this.panel_lpm.Size = new System.Drawing.Size(1044, 447);
            this.panel_lpm.TabIndex = 11;
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
            this.columnHeader2.Width = 370;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Hết Hạn";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 216;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tình Trạng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 294;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_ctpm_huy);
            this.panel4.Location = new System.Drawing.Point(3, 688);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 94);
            this.panel4.TabIndex = 2;
            // 
            // button_ctpm_huy
            // 
            this.button_ctpm_huy.BackColor = System.Drawing.Color.LimeGreen;
            this.button_ctpm_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ctpm_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ctpm_huy.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ctpm_huy.Location = new System.Drawing.Point(328, 14);
            this.button_ctpm_huy.Name = "button_ctpm_huy";
            this.button_ctpm_huy.Size = new System.Drawing.Size(337, 67);
            this.button_ctpm_huy.TabIndex = 11;
            this.button_ctpm_huy.Text = "Thoát";
            this.button_ctpm_huy.UseVisualStyleBackColor = false;
            this.button_ctpm_huy.Click += new System.EventHandler(this.button_ctpm_huy_Click);
            // 
            // Form_ChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.button_ctpm_huy;
            this.ClientSize = new System.Drawing.Size(1060, 795);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ChiTietPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Mượn";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel_lpm.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_ctpm_huy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_giahan;
        private System.Windows.Forms.ComboBox cmb_tensach;
        private System.Windows.Forms.ComboBox cmb_masach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmb_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lpm_ngaymuon;
        private System.Windows.Forms.ComboBox cmb_madg;
        private System.Windows.Forms.Label label_ctpm_ngaymuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_lpm;
        private System.Windows.Forms.ListView listView_sach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}