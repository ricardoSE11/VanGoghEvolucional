﻿using System;
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
        //Global variables
        ImageHandler imgHandler = new ImageHandler();
        ImageGenerator imgGenerator = new ImageGenerator();
        VariabilityChamber vChamber2 = new VariabilityChamber();

        //Keeps count of the generation 
        int generationCounter = 0;

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
            Bitmap resizedImg = imgHandler.resizeImgWithChoosingQuality((Bitmap)this.picBox_metaImage.Image, 50 , 50 , 1080);
            //Blur metaImage.
            resizedImg = imgHandler.blurFilter(resizedImg, 5);
            //Display the image.
            picBox_generatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_generatedImage.Image = resizedImg;
        }

        private void btn_PremioNobel_Click(object sender, EventArgs e)
        {
            Bitmap randomImage = imgGenerator.generateRandomImage();
            Bitmap loadedImage = (Bitmap)picBox_metaImage.Image;
            Bitmap result = null;

            loadedImage = imgHandler.resizeImage(loadedImage , 640 , 320);
            loadedImage = vChamber2.cropAtRectangle(loadedImage, 320, 160);

            /*for (int i = 0; i < 5; i++)
            {
                result = vChamber2.concatenateBitmaps(loadedImage, randomImage);
                picBox_generatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox_generatedImage.Image = result;
            }*/
            picBox_generatedImage.BackgroundImage = null;
            picBox_generatedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_generatedImage.Image = loadedImage; //randomImage;

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

            List<Bitmap> population = imgGenerator.generateRandomImages(size);
            //List<Bitmap> blurredPopulation = imgHandler.blurImages(population);

            Bitmap metaImage = (Bitmap)picBox_metaImage.Image;
            VariabilityChamber vChamber = new VariabilityChamber(cross, mutation, genes, uglyDucks, population , metaImage);
       
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
