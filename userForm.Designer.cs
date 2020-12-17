
namespace FileReservationSystem
{
    partial class userForm
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
            this.label_application = new System.Windows.Forms.Label();
            this.dataGridView_application = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_application = new System.Windows.Forms.Button();
            this.button_lookAuthorizeApp = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_application)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_application
            // 
            this.label_application.AutoSize = true;
            this.label_application.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_application.Location = new System.Drawing.Point(33, 26);
            this.label_application.Name = "label_application";
            this.label_application.Size = new System.Drawing.Size(226, 50);
            this.label_application.TabIndex = 0;
            this.label_application.Text = "我的预约";
            // 
            // dataGridView_application
            // 
            this.dataGridView_application.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_application.Location = new System.Drawing.Point(42, 79);
            this.dataGridView_application.Name = "dataGridView_application";
            this.dataGridView_application.RowHeadersWidth = 51;
            this.dataGridView_application.RowTemplate.Height = 27;
            this.dataGridView_application.Size = new System.Drawing.Size(712, 217);
            this.dataGridView_application.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(3, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(150, 33);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_application
            // 
            this.button_application.Location = new System.Drawing.Point(190, 3);
            this.button_application.Name = "button_application";
            this.button_application.Size = new System.Drawing.Size(150, 33);
            this.button_application.TabIndex = 3;
            this.button_application.Text = "预约";
            this.button_application.UseVisualStyleBackColor = true;
            // 
            // button_lookAuthorizeApp
            // 
            this.button_lookAuthorizeApp.Location = new System.Drawing.Point(377, 3);
            this.button_lookAuthorizeApp.Name = "button_lookAuthorizeApp";
            this.button_lookAuthorizeApp.Size = new System.Drawing.Size(150, 33);
            this.button_lookAuthorizeApp.TabIndex = 4;
            this.button_lookAuthorizeApp.Text = "查看授权申请";
            this.button_lookAuthorizeApp.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(564, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 33);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button_delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_exit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_application, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_lookAuthorizeApp, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 302);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 46);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView_application);
            this.Controls.Add(this.label_application);
            this.Name = "userForm";
            this.Text = "用户界面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_application)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_application;
        private System.Windows.Forms.DataGridView dataGridView_application;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_application;
        private System.Windows.Forms.Button button_lookAuthorizeApp;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}