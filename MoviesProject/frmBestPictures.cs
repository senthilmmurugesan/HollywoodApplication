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
    public partial class frmBestPictures : Form
    {
        private HollywoodLibrary.Movies movie = new HollywoodLibrary.Movies();
        public frmBestPictures()
        {
            InitializeComponent();
        }

        private void frmBestPictures_Load(object sender, EventArgs e)
        {
            try
            {

                dgvBestPictures.DataSource = movie.GetBestPictures();
                lblResult.Text = movie.LastError;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


       
    }
}
