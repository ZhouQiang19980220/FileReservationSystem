
namespace FileReservationSystem
{
    partial class LookAPP
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
            this.dataGridView_app = new System.Windows.Forms.DataGridView();
            this.button_lend = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_app)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_app
            // 
            this.dataGridView_app.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_app.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_app.Name = "dataGridView_app";
            this.dataGridView_app.RowHeadersWidth = 51;
            this.dataGridView_app.RowTemplate.Height = 27;
            this.dataGridView_app.Size = new System.Drawing.Size(767, 359);
            this.dataGridView_app.TabIndex = 0;
            // 
            // button_lend
            // 
            this.button_lend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_lend.Location = new System.Drawing.Point(190, 391);
            this.button_lend.Name = "button_lend";
            this.button_lend.Size = new System.Drawing.Size(75, 33);
            this.button_lend.TabIndex = 1;
            this.button_lend.Text = "确认借出";
            this.button_lend.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.Location = new System.Drawing.Point(481, 391);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 33);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // LookAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 60F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 443);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_lend);
            this.Controls.Add(this.dataGridView_app);
            this.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.Name = "LookAPP";
            this.Text = "查看预约";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_app)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_app;
        private System.Windows.Forms.Button button_lend;
        private System.Windows.Forms.Button button_exit;
    }
}