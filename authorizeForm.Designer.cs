
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authorize)).BeginInit();
            this.SuspendLayout();
            // 
            // button_agree
            // 
            this.button_agree.Location = new System.Drawing.Point(148, 336);
            this.button_agree.Name = "button_agree";
            this.button_agree.Size = new System.Drawing.Size(75, 33);
            this.button_agree.TabIndex = 1;
            this.button_agree.Text = "同意 ";
            this.button_agree.UseVisualStyleBackColor = true;
            // 
            // button_disagree
            // 
            this.button_disagree.Location = new System.Drawing.Point(515, 336);
            this.button_disagree.Name = "button_disagree";
            this.button_disagree.Size = new System.Drawing.Size(75, 33);
            this.button_disagree.TabIndex = 2;
            this.button_disagree.Text = "不同意";
            this.button_disagree.UseVisualStyleBackColor = true;
            // 
            // dataGridView_authorize
            // 
            this.dataGridView_authorize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authorize.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_authorize.Name = "dataGridView_authorize";
            this.dataGridView_authorize.RowHeadersWidth = 51;
            this.dataGridView_authorize.RowTemplate.Height = 27;
            this.dataGridView_authorize.Size = new System.Drawing.Size(744, 294);
            this.dataGridView_authorize.TabIndex = 3;
            // 
            // authorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_authorize);
            this.Controls.Add(this.button_disagree);
            this.Controls.Add(this.button_agree);
            this.Name = "authorizeForm";
            this.Text = "授权管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authorize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_agree;
        private System.Windows.Forms.Button button_disagree;
        private System.Windows.Forms.DataGridView dataGridView_authorize;
    }
}