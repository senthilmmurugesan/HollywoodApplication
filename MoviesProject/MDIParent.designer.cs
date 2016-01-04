namespace MoviesProject
{
    partial class MDIParent
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getBestPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.MoviesToolStripMenuItem,
            this.actorsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(610, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MoviesToolStripMenuItem
            // 
            this.MoviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem1,
            this.addNewMovieToolStripMenuItem,
            this.getBestPicturesToolStripMenuItem});
            this.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem";
            this.MoviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.MoviesToolStripMenuItem.Text = "&Movies";
            // 
            // addNewMovieToolStripMenuItem
            // 
            this.addNewMovieToolStripMenuItem.Name = "addNewMovieToolStripMenuItem";
            this.addNewMovieToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewMovieToolStripMenuItem.Text = "Add &New Movie";
            this.addNewMovieToolStripMenuItem.Click += new System.EventHandler(this.addNewMovieToolStripMenuItem_Click);
            // 
            // getBestPicturesToolStripMenuItem
            // 
            this.getBestPicturesToolStripMenuItem.Name = "getBestPicturesToolStripMenuItem";
            this.getBestPicturesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.getBestPicturesToolStripMenuItem.Text = "&Get Best Pictures";
            this.getBestPicturesToolStripMenuItem.Click += new System.EventHandler(this.getBestPicturesToolStripMenuItem_Click);
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allActorsToolStripMenuItem});
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.actorsToolStripMenuItem.Text = "&Actors";
            // 
            // allActorsToolStripMenuItem
            // 
            this.allActorsToolStripMenuItem.Name = "allActorsToolStripMenuItem";
            this.allActorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allActorsToolStripMenuItem.Text = "All A&ctors";
            this.allActorsToolStripMenuItem.Click += new System.EventHandler(this.allActorsToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem1
            // 
            this.moviesToolStripMenuItem1.Name = "moviesToolStripMenuItem1";
            this.moviesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.moviesToolStripMenuItem1.Text = "&Movies";
            this.moviesToolStripMenuItem1.Click += new System.EventHandler(this.moviesToolStripMenuItem1_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 506);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MDIParent";
            this.Text = "Hollywood Movies";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getBestPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allActorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem1;
    }
}