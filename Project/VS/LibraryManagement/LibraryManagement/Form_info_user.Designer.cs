﻿namespace LibraryManagement
{
    partial class Form_info_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_info_user));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_out = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_if_reenterpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_if_newpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_if_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tennhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_eye = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_eye);
            this.panel1.Controls.Add(this.bt_out);
            this.panel1.Controls.Add(this.bt_Update);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 823);
            this.panel1.TabIndex = 0;
            // 
            // bt_out
            // 
            this.bt_out.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_out.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.bt_out.ForeColor = System.Drawing.Color.Black;
            this.bt_out.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_out.Location = new System.Drawing.Point(609, 681);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(181, 93);
            this.bt_out.TabIndex = 2;
            this.bt_out.Text = "Thoát";
            this.bt_out.UseVisualStyleBackColor = true;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.bt_Update.ForeColor = System.Drawing.Color.Black;
            this.bt_Update.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Update.Location = new System.Drawing.Point(387, 681);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(181, 93);
            this.bt_Update.TabIndex = 1;
            this.bt_Update.Text = "Cập Nhật";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.txt_if_reenterpass);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(116, 572);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(838, 90);
            this.panel7.TabIndex = 0;
            // 
            // txt_if_reenterpass
            // 
            this.txt_if_reenterpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_if_reenterpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_if_reenterpass.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txt_if_reenterpass.Location = new System.Drawing.Point(269, 20);
            this.txt_if_reenterpass.Name = "txt_if_reenterpass";
            this.txt_if_reenterpass.Size = new System.Drawing.Size(403, 49);
            this.txt_if_reenterpass.TabIndex = 3;
            this.txt_if_reenterpass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 49);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập Lại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txt_if_newpass);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(116, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(838, 90);
            this.panel6.TabIndex = 0;
            // 
            // txt_if_newpass
            // 
            this.txt_if_newpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_if_newpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_if_newpass.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txt_if_newpass.Location = new System.Drawing.Point(269, 20);
            this.txt_if_newpass.Name = "txt_if_newpass";
            this.txt_if_newpass.Size = new System.Drawing.Size(403, 49);
            this.txt_if_newpass.TabIndex = 2;
            this.txt_if_newpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật Khẩu Mới:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txt_if_password);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(116, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(838, 90);
            this.panel5.TabIndex = 0;
            // 
            // txt_if_password
            // 
            this.txt_if_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_if_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_if_password.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txt_if_password.Location = new System.Drawing.Point(269, 20);
            this.txt_if_password.Name = "txt_if_password";
            this.txt_if_password.Size = new System.Drawing.Size(403, 49);
            this.txt_if_password.TabIndex = 1;
            this.txt_if_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_tennhom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(116, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 90);
            this.panel3.TabIndex = 0;
            // 
            // txt_tennhom
            // 
            this.txt_tennhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tennhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tennhom.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txt_tennhom.Location = new System.Drawing.Point(269, 20);
            this.txt_tennhom.Name = "txt_tennhom";
            this.txt_tennhom.ReadOnly = true;
            this.txt_tennhom.Size = new System.Drawing.Size(403, 49);
            this.txt_tennhom.TabIndex = 0;
            this.txt_tennhom.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhóm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_username);
            this.panel4.Controls.Add(this.lb_username);
            this.panel4.Location = new System.Drawing.Point(116, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(838, 90);
            this.panel4.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txt_username.Location = new System.Drawing.Point(269, 20);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(403, 49);
            this.txt_username.TabIndex = 0;
            this.txt_username.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lb_username.ForeColor = System.Drawing.Color.Black;
            this.lb_username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_username.Location = new System.Drawing.Point(10, 22);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(240, 49);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tên Đăng Nhập:";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 125);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 91);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Tài Khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button_eye
            // 
            this.button_eye.Image = ((System.Drawing.Image)(resources.GetObject("button_eye.Image")));
            this.button_eye.Location = new System.Drawing.Point(845, 681);
            this.button_eye.Name = "button_eye";
            this.button_eye.Size = new System.Drawing.Size(109, 93);
            this.button_eye.TabIndex = 3;
            this.button_eye.UseVisualStyleBackColor = true;
            this.button_eye.Click += new System.EventHandler(this.button_eye_Click);
            this.button_eye.MouseHover += new System.EventHandler(this.button_eye_MouseHover);
            // 
            // Form_info_user
            // 
            this.AcceptButton = this.bt_Update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_out;
            this.ClientSize = new System.Drawing.Size(1076, 832);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_info_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Tài Khoản";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_if_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_tennhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_if_reenterpass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_if_newpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_out;
        private System.Windows.Forms.Button button_eye;
    }
}