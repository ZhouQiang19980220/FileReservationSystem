
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
            this.label_objName.Location = new System.Drawing.Point(120, 48);
            this.label_objName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_objName.Name = "label_objName";
            this.label_objName.Size = new System.Drawing.Size(97, 15);
            this.label_objName.TabIndex = 0;
            this.label_objName.Text = "被借阅人姓名";
            // 
            // textBox_objName
            // 
            this.textBox_objName.Location = new System.Drawing.Point(283, 44);
            this.textBox_objName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_objName.Name = "textBox_objName";
            this.textBox_objName.Size = new System.Drawing.Size(132, 25);
            this.textBox_objName.TabIndex = 1;
            // 
            // textBox_ObjCode
            // 
            this.textBox_ObjCode.Location = new System.Drawing.Point(283, 102);
            this.textBox_ObjCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ObjCode.Name = "textBox_ObjCode";
            this.textBox_ObjCode.Size = new System.Drawing.Size(132, 25);
            this.textBox_ObjCode.TabIndex = 3;
            // 
            // label_objCode
            // 
            this.label_objCode.AutoSize = true;
            this.label_objCode.Location = new System.Drawing.Point(120, 106);
            this.label_objCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_objCode.Name = "label_objCode";
            this.label_objCode.Size = new System.Drawing.Size(112, 15);
            this.label_objCode.TabIndex = 2;
            this.label_objCode.Text = "被借阅人档案号";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(123, 212);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 29);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(283, 212);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(100, 29);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "返回";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // ReturnDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 291);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_ObjCode);
            this.Controls.Add(this.label_objCode);
            this.Controls.Add(this.textBox_objName);
            this.Controls.Add(this.label_objName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReturnDocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "归档界面";
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