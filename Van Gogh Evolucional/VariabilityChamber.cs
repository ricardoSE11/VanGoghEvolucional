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

        // -PENDIENTE-
        public List<Bitmap> orderByDistance(List<Bitmap> images , int histogramID , int distanceID)
        {
            List<Bitmap> orderedList = new List<Bitmap>();
            prueba(orderedList, metaImage);
            return orderedList;
        }

        public Bitmap imageCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
            Bitmap daughter = null;

            ImageHandler imgHandler = new ImageHandler();
            imageOne = imgHandler.cropAtRectangle(imageOne, 50, 100);
            imageTwo = imgHandler.cropAtRectangle(imageTwo, 50, 100);
            daughter = imgHandler.concatenateBitmaps(imageOne, imageTwo);
            daughter = imgHandler.resizeImage(daughter, 100, 100);
            return daughter;
        }

        public Bitmap mutateImage(Bitmap image , int genesPercentage)
        {
            Bitmap newImage = null;

            int totalGenes = image.Width * image.Height;
            int genesToMutate = totalGenes * (genesPercentage / 100);
            int changedPixels = 0;
            Random rand = new Random();
            Random randTwo = new Random();

            while (changedPixels != genesToMutate)
            {
                int x = randTwo.Next(0, image.Width);
                int y = randTwo.Next(0, image.Height);

                int a = rand.Next(256);
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);

                //Set ARGB value
                newImage.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                changedPixels++;
            }


            return newImage; //mientras tanto
        }

        // -PENDIENTE-
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

        public void prueba(List<Bitmap> images , Bitmap metaImage)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            for (int i = 0; i < images.Count ; i++)
            {
                int distancia = distanceCalculator.intImgManhattanDistance(metaImage, images[i] , 1);
                Console.WriteLine("Imagen: " + i + " - distancia: " + distancia );
            }
        }
    }
}
