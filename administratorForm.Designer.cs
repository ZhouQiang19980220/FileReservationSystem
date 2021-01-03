
namespace FileReservationSystem
{
    partial class administratorForm
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
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.button_lend = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_admin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.ReadOnly = true;
            this.dataGridView_admin.RowHeadersWidth = 51;
            this.dataGridView_admin.RowTemplate.Height = 27;
            this.dataGridView_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_admin.Size = new System.Drawing.Size(885, 334);
            this.dataGridView_admin.TabIndex = 0;
            // 
            // button_lend
            // 
            this.button_lend.Location = new System.Drawing.Point(15, 356);
            this.button_lend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_lend.Name = "button_lend";
            this.button_lend.Size = new System.Drawing.Size(109, 41);
            this.button_lend.TabIndex = 1;
            this.button_lend.Text = "确认借出";
            this.button_lend.UseVisualStyleBackColor = true;
            this.button_lend.Click += new System.EventHandler(this.button_lend_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(711, 356);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 41);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(179, 356);
            this.button_query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(136, 41);
            this.button_query.TabIndex = 3;
            this.button_query.Text = "查询预约记录";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 392);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(547, 356);
            this.button_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 41);
            this.button_return.TabIndex = 5;
            this.button_return.Text = "归档";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(393, 356);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 41);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // administratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 442);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_lend);
            this.Controls.Add(this.dataGridView_admin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "administratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.administratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.Button button_lend;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_refresh;
    }
}