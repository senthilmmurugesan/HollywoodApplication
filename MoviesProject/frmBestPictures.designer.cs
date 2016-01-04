namespace MoviesProject
{
    partial class frmBestPictures
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBestPictures = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best Pictures for Each Year";
            // 
            // dgvBestPictures
            // 
            this.dgvBestPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestPictures.Location = new System.Drawing.Point(23, 54);
            this.dgvBestPictures.Name = "dgvBestPictures";
            this.dgvBestPictures.Size = new System.Drawing.Size(459, 198);
            this.dgvBestPictures.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(20, 262);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(462, 43);
            this.lblResult.TabIndex = 2;
            // 
            // frmBestPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 314);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvBestPictures);
            this.Controls.Add(this.label1);
            this.Name = "frmBestPictures";
            this.Text = "Best Pictures";
            this.Load += new System.EventHandler(this.frmBestPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBestPictures;
        private System.Windows.Forms.Label lblResult;
    }
}