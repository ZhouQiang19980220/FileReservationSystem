
namespace FileReservationSystem
{
    partial class ReturnDocForm
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
            this.label_objName = new System.Windows.Forms.Label();
            this.textBox_objName = new System.Windows.Forms.TextBox();
            this.textBox_ObjCode = new System.Windows.Forms.TextBox();
            this.label_objCode = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_objName
            // 
            this.label_objName.AutoSize = true;
            this.label_objName.Location = new System.Drawing.Point(90, 38);
            this.label_objName.Name = "label_objName";
            this.label_objName.Size = new System.Drawing.Size(77, 12);
            this.label_objName.TabIndex = 0;
            this.label_objName.Text = "被借阅人姓名";
            // 
            // textBox_objName
            // 
            this.textBox_objName.Location = new System.Drawing.Point(212, 35);
            this.textBox_objName.Name = "textBox_objName";
            this.textBox_objName.Size = new System.Drawing.Size(100, 21);
            this.textBox_objName.TabIndex = 1;
            // 
            // textBox_ObjCode
            // 
            this.textBox_ObjCode.Location = new System.Drawing.Point(212, 82);
            this.textBox_ObjCode.Name = "textBox_ObjCode";
            this.textBox_ObjCode.Size = new System.Drawing.Size(100, 21);
            this.textBox_ObjCode.TabIndex = 3;
            // 
            // label_objCode
            // 
            this.label_objCode.AutoSize = true;
            this.label_objCode.Location = new System.Drawing.Point(90, 85);
            this.label_objCode.Name = "label_objCode";
            this.label_objCode.Size = new System.Drawing.Size(89, 12);
            this.label_objCode.TabIndex = 2;
            this.label_objCode.Text = "被借阅人档案号";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(92, 170);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(212, 170);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "返回";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // ReturnDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 233);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_ObjCode);
            this.Controls.Add(this.label_objCode);
            this.Controls.Add(this.textBox_objName);
            this.Controls.Add(this.label_objName);
            this.Name = "ReturnDocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnDocForm";
            this.Load += new System.EventHandler(this.ReturnDocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_objName;
        private System.Windows.Forms.TextBox textBox_objName;
        private System.Windows.Forms.TextBox textBox_ObjCode;
        private System.Windows.Forms.Label label_objCode;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Exit;
    }
}