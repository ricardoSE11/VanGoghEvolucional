using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;

namespace Van_Gogh_Evolucional
{
    public partial class form_MainWindow : Form
    {
        //Global variables
        ImageHandler imgHandler = new ImageHandler();
        ImageGenerator imgGenerator = new ImageGenerator();
        

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
            Bitmap resizedImg = imgHandler.resizeImgWithChoosingQuality((Bitmap)this.picBox_metaImage.Image, 100 , 100 , 1080);
            //Blur metaImage.
            resizedImg = imgHandler.blurFilter(resizedImg, 5);
            
        }

        private void btn_PremioNobel_Click(object sender, EventArgs e)
        {
            Bitmap randomImage = imgGenerator.generateRandomImage();
            Bitmap loadedImage = (Bitmap)picBox_metaImage.Image;

            Bitmap result = null;

            loadedImage = imgHandler.resizeImage(loadedImage , 100 , 100);
            loadedImage = imgHandler.cropAtRectangle(loadedImage, 50, 100);
            randomImage = imgHandler.cropAtRectangle(randomImage, 50, 100);
            result = imgHandler.concatenateBitmaps(randomImage, loadedImage);
            result = imgHandler.resizeImage(result, 100, 100);
            

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            picBox_metaImage.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_size_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validateFields()
        {
            bool ok=true;
            if (txtbox_size.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtbox_size, "Enter the size");
            }
            if (txtb_amount.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtb_amount, "Enter the amount");
            }
            if (txtb_cross.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtb_cross, "Enter the cross");
            }
            if (txtb_genes.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtb_genes, "Enter the genes");
            }
            if (txtb_mutation.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtb_mutation, "Enter the mutation");
            }
            if (txtb_uducks.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtb_uducks, "Enter the ugly ducks");
            }

            return ok;
        }

        private void eraseErrorMessages()
        {
            errorProvider1.SetError(txtbox_size, "");
            errorProvider1.SetError(txtb_amount, "");
            errorProvider1.SetError(txtb_cross, "");
            errorProvider1.SetError(txtb_genes, "");
            errorProvider1.SetError(txtb_mutation, "");
            errorProvider1.SetError(txtb_uducks, "");
        }

        private void generate()
        {
            //Generation parameters.
            int size = int.Parse(txtbox_size.Text);
            int amount = int.Parse(txtb_amount.Text);
            int cross = int.Parse(txtb_cross.Text);
            int genes = int.Parse(txtb_genes.Text);
            int mutation = int.Parse(txtb_mutation.Text);
            int uglyDucks = int.Parse(txtb_uducks.Text);
            List<Bitmap> population = imgGenerator.generateRandomImages(size);
            //List<Bitmap> blurredPopulation = imgHandler.blurImages(population);
            Bitmap metaImage = (Bitmap)picBox_metaImage.Image;
            metaImage = imgHandler.resizeImage(metaImage , 100 , 100);
            VariabilityChamber vChamber = new VariabilityChamber(size,cross, mutation, genes, uglyDucks, population, metaImage , amount);
            if (ckBoxColorHistogram.Checked)
            {
                if (ckBoxManhattan.Checked)
                {
                    //vChamber.getBestAndWorstImgs(population,1,1);
                    vChamber.paintImage(1, 1,population,0 , size);
                    
                }
                else
                {
                    //vChamber.getBestAndWorstImgs(population, 1, 2);
                    vChamber.paintImage(1, 2,population,0 , size);
                }
            }
            if(ckBoxLBPHistogram.Checked)
            {
                if (ckBoxManhattan.Checked)
                {
                    //vChamber.getBestAndWorstImgs(population, 2, 1);
                    vChamber.paintImage(2, 1, population, 0 , size);
                }
                else
                {
                    //vChamber.getBestAndWorstImgs(population, 2, 2);
                    vChamber.paintImage(2, 2, population, 0 , size);
                }
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            eraseErrorMessages();
            if (validateFields())
            {
                
                //generate();
                Thread thread = new Thread(generate);
                thread.Start();
            }
            
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckBoxLBPHistogram_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void grafico_Click(object sender, EventArgs e)
        {

        }

        private void ckBoxColorHistogram_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
