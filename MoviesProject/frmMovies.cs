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
    public partial class frmMovies : Form
    {
        public int MovieId;
        public frmMovies()
        {
            InitializeComponent();
        }

        private void btnFindMovie_Click(object sender, EventArgs e)
        {
            if (int.TryParse (txtMovieID.Text, out MovieId))
            {
                try
                {
                    HollywoodLibrary.Movies movie = new HollywoodLibrary.Movies();
                    dgvActors.DataSource = movie.GetActors(Convert.ToInt32(txtMovieID.Text));
                    lblResult.Text = movie.LastError;
                }
                catch (Exception ex)
                {
                    lblResult.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Enter numeric data for the movie id", "Error");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            HollywoodLibrary.Movies movie = new HollywoodLibrary.Movies();
            lblCount.Text = "There are " + movie.GetCount().ToString() + " movies in the database";
        }

      
              
    }
}
