
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
            this.button_refresh = new System.Windows.Forms.Button();
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
            this.dataGridView_application.AllowUserToAddRows = false;
            this.dataGridView_application.AllowUserToDeleteRows = false;
            this.dataGridView_application.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_application.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_application.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_application.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_application.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_application.Location = new System.Drawing.Point(43, 79);
            this.dataGridView_application.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_application.MultiSelect = false;
            this.dataGridView_application.Name = "dataGridView_application";
            this.dataGridView_application.ReadOnly = true;
            this.dataGridView_application.RowHeadersWidth = 51;
            this.dataGridView_application.RowTemplate.Height = 27;
            this.dataGridView_application.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_application.Size = new System.Drawing.Size(877, 209);
            this.dataGridView_application.TabIndex = 1;
            this.dataGridView_application.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_application_CellContentClick);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(3, 2);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(149, 32);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_application
            // 
            this.button_application.Location = new System.Drawing.Point(185, 2);
            this.button_application.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_application.Name = "button_application";
            this.button_application.Size = new System.Drawing.Size(149, 32);
            this.button_application.TabIndex = 3;
            this.button_application.Text = "新增预约";
            this.button_application.UseVisualStyleBackColor = true;
            this.button_application.Click += new System.EventHandler(this.button_application_Click);
            // 
            // button_lookAuthorizeApp
            // 
            this.button_lookAuthorizeApp.Location = new System.Drawing.Point(549, 2);
            this.button_lookAuthorizeApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_lookAuthorizeApp.Name = "button_lookAuthorizeApp";
            this.button_lookAuthorizeApp.Size = new System.Drawing.Size(149, 32);
            this.button_lookAuthorizeApp.TabIndex = 4;
            this.button_lookAuthorizeApp.Text = "查看授权申请";
            this.button_lookAuthorizeApp.UseVisualStyleBackColor = true;
            this.button_lookAuthorizeApp.Click += new System.EventHandler(this.button_lookAuthorizeApp_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(731, 2);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(143, 32);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.button_refresh, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_application, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_exit, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_lookAuthorizeApp, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 305);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 46);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(367, 2);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(149, 32);
            this.button_refresh.TabIndex = 7;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView_application);
            this.Controls.Add(this.label_application);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户界面";
            this.Load += new System.EventHandler(this.userForm_Load);
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
        private System.Windows.Forms.Button button_refresh;
    }
}