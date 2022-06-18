namespace DatabaseProject
{
    partial class DataGridViewFromAPI
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
            this.dataGridViewAPI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAPI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAPI
            // 
            this.dataGridViewAPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAPI.Location = new System.Drawing.Point(194, 24);
            this.dataGridViewAPI.Name = "dataGridViewAPI";
            this.dataGridViewAPI.RowTemplate.Height = 28;
            this.dataGridViewAPI.Size = new System.Drawing.Size(492, 490);
            this.dataGridViewAPI.TabIndex = 1;
            // 
            // DataGridViewFromAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 551);
            this.Controls.Add(this.dataGridViewAPI);
            this.Name = "DataGridViewFromAPI";
            this.Text = "DataGridViewFromAPI";
            this.Load += new System.EventHandler(this.DataGridViewFromAPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAPI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAPI;
    }
}