namespace MoviesProject
{
    partial class frmActors
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
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(16, 31);
            this.dgvActors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(589, 279);
            this.dgvActors.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(16, 326);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(589, 28);
            this.lblResult.TabIndex = 1;
            // 
            // frmActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 364);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvActors);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmActors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmActors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Label lblResult;
    }
}