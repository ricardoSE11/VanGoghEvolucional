﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class ImageGenerator
    {
        //Constructor de la clase
        public ImageGenerator() //default
        {
            Console.WriteLine("- Instantiating the Image Generator -");
        }

        //Generates a randomImage
        public Bitmap generateRandomImage()
        {
            int width = 100; //width 
            int height = 100;  //height

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
            //Console.WriteLine("Generating a randomw image.");
            return randomImage;
        }

        public List<Bitmap> generateRandomImages(int amountOfImages)
        {
            //Console.WriteLine("Generating: " + amountOfImages + " images.");
            List<Bitmap> randomImages = new List<Bitmap>();
            for (int i = 0; i < amountOfImages; i++)
            {
                Bitmap actual_Image = generateRandomImage();
                //string nombre = "imagen"+i;
                //actual_Image.Save("c:/Users/Armando/Downloads/Analisis/" + nombre+ ".jpg");
                randomImages.Add(actual_Image);
            }
            //Console.WriteLine(amountOfImages + " images generated.");
            return randomImages;  
        }
    }
}
