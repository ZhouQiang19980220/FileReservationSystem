
namespace FileReservationSystem
{
    partial class authorizeForm
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
            this.button_agree = new System.Windows.Forms.Button();
            this.button_disagree = new System.Windows.Forms.Button();
            this.dataGridView_authorize = new System.Windows.Forms.DataGridView();
            this.button_onlyShowPending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authorize)).BeginInit();
            this.SuspendLayout();
            // 
            // button_agree
            // 
            this.button_agree.Location = new System.Drawing.Point(107, 252);
            this.button_agree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_agree.Name = "button_agree";
            this.button_agree.Size = new System.Drawing.Size(56, 26);
            this.button_agree.TabIndex = 1;
            this.button_agree.Text = "同意 ";
            this.button_agree.UseVisualStyleBackColor = true;
            this.button_agree.Click += new System.EventHandler(this.button_agree_Click);
            // 
            // button_disagree
            // 
            this.button_disagree.Location = new System.Drawing.Point(256, 252);
            this.button_disagree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_disagree.Name = "button_disagree";
            this.button_disagree.Size = new System.Drawing.Size(56, 26);
            this.button_disagree.TabIndex = 2;
            this.button_disagree.Text = "不同意";
            this.button_disagree.UseVisualStyleBackColor = true;
            this.button_disagree.Click += new System.EventHandler(this.button_disagree_Click);
            // 
            // dataGridView_authorize
            // 
            this.dataGridView_authorize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_authorize.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_authorize.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_authorize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authorize.Location = new System.Drawing.Point(9, 10);
            this.dataGridView_authorize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_authorize.Name = "dataGridView_authorize";
            this.dataGridView_authorize.ReadOnly = true;
            this.dataGridView_authorize.RowHeadersWidth = 51;
            this.dataGridView_authorize.RowTemplate.Height = 27;
            this.dataGridView_authorize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_authorize.Size = new System.Drawing.Size(629, 223);
            this.dataGridView_authorize.StandardTab = true;
            this.dataGridView_authorize.TabIndex = 3;
            // 
            // button_onlyShowPending
            // 
            this.button_onlyShowPending.Location = new System.Drawing.Point(408, 252);
            this.button_onlyShowPending.Margin = new System.Windows.Forms.Padding(2);
            this.button_onlyShowPending.Name = "button_onlyShowPending";
            this.button_onlyShowPending.Size = new System.Drawing.Size(133, 26);
            this.button_onlyShowPending.TabIndex = 4;
            this.button_onlyShowPending.Text = "查看未授权记录";
            this.button_onlyShowPending.UseVisualStyleBackColor = true;
            this.button_onlyShowPending.Click += new System.EventHandler(this.button_onlyShowPending_Click);
            // 
            // authorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 301);
            this.Controls.Add(this.button_onlyShowPending);
            this.Controls.Add(this.dataGridView_authorize);
            this.Controls.Add(this.button_disagree);
            this.Controls.Add(this.button_agree);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "authorizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "授权管理";
            this.Load += new System.EventHandler(this.authorizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authorize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_agree;
        private System.Windows.Forms.Button button_disagree;
        private System.Windows.Forms.DataGridView dataGridView_authorize;
        private System.Windows.Forms.Button button_onlyShowPending;
    }
}