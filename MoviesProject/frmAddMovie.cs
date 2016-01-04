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
    public partial class frmAddMovie : Form
    {
        private HollywoodLibrary.Movies movie = new HollywoodLibrary.Movies(); 
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                int id = 0;
                if (!int.TryParse (txtID.Text,out id))
                {
                    MessageBox.Show("Enter a numeric value for the ID", "Error");
                    return;
                }

                if (txtTitle.Text=="" || txtRunningTime.Text=="")
                {
                    MessageBox.Show("Enter values for the title and running time", "Error");
                    return;
                }

                movie.Add(Convert.ToInt32(txtID.Text), txtTitle.Text, Convert.ToInt32(txtRunningTime.Text), dateTimePicker1.Value); 
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
        }

       
        
    }
}
