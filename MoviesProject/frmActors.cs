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
    public partial class frmActors : Form
    {
        HollywoodLibrary.Actors actors = new HollywoodLibrary.Actors();
       
        public frmActors()
        {
            InitializeComponent();
         
        }

        private void frmActors_Load(object sender, EventArgs e)
        {
            try
            {
                dgvActors.DataSource = actors.GetAllActors();
                lblResult.Text = actors.LastError;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
