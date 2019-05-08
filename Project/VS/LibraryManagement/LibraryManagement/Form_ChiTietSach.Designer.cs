namespace LibraryManagement
{
    partial class Form_ChiTietSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_cts_huy = new System.Windows.Forms.Button();
            this.button_cts_xoa = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_chinhsua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_cts_theloai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_cts_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txt_cts_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_cts_trigia = new System.Windows.Forms.TextBox();
            this.txt_cts_nhaxb = new System.Windows.Forms.TextBox();
            this.txt_cts_ngonngu = new System.Windows.Forms.TextBox();
            this.txt_cts_namxb = new System.Windows.Forms.TextBox();
            this.txt_cts_tacgia = new System.Windows.Forms.TextBox();
            this.label_cts_tinhtrang = new System.Windows.Forms.Label();
            this.label_cts_trigia = new System.Windows.Forms.Label();
            this.label_cts_ngaynhap = new System.Windows.Forms.Label();
            this.txt_cts_masach = new System.Windows.Forms.TextBox();
            this.label_cts_nhaxb = new System.Windows.Forms.Label();
            this.label_cts_ngonngu = new System.Windows.Forms.Label();
            this.label_cts_namxb = new System.Windows.Forms.Label();
            this.label_cts_tacgia = new System.Windows.Forms.Label();
            this.label_cts_theloai = new System.Windows.Forms.Label();
            this.label_cts_masach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_cts_thongtinsach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_cts_tensach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 823);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button_cts_huy);
            this.panel4.Controls.Add(this.button_cts_xoa);
            this.panel4.Controls.Add(this.button_luu);
            this.panel4.Controls.Add(this.button_chinhsua);
            this.panel4.Location = new System.Drawing.Point(0, 728);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 94);
            this.panel4.TabIndex = 2;
            // 
            // button_cts_huy
            // 
            this.button_cts_huy.BackColor = System.Drawing.Color.LimeGreen;
            this.button_cts_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cts_huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cts_huy.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cts_huy.Location = new System.Drawing.Point(803, 12);
            this.button_cts_huy.Name = "button_cts_huy";
            this.button_cts_huy.Size = new System.Drawing.Size(232, 67);
            this.button_cts_huy.TabIndex = 14;
            this.button_cts_huy.Text = "Hủy";
            this.button_cts_huy.UseVisualStyleBackColor = false;
            this.button_cts_huy.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_cts_xoa
            // 
            this.button_cts_xoa.BackColor = System.Drawing.Color.LimeGreen;
            this.button_cts_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cts_xoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cts_xoa.Location = new System.Drawing.Point(539, 12);
            this.button_cts_xoa.Name = "button_cts_xoa";
            this.button_cts_xoa.Size = new System.Drawing.Size(232, 67);
            this.button_cts_xoa.TabIndex = 13;
            this.button_cts_xoa.Text = "Xóa";
            this.button_cts_xoa.UseVisualStyleBackColor = false;
            // 
            // button_luu
            // 
            this.button_luu.BackColor = System.Drawing.Color.LimeGreen;
            this.button_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_luu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(282, 12);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(232, 67);
            this.button_luu.TabIndex = 12;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = false;
            // 
            // button_chinhsua
            // 
            this.button_chinhsua.BackColor = System.Drawing.Color.LimeGreen;
            this.button_chinhsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_chinhsua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhsua.Location = new System.Drawing.Point(27, 12);
            this.button_chinhsua.Name = "button_chinhsua";
            this.button_chinhsua.Size = new System.Drawing.Size(232, 67);
            this.button_chinhsua.TabIndex = 11;
            this.button_chinhsua.Text = "Chỉnh Sửa";
            this.button_chinhsua.UseVisualStyleBackColor = false;
            this.button_chinhsua.Click += new System.EventHandler(this.button_chinhsua_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmb_cts_theloai);
            this.panel3.Controls.Add(this.dateTimePicker_cts_ngaynhap);
            this.panel3.Controls.Add(this.txt_cts_tinhtrang);
            this.panel3.Controls.Add(this.txt_cts_trigia);
            this.panel3.Controls.Add(this.txt_cts_nhaxb);
            this.panel3.Controls.Add(this.txt_cts_ngonngu);
            this.panel3.Controls.Add(this.txt_cts_namxb);
            this.panel3.Controls.Add(this.txt_cts_tacgia);
            this.panel3.Controls.Add(this.label_cts_tinhtrang);
            this.panel3.Controls.Add(this.label_cts_trigia);
            this.panel3.Controls.Add(this.label_cts_ngaynhap);
            this.panel3.Controls.Add(this.txt_cts_masach);
            this.panel3.Controls.Add(this.label_cts_nhaxb);
            this.panel3.Controls.Add(this.label_cts_ngonngu);
            this.panel3.Controls.Add(this.label_cts_namxb);
            this.panel3.Controls.Add(this.label_cts_tacgia);
            this.panel3.Controls.Add(this.label_cts_theloai);
            this.panel3.Controls.Add(this.label_cts_masach);
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 595);
            this.panel3.TabIndex = 1;
            // 
            // cmb_cts_theloai
            // 
            this.cmb_cts_theloai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_cts_theloai.Enabled = false;
            this.cmb_cts_theloai.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cts_theloai.FormattingEnabled = true;
            this.cmb_cts_theloai.Items.AddRange(new object[] {
            "asdsads",
            "asdasdsad",
            "asdsadsad"});
            this.cmb_cts_theloai.Location = new System.Drawing.Point(689, 40);
            this.cmb_cts_theloai.Name = "cmb_cts_theloai";
            this.cmb_cts_theloai.Size = new System.Drawing.Size(356, 44);
            this.cmb_cts_theloai.TabIndex = 3;
            this.cmb_cts_theloai.Text = "asdsadsadsa";
            // 
            // dateTimePicker_cts_ngaynhap
            // 
            this.dateTimePicker_cts_ngaynhap.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker_cts_ngaynhap.Enabled = false;
            this.dateTimePicker_cts_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_cts_ngaynhap.Location = new System.Drawing.Point(372, 503);
            this.dateTimePicker_cts_ngaynhap.Name = "dateTimePicker_cts_ngaynhap";
            this.dateTimePicker_cts_ngaynhap.Size = new System.Drawing.Size(471, 44);
            this.dateTimePicker_cts_ngaynhap.TabIndex = 10;
            // 
            // txt_cts_tinhtrang
            // 
            this.txt_cts_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_tinhtrang.Location = new System.Drawing.Point(174, 389);
            this.txt_cts_tinhtrang.Name = "txt_cts_tinhtrang";
            this.txt_cts_tinhtrang.ReadOnly = true;
            this.txt_cts_tinhtrang.Size = new System.Drawing.Size(340, 44);
            this.txt_cts_tinhtrang.TabIndex = 8;
            // 
            // txt_cts_trigia
            // 
            this.txt_cts_trigia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_trigia.Location = new System.Drawing.Point(692, 389);
            this.txt_cts_trigia.Name = "txt_cts_trigia";
            this.txt_cts_trigia.ReadOnly = true;
            this.txt_cts_trigia.Size = new System.Drawing.Size(353, 44);
            this.txt_cts_trigia.TabIndex = 9;
            // 
            // txt_cts_nhaxb
            // 
            this.txt_cts_nhaxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_nhaxb.Location = new System.Drawing.Point(692, 273);
            this.txt_cts_nhaxb.Name = "txt_cts_nhaxb";
            this.txt_cts_nhaxb.ReadOnly = true;
            this.txt_cts_nhaxb.Size = new System.Drawing.Size(353, 44);
            this.txt_cts_nhaxb.TabIndex = 7;
            // 
            // txt_cts_ngonngu
            // 
            this.txt_cts_ngonngu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_ngonngu.Location = new System.Drawing.Point(177, 273);
            this.txt_cts_ngonngu.Name = "txt_cts_ngonngu";
            this.txt_cts_ngonngu.ReadOnly = true;
            this.txt_cts_ngonngu.Size = new System.Drawing.Size(337, 44);
            this.txt_cts_ngonngu.TabIndex = 6;
            // 
            // txt_cts_namxb
            // 
            this.txt_cts_namxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_namxb.Location = new System.Drawing.Point(692, 156);
            this.txt_cts_namxb.Name = "txt_cts_namxb";
            this.txt_cts_namxb.ReadOnly = true;
            this.txt_cts_namxb.Size = new System.Drawing.Size(353, 44);
            this.txt_cts_namxb.TabIndex = 5;
            // 
            // txt_cts_tacgia
            // 
            this.txt_cts_tacgia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_tacgia.Location = new System.Drawing.Point(177, 156);
            this.txt_cts_tacgia.Name = "txt_cts_tacgia";
            this.txt_cts_tacgia.ReadOnly = true;
            this.txt_cts_tacgia.Size = new System.Drawing.Size(337, 44);
            this.txt_cts_tacgia.TabIndex = 4;
            // 
            // label_cts_tinhtrang
            // 
            this.label_cts_tinhtrang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_tinhtrang.Location = new System.Drawing.Point(7, 359);
            this.label_cts_tinhtrang.Name = "label_cts_tinhtrang";
            this.label_cts_tinhtrang.Size = new System.Drawing.Size(518, 103);
            this.label_cts_tinhtrang.TabIndex = 8;
            this.label_cts_tinhtrang.Text = "Tình Trạng:";
            this.label_cts_tinhtrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_trigia
            // 
            this.label_cts_trigia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_trigia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_trigia.Location = new System.Drawing.Point(539, 359);
            this.label_cts_trigia.Name = "label_cts_trigia";
            this.label_cts_trigia.Size = new System.Drawing.Size(518, 103);
            this.label_cts_trigia.TabIndex = 9;
            this.label_cts_trigia.Text = "Trị Giá:";
            this.label_cts_trigia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_ngaynhap
            // 
            this.label_cts_ngaynhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_ngaynhap.Location = new System.Drawing.Point(174, 476);
            this.label_cts_ngaynhap.Name = "label_cts_ngaynhap";
            this.label_cts_ngaynhap.Size = new System.Drawing.Size(704, 103);
            this.label_cts_ngaynhap.TabIndex = 10;
            this.label_cts_ngaynhap.Text = "Ngày Nhập:";
            this.label_cts_ngaynhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cts_masach
            // 
            this.txt_cts_masach.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cts_masach.Location = new System.Drawing.Point(177, 40);
            this.txt_cts_masach.Name = "txt_cts_masach";
            this.txt_cts_masach.ReadOnly = true;
            this.txt_cts_masach.Size = new System.Drawing.Size(337, 44);
            this.txt_cts_masach.TabIndex = 2;
            // 
            // label_cts_nhaxb
            // 
            this.label_cts_nhaxb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_nhaxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_nhaxb.Location = new System.Drawing.Point(539, 243);
            this.label_cts_nhaxb.Name = "label_cts_nhaxb";
            this.label_cts_nhaxb.Size = new System.Drawing.Size(518, 103);
            this.label_cts_nhaxb.TabIndex = 7;
            this.label_cts_nhaxb.Text = "Nhà XB:";
            this.label_cts_nhaxb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_ngonngu
            // 
            this.label_cts_ngonngu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_ngonngu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_ngonngu.Location = new System.Drawing.Point(7, 243);
            this.label_cts_ngonngu.Name = "label_cts_ngonngu";
            this.label_cts_ngonngu.Size = new System.Drawing.Size(518, 103);
            this.label_cts_ngonngu.TabIndex = 6;
            this.label_cts_ngonngu.Text = "Ngôn Ngữ:";
            this.label_cts_ngonngu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_namxb
            // 
            this.label_cts_namxb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_namxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_namxb.Location = new System.Drawing.Point(539, 126);
            this.label_cts_namxb.Name = "label_cts_namxb";
            this.label_cts_namxb.Size = new System.Drawing.Size(520, 103);
            this.label_cts_namxb.TabIndex = 5;
            this.label_cts_namxb.Text = "Năm XB:";
            this.label_cts_namxb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_tacgia
            // 
            this.label_cts_tacgia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_tacgia.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_tacgia.Location = new System.Drawing.Point(7, 126);
            this.label_cts_tacgia.Name = "label_cts_tacgia";
            this.label_cts_tacgia.Size = new System.Drawing.Size(518, 103);
            this.label_cts_tacgia.TabIndex = 4;
            this.label_cts_tacgia.Text = "Tác Giả:";
            this.label_cts_tacgia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_theloai
            // 
            this.label_cts_theloai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_theloai.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_theloai.Location = new System.Drawing.Point(539, 10);
            this.label_cts_theloai.Name = "label_cts_theloai";
            this.label_cts_theloai.Size = new System.Drawing.Size(520, 103);
            this.label_cts_theloai.TabIndex = 3;
            this.label_cts_theloai.Text = "Thể Loại:";
            this.label_cts_theloai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cts_masach
            // 
            this.label_cts_masach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_masach.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_masach.Location = new System.Drawing.Point(6, 10);
            this.label_cts_masach.Name = "label_cts_masach";
            this.label_cts_masach.Size = new System.Drawing.Size(519, 103);
            this.label_cts_masach.TabIndex = 2;
            this.label_cts_masach.Text = "Mã Sách:";
            this.label_cts_masach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label_cts_tensach);
            this.panel2.Controls.Add(this.label_cts_thongtinsach);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 119);
            this.panel2.TabIndex = 0;
            // 
            // label_cts_thongtinsach
            // 
            this.label_cts_thongtinsach.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_thongtinsach.ForeColor = System.Drawing.Color.DarkRed;
            this.label_cts_thongtinsach.Location = new System.Drawing.Point(257, 12);
            this.label_cts_thongtinsach.Name = "label_cts_thongtinsach";
            this.label_cts_thongtinsach.Size = new System.Drawing.Size(373, 91);
            this.label_cts_thongtinsach.TabIndex = 0;
            this.label_cts_thongtinsach.Text = "Thông Tin Sách";
            this.label_cts_thongtinsach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_cts_tensach
            // 
            this.label_cts_tensach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cts_tensach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cts_tensach.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_cts_tensach.Location = new System.Drawing.Point(632, 12);
            this.label_cts_tensach.Name = "label_cts_tensach";
            this.label_cts_tensach.Size = new System.Drawing.Size(424, 91);
            this.label_cts_tensach.TabIndex = 1;
            this.label_cts_tensach.Text = "Tên Sách";
            this.label_cts_tensach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_ChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.button_cts_huy;
            this.ClientSize = new System.Drawing.Size(1076, 832);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ChiTietSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Sách";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_cts_thongtinsach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_cts_nhaxb;
        private System.Windows.Forms.Label label_cts_ngonngu;
        private System.Windows.Forms.Label label_cts_namxb;
        private System.Windows.Forms.Label label_cts_tacgia;
        private System.Windows.Forms.Label label_cts_theloai;
        private System.Windows.Forms.Label label_cts_masach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_cts_tinhtrang;
        private System.Windows.Forms.Label label_cts_trigia;
        private System.Windows.Forms.Label label_cts_ngaynhap;
        private System.Windows.Forms.TextBox txt_cts_masach;
        private System.Windows.Forms.Button button_cts_huy;
        private System.Windows.Forms.Button button_cts_xoa;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_chinhsua;
        private System.Windows.Forms.TextBox txt_cts_tinhtrang;
        private System.Windows.Forms.TextBox txt_cts_trigia;
        private System.Windows.Forms.TextBox txt_cts_nhaxb;
        private System.Windows.Forms.TextBox txt_cts_ngonngu;
        private System.Windows.Forms.TextBox txt_cts_namxb;
        private System.Windows.Forms.TextBox txt_cts_tacgia;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cts_ngaynhap;
        private System.Windows.Forms.ComboBox cmb_cts_theloai;
        private System.Windows.Forms.Label label_cts_tensach;
    }
}