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
        int cross_prob;
        int mutation_prob;
        int genes_prcnt;
        int ugly_Ducks;
        int amount;
        //Constructors
        public VariabilityChamber()
        {}

        public VariabilityChamber(int crossProb, int mutationProb, int genesPrcnt, int uglyDucks , List<Bitmap> imgPopulation , Bitmap metaImg , int amountC)
        {
            cross_prob = crossProb;
            mutation_prob = mutationProb;
            genes_prcnt = genesPrcnt;
            ugly_Ducks = uglyDucks;
            population = imgPopulation;
            metaImage = metaImg;
            amount = amountC;
            Console.WriteLine("Creating a Variability Chamber with the following values: " 
                + "Cross Percentage: " + crossProb + " , " + "Mutation Percentage: " + mutationProb +
                " , " + "Genes Precentage: " + genesPrcnt + " , " + "Ugly ducks: " + uglyDucks);
        }

        //10 mejores imagenes
        public List<Bitmap> getTheFittestImgs(List<Bitmap> images , int histogramID , int distanceID)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            List<Bitmap> orderedList = new List<Bitmap>();

            List<int> distances = new List<int>();
            int index = 0;
            int total = images.Count;
            if (distanceID==1)
            {
                for (int i=0; i< total; i++)
                {
                    distances.Add(distanceCalculator.intImgManhattanDistance(metaImage,images[i],histogramID));
                }
            }
            else if (distanceID == 2)
            {
                for (int i = 0; i < total; i++)
                {
                    distances.Add(distanceCalculator.intImgSiONoRazaDistance(metaImage, images[i], histogramID));
                }
            }

            for (int x=0;x< 10; x++)
            {
                index = distances.IndexOf(distances.Min());
                Console.WriteLine("Imagen con distancia "+ distanceID+ " "+ histogramID+" " + x + ":" + distances.Min());
                orderedList.Add(images[index]);
                distances.RemoveAt(index);
                images.RemoveAt(index);
            }

            return orderedList;
        }

        public List<Bitmap> getUglyDuckImgs(List<Bitmap> images, int histogramID, int distanceID)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            List<Bitmap> orderedList = new List<Bitmap>();

            List<int> distances = new List<int>();
            int index = 0;
            int total = images.Count;
            if (distanceID == 1)
            {
                for (int i = 0; i < total; i++)
                {
                    distances.Add(distanceCalculator.intImgManhattanDistance(metaImage, images[i], histogramID));
                }
            }
            else if (distanceID == 2)
            {
                for (int i = 0; i < total; i++)
                {
                    distances.Add(distanceCalculator.intImgSiONoRazaDistance(metaImage, images[i], histogramID));
                }
            }

            for (int x = 0; x < ugly_Ducks; x++)
            {
                index = distances.IndexOf(distances.Max());
                Console.WriteLine("Imagen con distancia " + distanceID + " " + histogramID + " " + x + ":" + distances.Max());
                orderedList.Add(images[index]);
                distances.RemoveAt(index);
                images.RemoveAt(index);
            }

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
        public void paintImage(int histogramID , int distanceID)
        {
            List<Bitmap> bestParents = getTheFittestImgs(population, histogramID, distanceID);
            List<Bitmap> uglyDucks = getUglyDuckImgs(population, histogramID, distanceID);
            List<Bitmap> newGeneration = new List<Bitmap>();

            Random randomGenerator = new Random();

            for (int g = 0; g < amount; g++)
            {
                //Random numbers to determine variability factors
                int rCrossingProb = randomGenerator.Next(0, 100);
                int rMutationProb = randomGenerator.Next(0, 100);
                int rGenesPrcnt = randomGenerator.Next(0, 100);

                //Cross
                if (rCrossingProb >= cross_prob)
                {
                    for (int i = 0; i < bestParents.Count; i++)
                    {
                        int luckyDuck = randomGenerator.Next(0, uglyDucks.Count);
                        Bitmap currentDaughter = imageCross(bestParents[i], uglyDucks[luckyDuck]);
                        newGeneration.Add(currentDaughter);
                    }
                }

                //Survivors
                for (int j = 0; j < uglyDucks.Count; j++)
                {
                    newGeneration.Add(uglyDucks[j]);
                }

                //Mutation
                while (newGeneration.Count < population.Count)
                {
                    if (rMutationProb >= mutation_prob)
                    {
                        int luckyDude = randomGenerator.Next(0, population.Count);
                        newGeneration.Add(mutateImage(population[luckyDude] , genes_prcnt));
                    }

                    else
                    {
                        int luckyDude = randomGenerator.Next(0, population.Count);
                        newGeneration.Add(population[luckyDude]);
                    }
                }


            }



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
