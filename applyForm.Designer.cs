
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
            this.label_objName = new System.Windows.Forms.Label();
            this.textBox_objname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_applicant
            // 
            this.label_applicant.AutoSize = true;
            this.label_applicant.Location = new System.Drawing.Point(58, 59);
            this.label_applicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_applicant.Name = "label_applicant";
            this.label_applicant.Size = new System.Drawing.Size(89, 12);
            this.label_applicant.TabIndex = 0;
            this.label_applicant.Text = "申请人档案编号";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(69, 150);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(77, 12);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "预计借出时间";
            // 
            // label_object
            // 
            this.label_object.AutoSize = true;
            this.label_object.Location = new System.Drawing.Point(58, 116);
            this.label_object.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_object.Name = "label_object";
            this.label_object.Size = new System.Drawing.Size(89, 12);
            this.label_object.TabIndex = 2;
            this.label_object.Text = "被借阅档案编号";
            // 
            // textBox_applicant
            // 
            this.textBox_applicant.Enabled = false;
            this.textBox_applicant.Location = new System.Drawing.Point(165, 57);
            this.textBox_applicant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_applicant.Name = "textBox_applicant";
            this.textBox_applicant.Size = new System.Drawing.Size(151, 21);
            this.textBox_applicant.TabIndex = 3;
            // 
            // textBox_object
            // 
            this.textBox_object.Location = new System.Drawing.Point(165, 114);
            this.textBox_object.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_object.Name = "textBox_object";
            this.textBox_object.Size = new System.Drawing.Size(151, 21);
            this.textBox_object.TabIndex = 4;
            // 
            // dateTimePicker_application
            // 
            this.dateTimePicker_application.Location = new System.Drawing.Point(165, 144);
            this.dateTimePicker_application.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_application.MinDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_application.Name = "dateTimePicker_application";
            this.dateTimePicker_application.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker_application.TabIndex = 5;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(107, 178);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(56, 26);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(238, 178);
            this.button_cansel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(56, 26);
            this.button_cansel.TabIndex = 7;
            this.button_cansel.Text = "取消";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // label_objName
            // 
            this.label_objName.AutoSize = true;
            this.label_objName.Location = new System.Drawing.Point(58, 90);
            this.label_objName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_objName.Name = "label_objName";
            this.label_objName.Size = new System.Drawing.Size(77, 12);
            this.label_objName.TabIndex = 8;
            this.label_objName.Text = "被借阅人姓名";
            // 
            // textBox_objname
            // 
            this.textBox_objname.Location = new System.Drawing.Point(165, 87);
            this.textBox_objname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_objname.Name = "textBox_objname";
            this.textBox_objname.Size = new System.Drawing.Size(151, 21);
            this.textBox_objname.TabIndex = 9;
            // 
            // applyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 240);
            this.Controls.Add(this.textBox_objname);
            this.Controls.Add(this.label_objName);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.dateTimePicker_application);
            this.Controls.Add(this.textBox_object);
            this.Controls.Add(this.textBox_applicant);
            this.Controls.Add(this.label_object);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_applicant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "applyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label label_objName;
        private System.Windows.Forms.TextBox textBox_objname;
    }
}