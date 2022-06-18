namespace DatabaseProject
{
    partial class DataGridView
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
            this.btnPerformOperation = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnAPIGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerformOperation
            // 
            this.btnPerformOperation.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformOperation.Location = new System.Drawing.Point(247, 356);
            this.btnPerformOperation.Name = "btnPerformOperation";
            this.btnPerformOperation.Size = new System.Drawing.Size(505, 40);
            this.btnPerformOperation.TabIndex = 0;
            this.btnPerformOperation.Text = "Perform Operations";
            this.btnPerformOperation.UseVisualStyleBackColor = true;
            this.btnPerformOperation.Click += new System.EventHandler(this.btnPerformOperation_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(132, 28);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(753, 313);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // btnAPIGrid
            // 
            this.btnAPIGrid.Location = new System.Drawing.Point(823, 356);
            this.btnAPIGrid.Name = "btnAPIGrid";
            this.btnAPIGrid.Size = new System.Drawing.Size(157, 40);
            this.btnAPIGrid.TabIndex = 2;
            this.btnAPIGrid.Text = "API Grid";
            this.btnAPIGrid.UseVisualStyleBackColor = true;
            this.btnAPIGrid.Click += new System.EventHandler(this.btnAPIGrid_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 421);
            this.Controls.Add(this.btnAPIGrid);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnPerformOperation);
            this.Name = "DataGridView";
            this.Text = "DataGridView";
            this.Load += new System.EventHandler(this.DataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerformOperation;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAPIGrid;
    }
}