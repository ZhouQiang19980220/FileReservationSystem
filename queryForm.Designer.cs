
namespace FileReservationSystem
{
    partial class queryForm
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label_code = new System.Windows.Forms.Label();
            this.dataGridView_queryResult = new System.Windows.Forms.DataGridView();
            this.button_query = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_queryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(24, 31);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(85, 25);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 25);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(294, 28);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(100, 25);
            this.textBox_code.TabIndex = 3;
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(227, 31);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(52, 15);
            this.label_code.TabIndex = 2;
            this.label_code.Text = "档案号";
            // 
            // dataGridView_queryResult
            // 
            this.dataGridView_queryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_queryResult.Location = new System.Drawing.Point(27, 59);
            this.dataGridView_queryResult.Name = "dataGridView_queryResult";
            this.dataGridView_queryResult.RowHeadersWidth = 51;
            this.dataGridView_queryResult.RowTemplate.Height = 27;
            this.dataGridView_queryResult.Size = new System.Drawing.Size(617, 278);
            this.dataGridView_queryResult.TabIndex = 6;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(569, 28);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(75, 33);
            this.button_query.TabIndex = 7;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // queryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 370);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.dataGridView_queryResult);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Name = "queryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询界面";
            this.Load += new System.EventHandler(this.queryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_queryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.DataGridView dataGridView_queryResult;
        private System.Windows.Forms.Button button_query;
    }
}