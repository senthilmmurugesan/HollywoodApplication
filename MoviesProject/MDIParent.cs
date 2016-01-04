using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MoviesProject
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMovie childform = new frmAddMovie();
            childform.MdiParent = this;
            childform.Show();
        }

        private void getBestPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBestPictures childform = new frmBestPictures();
            childform.MdiParent = this;
            childform.Show();
        }

        private void allActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActors childform = new frmActors();
            childform.MdiParent = this;
            childform.Show();
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMovies childform = new frmMovies();
            childform.MdiParent = this;
            childform.Show();
        }

    }
}
