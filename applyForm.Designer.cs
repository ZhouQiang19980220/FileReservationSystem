﻿
namespace FileReservationSystem
{
    partial class applyForm
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
            this.label_applicant = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_object = new System.Windows.Forms.Label();
            this.textBox_applicant = new System.Windows.Forms.TextBox();
            this.textBox_object = new System.Windows.Forms.TextBox();
            this.dateTimePicker_application = new System.Windows.Forms.DateTimePicker();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_applicant
            // 
            this.label_applicant.AutoSize = true;
            this.label_applicant.Location = new System.Drawing.Point(77, 74);
            this.label_applicant.Name = "label_applicant";
            this.label_applicant.Size = new System.Drawing.Size(112, 15);
            this.label_applicant.TabIndex = 0;
            this.label_applicant.Text = "申请人档案编号";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(92, 154);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(97, 15);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "预计借出时间";
            // 
            // label_object
            // 
            this.label_object.AutoSize = true;
            this.label_object.Location = new System.Drawing.Point(77, 112);
            this.label_object.Name = "label_object";
            this.label_object.Size = new System.Drawing.Size(112, 15);
            this.label_object.TabIndex = 2;
            this.label_object.Text = "被借阅档案编号";
            // 
            // textBox_applicant
            // 
            this.textBox_applicant.Enabled = false;
            this.textBox_applicant.Location = new System.Drawing.Point(220, 71);
            this.textBox_applicant.Name = "textBox_applicant";
            this.textBox_applicant.Size = new System.Drawing.Size(200, 25);
            this.textBox_applicant.TabIndex = 3;
            // 
            // textBox_object
            // 
            this.textBox_object.Location = new System.Drawing.Point(220, 109);
            this.textBox_object.Name = "textBox_object";
            this.textBox_object.Size = new System.Drawing.Size(200, 25);
            this.textBox_object.TabIndex = 4;
            // 
            // dateTimePicker_application
            // 
            this.dateTimePicker_application.Location = new System.Drawing.Point(220, 147);
            this.dateTimePicker_application.Name = "dateTimePicker_application";
            this.dateTimePicker_application.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker_application.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(143, 189);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 33);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(318, 189);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(75, 33);
            this.button_cansel.TabIndex = 7;
            this.button_cansel.Text = "取消";
            this.button_cansel.UseVisualStyleBackColor = true;
            // 
            // applyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 300);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.dateTimePicker_application);
            this.Controls.Add(this.textBox_object);
            this.Controls.Add(this.textBox_applicant);
            this.Controls.Add(this.label_object);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_applicant);
            this.Name = "applyForm";
            this.Text = "applyForm";
            this.Load += new System.EventHandler(this.applyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_applicant;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_object;
        private System.Windows.Forms.TextBox textBox_applicant;
        private System.Windows.Forms.TextBox textBox_object;
        private System.Windows.Forms.DateTimePicker dateTimePicker_application;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cansel;
    }
}