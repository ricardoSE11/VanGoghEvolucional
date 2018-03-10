using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Van_Gogh_Evolucional
{
    public partial class form_MainWindow : Form
    {
        public form_MainWindow()
        {
            InitializeComponent();
        }

        private void btn_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg,*.png|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                //picBox_metaImage.BackgroundImage.Dispose();
                this.picBox_metaImage.Image = new Bitmap(ofile.FileName);
            }

        }

        private void form_MainWindow_Load(object sender, EventArgs e)
        {

        }

        /*private void btn_Cancel(object sender, EventArgs e)
        {
            this.picBox_metaImage.Image = null;
        }*/

        private void btn_Manhattan_Click(object sender, EventArgs e)
        {

        }

        private void btn_PremioNobel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.picBox_metaImage.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
