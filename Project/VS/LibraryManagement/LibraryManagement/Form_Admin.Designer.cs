namespace LibraryManagement
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.tabControl_Admin = new System.Windows.Forms.TabControl();
            this.tab_quidinh = new System.Windows.Forms.TabPage();
            this.tabPage_nhanvien = new System.Windows.Forms.TabPage();
            this.tabPage_dangkynv = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_ad_docgia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ad_tuoitoithieu = new System.Windows.Forms.Label();
            this.label_tuoitoida = new System.Windows.Forms.Label();
            this.label_ad_thoihan = new System.Windows.Forms.Label();
            this.numericUpDown_tuoitoithieu = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_tuoitoida = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_thoihanthe = new System.Windows.Forms.NumericUpDown();
            this.label_ad_namxb = new System.Windows.Forms.Label();
            this.label_ad_sachtoida = new System.Windows.Forms.Label();
            this.label_ad_songaytoida = new System.Windows.Forms.Label();
            this.numericUpDown_sachtoida = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_songaytoida = new System.Windows.Forms.NumericUpDown();
            this.button_ad_theloai = new System.Windows.Forms.Button();
            this.numericUpDown_namxb = new System.Windows.Forms.NumericUpDown();
            this.button_ad_capnhat = new System.Windows.Forms.Button();
            this.button_ad_quidinh_out = new System.Windows.Forms.Button();
            this.tabControl_Admin.SuspendLayout();
            this.tab_quidinh.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tuoitoithieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tuoitoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_thoihanthe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sachtoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_songaytoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_namxb)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Admin
            // 
            this.tabControl_Admin.Controls.Add(this.tab_quidinh);
            this.tabControl_Admin.Controls.Add(this.tabPage_nhanvien);
            this.tabControl_Admin.Controls.Add(this.tabPage_dangkynv);
            this.tabControl_Admin.Location = new System.Drawing.Point(3, 2);
            this.tabControl_Admin.Name = "tabControl_Admin";
            this.tabControl_Admin.SelectedIndex = 0;
            this.tabControl_Admin.Size = new System.Drawing.Size(1407, 788);
            this.tabControl_Admin.TabIndex = 0;
            // 
            // tab_quidinh
            // 
            this.tab_quidinh.Controls.Add(this.button_ad_quidinh_out);
            this.tab_quidinh.Controls.Add(this.button_ad_capnhat);
            this.tab_quidinh.Controls.Add(this.panel3);
            this.tab_quidinh.Controls.Add(this.panel2);
            this.tab_quidinh.Controls.Add(this.panel1);
            this.tab_quidinh.Location = new System.Drawing.Point(4, 36);
            this.tab_quidinh.Name = "tab_quidinh";
            this.tab_quidinh.Padding = new System.Windows.Forms.Padding(3);
            this.tab_quidinh.Size = new System.Drawing.Size(1399, 748);
            this.tab_quidinh.TabIndex = 0;
            this.tab_quidinh.Text = "Thay Đổi Qui Định";
            this.tab_quidinh.UseVisualStyleBackColor = true;
            // 
            // tabPage_nhanvien
            // 
            this.tabPage_nhanvien.Location = new System.Drawing.Point(4, 36);
            this.tabPage_nhanvien.Name = "tabPage_nhanvien";
            this.tabPage_nhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_nhanvien.Size = new System.Drawing.Size(1399, 748);
            this.tabPage_nhanvien.TabIndex = 1;
            this.tabPage_nhanvien.Text = "Quản Lý Nhân Viên";
            this.tabPage_nhanvien.UseVisualStyleBackColor = true;
            // 
            // tabPage_dangkynv
            // 
            this.tabPage_dangkynv.Location = new System.Drawing.Point(4, 36);
            this.tabPage_dangkynv.Name = "tabPage_dangkynv";
            this.tabPage_dangkynv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dangkynv.Size = new System.Drawing.Size(1399, 748);
            this.tabPage_dangkynv.TabIndex = 2;
            this.tabPage_dangkynv.Text = "Đăng Ký Nhân Viên";
            this.tabPage_dangkynv.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown_thoihanthe);
            this.panel1.Controls.Add(this.numericUpDown_tuoitoida);
            this.panel1.Controls.Add(this.numericUpDown_tuoitoithieu);
            this.panel1.Controls.Add(this.label_ad_thoihan);
            this.panel1.Controls.Add(this.label_tuoitoida);
            this.panel1.Controls.Add(this.label_ad_tuoitoithieu);
            this.panel1.Controls.Add(this.label_ad_docgia);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 638);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numericUpDown_namxb);
            this.panel2.Controls.Add(this.button_ad_theloai);
            this.panel2.Controls.Add(this.label_ad_namxb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(494, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 638);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.numericUpDown_songaytoida);
            this.panel3.Controls.Add(this.numericUpDown_sachtoida);
            this.panel3.Controls.Add(this.label_ad_songaytoida);
            this.panel3.Controls.Add(this.label_ad_sachtoida);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(967, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 638);
            this.panel3.TabIndex = 1;
            // 
            // label_ad_docgia
            // 
            this.label_ad_docgia.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_docgia.ForeColor = System.Drawing.Color.Tomato;
            this.label_ad_docgia.Location = new System.Drawing.Point(13, 11);
            this.label_ad_docgia.Name = "label_ad_docgia";
            this.label_ad_docgia.Size = new System.Drawing.Size(408, 82);
            this.label_ad_docgia.TabIndex = 0;
            this.label_ad_docgia.Text = "Độc Giả";
            this.label_ad_docgia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 82);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu Mượn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ad_tuoitoithieu
            // 
            this.label_ad_tuoitoithieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ad_tuoitoithieu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_tuoitoithieu.Location = new System.Drawing.Point(11, 188);
            this.label_ad_tuoitoithieu.Name = "label_ad_tuoitoithieu";
            this.label_ad_tuoitoithieu.Size = new System.Drawing.Size(404, 61);
            this.label_ad_tuoitoithieu.TabIndex = 1;
            this.label_ad_tuoitoithieu.Text = "Tuổi Tối Thiểu:";
            this.label_ad_tuoitoithieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_tuoitoida
            // 
            this.label_tuoitoida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_tuoitoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tuoitoida.Location = new System.Drawing.Point(11, 362);
            this.label_tuoitoida.Name = "label_tuoitoida";
            this.label_tuoitoida.Size = new System.Drawing.Size(404, 61);
            this.label_tuoitoida.TabIndex = 2;
            this.label_tuoitoida.Text = "Tuổi Tối Đa:";
            this.label_tuoitoida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ad_thoihan
            // 
            this.label_ad_thoihan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ad_thoihan.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_thoihan.Location = new System.Drawing.Point(11, 548);
            this.label_ad_thoihan.Name = "label_ad_thoihan";
            this.label_ad_thoihan.Size = new System.Drawing.Size(404, 61);
            this.label_ad_thoihan.TabIndex = 3;
            this.label_ad_thoihan.Text = "Thời Hạn Của Thẻ:";
            this.label_ad_thoihan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_tuoitoithieu
            // 
            this.numericUpDown_tuoitoithieu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tuoitoithieu.Location = new System.Drawing.Point(268, 198);
            this.numericUpDown_tuoitoithieu.Name = "numericUpDown_tuoitoithieu";
            this.numericUpDown_tuoitoithieu.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_tuoitoithieu.TabIndex = 4;
            this.numericUpDown_tuoitoithieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_tuoitoida
            // 
            this.numericUpDown_tuoitoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_tuoitoida.Location = new System.Drawing.Point(268, 372);
            this.numericUpDown_tuoitoida.Name = "numericUpDown_tuoitoida";
            this.numericUpDown_tuoitoida.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_tuoitoida.TabIndex = 5;
            this.numericUpDown_tuoitoida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_thoihanthe
            // 
            this.numericUpDown_thoihanthe.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_thoihanthe.Location = new System.Drawing.Point(268, 558);
            this.numericUpDown_thoihanthe.Name = "numericUpDown_thoihanthe";
            this.numericUpDown_thoihanthe.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_thoihanthe.TabIndex = 6;
            this.numericUpDown_thoihanthe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ad_namxb
            // 
            this.label_ad_namxb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ad_namxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_namxb.Location = new System.Drawing.Point(19, 362);
            this.label_ad_namxb.Name = "label_ad_namxb";
            this.label_ad_namxb.Size = new System.Drawing.Size(404, 61);
            this.label_ad_namxb.TabIndex = 9;
            this.label_ad_namxb.Text = "Khoảng Cách Năm Xuất Bản:";
            this.label_ad_namxb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ad_sachtoida
            // 
            this.label_ad_sachtoida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ad_sachtoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_sachtoida.Location = new System.Drawing.Point(14, 188);
            this.label_ad_sachtoida.Name = "label_ad_sachtoida";
            this.label_ad_sachtoida.Size = new System.Drawing.Size(404, 61);
            this.label_ad_sachtoida.TabIndex = 10;
            this.label_ad_sachtoida.Text = "Số Lượn Sách Mượn Tối Đa:";
            this.label_ad_sachtoida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ad_songaytoida
            // 
            this.label_ad_songaytoida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ad_songaytoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ad_songaytoida.Location = new System.Drawing.Point(14, 432);
            this.label_ad_songaytoida.Name = "label_ad_songaytoida";
            this.label_ad_songaytoida.Size = new System.Drawing.Size(404, 61);
            this.label_ad_songaytoida.TabIndex = 11;
            this.label_ad_songaytoida.Text = "Số Ngày Mượn Tối Đa:";
            this.label_ad_songaytoida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_sachtoida
            // 
            this.numericUpDown_sachtoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_sachtoida.Location = new System.Drawing.Point(135, 286);
            this.numericUpDown_sachtoida.Name = "numericUpDown_sachtoida";
            this.numericUpDown_sachtoida.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_sachtoida.TabIndex = 7;
            this.numericUpDown_sachtoida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_songaytoida
            // 
            this.numericUpDown_songaytoida.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_songaytoida.Location = new System.Drawing.Point(135, 529);
            this.numericUpDown_songaytoida.Name = "numericUpDown_songaytoida";
            this.numericUpDown_songaytoida.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_songaytoida.TabIndex = 12;
            this.numericUpDown_songaytoida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ad_theloai
            // 
            this.button_ad_theloai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ad_theloai.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ad_theloai.Location = new System.Drawing.Point(19, 188);
            this.button_ad_theloai.Name = "button_ad_theloai";
            this.button_ad_theloai.Size = new System.Drawing.Size(404, 54);
            this.button_ad_theloai.TabIndex = 10;
            this.button_ad_theloai.Text = "Thay Đổi Thể Loại";
            this.button_ad_theloai.UseVisualStyleBackColor = true;
            this.button_ad_theloai.Click += new System.EventHandler(this.button_ad_theloai_Click);
            // 
            // numericUpDown_namxb
            // 
            this.numericUpDown_namxb.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_namxb.Location = new System.Drawing.Point(154, 432);
            this.numericUpDown_namxb.Name = "numericUpDown_namxb";
            this.numericUpDown_namxb.Size = new System.Drawing.Size(147, 44);
            this.numericUpDown_namxb.TabIndex = 7;
            this.numericUpDown_namxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ad_capnhat
            // 
            this.button_ad_capnhat.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ad_capnhat.Location = new System.Drawing.Point(290, 668);
            this.button_ad_capnhat.Name = "button_ad_capnhat";
            this.button_ad_capnhat.Size = new System.Drawing.Size(404, 54);
            this.button_ad_capnhat.TabIndex = 11;
            this.button_ad_capnhat.Text = "Cập Nhật";
            this.button_ad_capnhat.UseVisualStyleBackColor = true;
            // 
            // button_ad_quidinh_out
            // 
            this.button_ad_quidinh_out.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_ad_quidinh_out.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ad_quidinh_out.Location = new System.Drawing.Point(715, 668);
            this.button_ad_quidinh_out.Name = "button_ad_quidinh_out";
            this.button_ad_quidinh_out.Size = new System.Drawing.Size(404, 54);
            this.button_ad_quidinh_out.TabIndex = 12;
            this.button_ad_quidinh_out.Text = "Thoát";
            this.button_ad_quidinh_out.UseVisualStyleBackColor = true;
            this.button_ad_quidinh_out.Click += new System.EventHandler(this.button_ad_quidinh_out_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.button_ad_quidinh_out;
            this.ClientSize = new System.Drawing.Size(1411, 789);
            this.Controls.Add(this.tabControl_Admin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Trị Admin";
            this.tabControl_Admin.ResumeLayout(false);
            this.tab_quidinh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tuoitoithieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tuoitoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_thoihanthe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sachtoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_songaytoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_namxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Admin;
        private System.Windows.Forms.TabPage tab_quidinh;
        private System.Windows.Forms.TabPage tabPage_nhanvien;
        private System.Windows.Forms.TabPage tabPage_dangkynv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ad_docgia;
        private System.Windows.Forms.Button button_ad_quidinh_out;
        private System.Windows.Forms.Button button_ad_capnhat;
        private System.Windows.Forms.NumericUpDown numericUpDown_songaytoida;
        private System.Windows.Forms.NumericUpDown numericUpDown_sachtoida;
        private System.Windows.Forms.Label label_ad_songaytoida;
        private System.Windows.Forms.Label label_ad_sachtoida;
        private System.Windows.Forms.NumericUpDown numericUpDown_namxb;
        private System.Windows.Forms.Button button_ad_theloai;
        private System.Windows.Forms.Label label_ad_namxb;
        private System.Windows.Forms.NumericUpDown numericUpDown_thoihanthe;
        private System.Windows.Forms.NumericUpDown numericUpDown_tuoitoida;
        private System.Windows.Forms.NumericUpDown numericUpDown_tuoitoithieu;
        private System.Windows.Forms.Label label_ad_thoihan;
        private System.Windows.Forms.Label label_tuoitoida;
        private System.Windows.Forms.Label label_ad_tuoitoithieu;
    }
}