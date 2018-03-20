using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class VariabilityChamber
    {
        //Atributes
        Bitmap metaImage;
        List<Bitmap> population;
        int cross_prcnt;
        int mutation_prcnt;
        int genes_prcnt;
        int ugly_Ducks;

        //Constructors
        public VariabilityChamber()
        {}

        public VariabilityChamber(int crossPrcnt, int mutationPrcnt, int genesPrcnt, int uglyDucks , List<Bitmap> imgPopulation , Bitmap metaImg)
        {
            cross_prcnt = crossPrcnt;
            mutation_prcnt = mutationPrcnt;
            genes_prcnt = genesPrcnt;
            ugly_Ducks = uglyDucks;
            population = imgPopulation;
            metaImage = metaImg;
            Console.WriteLine("Creating a Variability Chamber with the following values: " 
                + "Cross Percentage: " + crossPrcnt + " , " + "Mutation Percentage: " + mutationPrcnt +
                " , " + "Genes Precentage: " + genesPrcnt + " , " + "Ugly ducks: " + uglyDucks);
        }

        public List<Bitmap> orderByManhattanDistance(List<Bitmap> images)
        {
            List<Bitmap> orderedList = new List<Bitmap>();
            DistanceCalculator distanceCalculator = new DistanceCalculator();

            for (int i = 0; i < images.Count; i++)
            {
                Bitmap currentImage = images[i];
                if (orderedList.Count == 0)
                    orderedList.Add(images[i]);

                else
                {
                    for (int j = 0; j < orderedList.Count; j++)
                    {
                        int currentDistance = distanceCalculator.intImgManhattanDistance(metaImage, images[i]);
                        int comparingDistance = distanceCalculator.intImgManhattanDistance(metaImage, orderedList[j]);
                        int lastDistance = distanceCalculator.intImgManhattanDistance(metaImage, orderedList[orderedList.Count - 1]);

                        if (currentDistance <= comparingDistance)
                            orderedList.Insert(orderedList.IndexOf(orderedList[j]), images[i]);

                        if (currentDistance > lastDistance)
                            orderedList.Add(images[i]);
                    }
                    
                }
            }
            return orderedList;
        }

        // -PENDIENTE-
        public Bitmap imageCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
            return imageOne; //mientras tanto
        }

        public Bitmap concatenateBitmaps(Bitmap imgOne, Bitmap imgTwo)
        {
            //read all images into memory
            List<Bitmap> images = new List<Bitmap>();
            images.Add(imgTwo);
            images.Add(imgOne);
            Bitmap finalImage = null;

            int width = imgOne.Width * 2;
            int height = imgOne.Height ;

            //create a bitmap to hold the combined image
            finalImage = new Bitmap(width, height);

            //get a graphics object from the image so we can draw on it
            using (Graphics g = Graphics.FromImage(finalImage))

            {
                //set background color
                g.Clear(Color.Black);

                //go through each image and draw it on the final image
                int offset = 0;
                foreach (Bitmap image in images)
                {
                    g.DrawImage(image,
                        new Rectangle(offset, 0, image.Width, image.Height));
                    offset += image.Width;
                }
            }
            if (finalImage.Equals(null))
                Console.WriteLine("Ya llegué aquí: " + finalImage.ToString());

            return finalImage;
        }

        public Bitmap cropAtRectangle(Bitmap b, int width , int height)
        {
            Rectangle r = new Rectangle(0, 0, width, height);
            Bitmap nb = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(nb);
            g.DrawImage(b, -r.X, -r.Y);
            return nb;
        }

        // -PENDIENTE-
        public Bitmap imageMutation(Bitmap image , int genesPercentage)
        {
            //Lógica implacable de mutación

            return image; //mientras tanto
        }

        public void paintImage()
        {
            /*Aquí va:
              - La transición de las generaciones
              - Las función de la mutación con un random que decide si hay que mutar o no (y % de genes a mutar)
              - La función de cruce con un random que decide si hay que cruzar o no
              - Patitos feos que tienen que pasar a la siguiente generación para ser cruzados.
                    + El cruce, creo que yo, que puede ser aleatorio. Ya que, la distancia es que nos va a asegurar
                    que los mejores individuos vayan pasando a la siguiente generación.*/
        }
    }
}
