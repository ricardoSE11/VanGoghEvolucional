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
            //Resized image placed here to check functionality.
            ImageHandler imgProcessor = new ImageHandler();
            Bitmap resizedImg = imgProcessor.resizeImgWithChoosingQuality((Bitmap)this.picBox_metaImage.Image, 640 , 320 , 1080);
            resizedImg = imgProcessor.blurFilter(resizedImg, 5);
            picBox_generatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_generatedImage.Image = resizedImg;
        }

        private void btn_PremioNobel_Click(object sender, EventArgs e)
        {
            int width = 640; //width 
            int height = 320;  //height

            //Bitmap
            Bitmap randomImage = new Bitmap(width, height);
            //Random number
            Random rand = new Random();
            
            //Create random pixels
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //Create random ARGB values
                    int a = rand.Next(256);
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);

                    //Set ARGB value
                    randomImage.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }//end of For

            this.picBox_generatedImage.BackgroundImage = null;
            this.picBox_generatedImage.Image = randomImage;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.picBox_metaImage.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            //Generation parameters.
            int size = int.Parse(txtbox_size.Text);
            int amount = int.Parse(txtb_amount.Text);
            int cross = int.Parse(txtb_cross.Text);
            int genes = int.Parse(txtb_genes.Text);
            int mutation = int.Parse(txtb_mutation.Text);
            int uglyDucks = int.Parse(txtb_uducks.Text);

            ImageGenerator imgGenerator = new ImageGenerator();
            List<Bitmap> population = imgGenerator.generateRandomImages(size);
            VariabilityChamber vChamber = new VariabilityChamber(cross, mutation, genes, uglyDucks, population);


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
