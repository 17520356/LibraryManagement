namespace LibraryManagement
{
    partial class Form_ChiTietDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietDauSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_tacgia = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView_tacgia = new System.Windows.Forms.ListView();
            this.columnHeader_matacgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_tentacgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_xoatg = new System.Windows.Forms.Button();
            this.button_themtg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_trigia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_namxuatban = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ngonngu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_nhaxuatban = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_theloai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tendausach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_cts_thoat = new System.Windows.Forms.Button();
            this.button_cts_xoa = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.label_madausach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox_tacgia);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button_xoatg);
            this.panel1.Controls.Add(this.button_themtg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(519, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 576);
            this.panel1.TabIndex = 35;
            // 
            // comboBox_tacgia
            // 
            this.comboBox_tacgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tacgia.Enabled = false;
            this.comboBox_tacgia.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tacgia.FormattingEnabled = true;
            this.comboBox_tacgia.Location = new System.Drawing.Point(130, 20);
            this.comboBox_tacgia.Name = "comboBox_tacgia";
            this.comboBox_tacgia.Size = new System.Drawing.Size(294, 45);
            this.comboBox_tacgia.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView_tacgia);
            this.panel3.Location = new System.Drawing.Point(5, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 420);
            this.panel3.TabIndex = 11;
            // 
            // listView_tacgia
            // 
            this.listView_tacgia.CheckBoxes = true;
            this.listView_tacgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_matacgia,
            this.columnHeader_tentacgia});
            this.listView_tacgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_tacgia.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_tacgia.Location = new System.Drawing.Point(0, 0);
            this.listView_tacgia.Name = "listView_tacgia";
            this.listView_tacgia.Size = new System.Drawing.Size(444, 420);
            this.listView_tacgia.TabIndex = 0;
            this.listView_tacgia.UseCompatibleStateImageBehavior = false;
            this.listView_tacgia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_matacgia
            // 
            this.columnHeader_matacgia.Text = "Mã Tác Giả";
            this.columnHeader_matacgia.Width = 180;
            // 
            // columnHeader_tentacgia
            // 
            this.columnHeader_tentacgia.Text = "Tên Tác Giả";
            this.columnHeader_tentacgia.Width = 270;
            // 
            // button_xoatg
            // 
            this.button_xoatg.BackColor = System.Drawing.Color.Orange;
            this.button_xoatg.Enabled = false;
            this.button_xoatg.Location = new System.Drawing.Point(249, 95);
            this.button_xoatg.Name = "button_xoatg";
            this.button_xoatg.Size = new System.Drawing.Size(143, 48);
            this.button_xoatg.TabIndex = 10;
            this.button_xoatg.Text = "Xóa";
            this.button_xoatg.UseVisualStyleBackColor = false;
            this.button_xoatg.Click += new System.EventHandler(this.button_xoatg_Click);
            // 
            // button_themtg
            // 
            this.button_themtg.BackColor = System.Drawing.Color.LimeGreen;
            this.button_themtg.Enabled = false;
            this.button_themtg.Location = new System.Drawing.Point(70, 95);
            this.button_themtg.Name = "button_themtg";
            this.button_themtg.Size = new System.Drawing.Size(143, 48);
            this.button_themtg.TabIndex = 9;
            this.button_themtg.Text = "Thêm";
            this.button_themtg.UseVisualStyleBackColor = false;
            this.button_themtg.Click += new System.EventHandler(this.button_themtg_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 88);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tác Giả:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_trigia
            // 
            this.txt_trigia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_trigia.Location = new System.Drawing.Point(212, 584);
            this.txt_trigia.Name = "txt_trigia";
            this.txt_trigia.ReadOnly = true;
            this.txt_trigia.Size = new System.Drawing.Size(294, 45);
            this.txt_trigia.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(504, 88);
            this.label6.TabIndex = 33;
            this.label6.Text = "Trị Giá:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_namxuatban
            // 
            this.dateTimePicker_namxuatban.Enabled = false;
            this.dateTimePicker_namxuatban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_namxuatban.Location = new System.Drawing.Point(212, 484);
            this.dateTimePicker_namxuatban.Name = "dateTimePicker_namxuatban";
            this.dateTimePicker_namxuatban.Size = new System.Drawing.Size(294, 45);
            this.dateTimePicker_namxuatban.TabIndex = 32;
            this.dateTimePicker_namxuatban.ValueChanged += new System.EventHandler(this.dateTimePicker_namxuatban_ValueChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(504, 88);
            this.label5.TabIndex = 31;
            this.label5.Text = "Năm Xuất Bản:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ngonngu
            // 
            this.cmb_ngonngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ngonngu.Enabled = false;
            this.cmb_ngonngu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ngonngu.FormattingEnabled = true;
            this.cmb_ngonngu.Location = new System.Drawing.Point(212, 386);
            this.cmb_ngonngu.Name = "cmb_ngonngu";
            this.cmb_ngonngu.Size = new System.Drawing.Size(294, 45);
            this.cmb_ngonngu.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 88);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngôn Ngữ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_nhaxuatban
            // 
            this.cmb_nhaxuatban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nhaxuatban.Enabled = false;
            this.cmb_nhaxuatban.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nhaxuatban.FormattingEnabled = true;
            this.cmb_nhaxuatban.Location = new System.Drawing.Point(212, 289);
            this.cmb_nhaxuatban.Name = "cmb_nhaxuatban";
            this.cmb_nhaxuatban.Size = new System.Drawing.Size(294, 45);
            this.cmb_nhaxuatban.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 88);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nhà Xuất Bản:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_theloai
            // 
            this.cmb_theloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_theloai.Enabled = false;
            this.cmb_theloai.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_theloai.FormattingEnabled = true;
            this.cmb_theloai.Location = new System.Drawing.Point(212, 183);
            this.cmb_theloai.Name = "cmb_theloai";
            this.cmb_theloai.Size = new System.Drawing.Size(294, 45);
            this.cmb_theloai.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(504, 88);
            this.label9.TabIndex = 23;
            this.label9.Text = "Thể Loại:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tendausach
            // 
            this.txt_tendausach.Location = new System.Drawing.Point(212, 95);
            this.txt_tendausach.Name = "txt_tendausach";
            this.txt_tendausach.ReadOnly = true;
            this.txt_tendausach.Size = new System.Drawing.Size(294, 45);
            this.txt_tendausach.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 88);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên Đầu Sách: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(4, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 66);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 48);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mã Đầu Sách: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(189, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đầu Sách ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_cts_thoat);
            this.panel4.Controls.Add(this.button_cts_xoa);
            this.panel4.Controls.Add(this.button_luu);
            this.panel4.Controls.Add(this.button_chinhsua);
            this.panel4.Location = new System.Drawing.Point(9, 655);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 94);
            this.panel4.TabIndex = 36;
            // 
            // button_cts_thoat
            // 
            this.button_cts_thoat.BackColor = System.Drawing.Color.LimeGreen;
            this.button_cts_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cts_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cts_thoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cts_thoat.Location = new System.Drawing.Point(766, 12);
            this.button_cts_thoat.Name = "button_cts_thoat";
            this.button_cts_thoat.Size = new System.Drawing.Size(168, 67);
            this.button_cts_thoat.TabIndex = 14;
            this.button_cts_thoat.Text = "Thoát";
            this.button_cts_thoat.UseVisualStyleBackColor = false;
            this.button_cts_thoat.Click += new System.EventHandler(this.button_cts_thoat_Click);
            // 
            // button_cts_xoa
            // 
            this.button_cts_xoa.BackColor = System.Drawing.Color.Orange;
            this.button_cts_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cts_xoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cts_xoa.Location = new System.Drawing.Point(539, 12);
            this.button_cts_xoa.Name = "button_cts_xoa";
            this.button_cts_xoa.Size = new System.Drawing.Size(168, 67);
            this.button_cts_xoa.TabIndex = 13;
            this.button_cts_xoa.Text = "Xóa";
            this.button_cts_xoa.UseVisualStyleBackColor = false;
            this.button_cts_xoa.Click += new System.EventHandler(this.button_cts_xoa_Click);
            // 
            // button_luu
            // 
            this.button_luu.BackColor = System.Drawing.Color.LimeGreen;
            this.button_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_luu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(287, 12);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(168, 67);
            this.button_luu.TabIndex = 12;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.BackColor = System.Drawing.Color.LimeGreen;
            this.button_chinhsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_chinhsua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhsua.Location = new System.Drawing.Point(27, 12);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(168, 67);
            this.button_chinhsua.TabIndex = 11;
            this.button_chinhsua.Text = "Chỉnh Sửa";
            this.button_chinhsua.UseVisualStyleBackColor = false;
            this.button_chinhsua.Click += new System.EventHandler(this.button_chinhsua_Click);
            // 
            // label_madausach
            // 
            this.label_madausach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_madausach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_madausach.Location = new System.Drawing.Point(769, 11);
            this.label_madausach.Name = "label_madausach";
            this.label_madausach.Size = new System.Drawing.Size(127, 48);
            this.label_madausach.TabIndex = 23;
            this.label_madausach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_ChiTietDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(981, 757);
            this.Controls.Add(this.label_madausach);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_trigia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_namxuatban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_ngonngu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_nhaxuatban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_theloai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tendausach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form_ChiTietDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đầu Sách";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_tacgia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView_tacgia;
        private System.Windows.Forms.ColumnHeader columnHeader_matacgia;
        private System.Windows.Forms.ColumnHeader columnHeader_tentacgia;
        private System.Windows.Forms.Button button_xoatg;
        private System.Windows.Forms.Button button_themtg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_trigia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_namxuatban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ngonngu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_nhaxuatban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_theloai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tendausach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_cts_thoat;
        private System.Windows.Forms.Button button_cts_xoa;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.Label label_madausach;
    }
}