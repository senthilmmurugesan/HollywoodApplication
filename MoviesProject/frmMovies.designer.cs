namespace MoviesProject
{
    partial class frmMovies
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
            this.btnFindMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindMovie
            // 
            this.btnFindMovie.Location = new System.Drawing.Point(369, 46);
            this.btnFindMovie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindMovie.Name = "btnFindMovie";
            this.btnFindMovie.Size = new System.Drawing.Size(216, 33);
            this.btnFindMovie.TabIndex = 0;
            this.btnFindMovie.Text = "&Show actors in this movie";
            this.btnFindMovie.UseVisualStyleBackColor = true;
            this.btnFindMovie.Click += new System.EventHandler(this.btnFindMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie ID:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(139, 50);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(132, 22);
            this.txtMovieID.TabIndex = 2;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(48, 331);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(157, 28);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count of Movies";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(48, 96);
            this.dgvActors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(537, 171);
            this.dgvActors.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(213, 331);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(372, 28);
            this.lblCount.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(44, 290);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(541, 28);
            this.lblResult.TabIndex = 6;
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 398);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvActors);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindMovie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblResult;
    }
}

