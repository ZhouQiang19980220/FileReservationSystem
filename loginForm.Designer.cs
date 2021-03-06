﻿
namespace FileReservationSystem
{
    partial class loginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_userType = new System.Windows.Forms.ComboBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_cansel = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_userType = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(194, 53);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(199, 25);
            this.textBox_user.TabIndex = 0;
            this.textBox_user.Text = "20200001";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(194, 109);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(199, 25);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "S20200001";
            // 
            // comboBox_userType
            // 
            this.comboBox_userType.FormattingEnabled = true;
            this.comboBox_userType.Items.AddRange(new object[] {
            "普通用户",
            "院系管理员",
            "档案管理员"});
            this.comboBox_userType.Location = new System.Drawing.Point(194, 163);
            this.comboBox_userType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_userType.Name = "comboBox_userType";
            this.comboBox_userType.Size = new System.Drawing.Size(199, 23);
            this.comboBox_userType.TabIndex = 2;
            this.comboBox_userType.Text = "用户类型";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(194, 207);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(77, 32);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "登陆";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(315, 207);
            this.button_cansel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(77, 32);
            this.button_cansel.TabIndex = 0;
            this.button_cansel.Text = "退出";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(117, 55);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(52, 15);
            this.label_user.TabIndex = 4;
            this.label_user.Text = "用户名";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(117, 113);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 15);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "密  码";
            // 
            // label_userType
            // 
            this.label_userType.AutoSize = true;
            this.label_userType.Location = new System.Drawing.Point(117, 166);
            this.label_userType.Name = "label_userType";
            this.label_userType.Size = new System.Drawing.Size(53, 15);
            this.label_userType.TabIndex = 6;
            this.label_userType.Text = "类  型";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 289);
            this.Controls.Add(this.label_userType);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.comboBox_userType);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_user);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_userType;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_userType;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

