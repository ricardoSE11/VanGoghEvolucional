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
        int size;
        //Constructors
        public VariabilityChamber()
        {}

        public VariabilityChamber(int tamaño, int crossProb, int mutationProb, int genesPrcnt, int uglyDucks , List<Bitmap> imgPopulation , Bitmap metaImg , int amountC)
        {
            size = tamaño;
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
            List<Bitmap> copyPopulation = new List<Bitmap>();
            for (int i = 0; i < size; i++)
            {
                copyPopulation.Add(images[i]);
            }
            Console.WriteLine(copyPopulation.Count + ": cantidad de padres buenos");
            List<int> distances = new List<int>();
            int index = 0;
            int total = size;
            if (distanceID==1)
            {
                for (int i=0; i< total; i++)
                {
                    distances.Add(distanceCalculator.intImgManhattanDistance(metaImage, copyPopulation[i],histogramID));
                }
            }
            else if (distanceID == 2)
            {
                for (int i = 0; i < total; i++)
                {
                    distances.Add(distanceCalculator.intImgSiONoRazaDistance(metaImage, copyPopulation[i], histogramID));
                }
            }

            for (int x=0;x< 10; x++)
            {
                index = distances.IndexOf(distances.Min());
                Console.WriteLine("Imagen con distancia min"+ distanceID+ " "+ histogramID+" " + x + ":" + distances.Min());
                orderedList.Add(copyPopulation[index]);
                distances.RemoveAt(index);
                copyPopulation.RemoveAt(index);
            }

            return orderedList;
        }

        public List<Bitmap> getUglyDuckImgs(List<Bitmap> images, int histogramID, int distanceID)
        {
            List<Bitmap> copyPopulation = new List<Bitmap>();
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            List<Bitmap> orderedList = new List<Bitmap>();
            for (int i = 0; i < size; i++)
            {
                copyPopulation.Add(images[i]);
            }
            Console.WriteLine(copyPopulation.Count + " :imagenes restantes " + histogramID + " y " + distanceID);
            List<int> distances = new List<int>();

            int index = 0;
            int total = size;
            if (distanceID == 1)
            {
                for (int i = 0; i < total; i++)
                {
                    //Console.WriteLine("Entro aqui con: " + distanceID);
                    distances.Add(distanceCalculator.intImgManhattanDistance(metaImage, copyPopulation[i], histogramID));
                }
            }
            else if (distanceID == 2)
            {
                for (int i = 0; i < total; i++)
                {
                    //Console.WriteLine("Entro aqui con: " + distanceID);
                    distances.Add(distanceCalculator.intImgSiONoRazaDistance(metaImage, copyPopulation[i], histogramID));
                }
            }

            for (int x = 0; x < ugly_Ducks; x++)
            {
                index = distances.IndexOf(distances.Max());
                Console.WriteLine("Imagen con distancia max" + distanceID + " " + histogramID + " " + x + ":" + distances.Max());
                orderedList.Add(copyPopulation[index]);
                distances.RemoveAt(index);
                copyPopulation.RemoveAt(index);
            }

            return orderedList;
        }

        public Bitmap imageCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
            Bitmap daughter = new Bitmap(imageOne.Width, imageOne.Height); ;

            ImageHandler imgHandler = new ImageHandler();
            Random rand = new Random();
            for (int i=0;i < imageOne.Width;i++)
            {
                for (int j = 0; j < imageOne.Width; j++)
                {
                    if(imageOne.GetPixel(i,j).Equals(metaImage.GetPixel(i,j)))
                    {
                        //Console.WriteLine("Igual a la una");
                        int a = imageOne.GetPixel(i, j).A;
                        int r = imageOne.GetPixel(i, j).R;
                        int g = imageOne.GetPixel(i, j).G;
                        int b = imageOne.GetPixel(i, j).B;
                        daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    if (imageTwo.GetPixel(i, j).Equals(metaImage.GetPixel(i, j)))
                    {
                        //Console.WriteLine("Igual a la dos");
                        int a = imageTwo.GetPixel(i, j).A;
                        int r = imageTwo.GetPixel(i, j).R;
                        int g = imageTwo.GetPixel(i, j).G;
                        int b = imageTwo.GetPixel(i, j).B;
                        daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    else
                    {
                        //Console.WriteLine("ni merga");
                        int c = rand.Next(0,2);
                        if(c==1)
                        {
                            int a = imageOne.GetPixel(i, j).A;
                            int r = imageOne.GetPixel(i, j).R;
                            int g = imageOne.GetPixel(i, j).G;
                            int b = imageOne.GetPixel(i, j).B;
                            daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                        }
                        else
                        {
                            int a = imageTwo.GetPixel(i, j).A;
                            int r = imageTwo.GetPixel(i, j).R;
                            int g = imageTwo.GetPixel(i, j).G;
                            int b = imageTwo.GetPixel(i, j).B;
                            daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                        }
                    }
                }
            }
            //imageOne = imgHandler.cropAtRectangle(imageOne, 50, 100);
            //imageTwo = imgHandler.cropAtRectangle(imageTwo, 50, 100);
            //daughter = imgHandler.concatenateBitmaps(imageOne, imageTwo);
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
        public void paintImage(int histogramID , int distanceID, List<Bitmap> population,int cont)
        {
            //Console.WriteLine("ENTRE A PAINT IMAGE");
            //Console.WriteLine("Tamano: " + population.Count);
            List<Bitmap> bestParents = null;

            //Console.WriteLine("Tamano: " + population.Count);
            List<Bitmap> uglyDucks = null;
            List<Bitmap> newGeneration = null;

            //Soy un pendejo
            Random randomGenerator = new Random();

            if (cont < amount)
            {
                bestParents = getTheFittestImgs(population, histogramID, distanceID);
                uglyDucks = getUglyDuckImgs(population, histogramID, distanceID);
                newGeneration = new List<Bitmap>();
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
                        int luckyParent = randomGenerator.Next(0, bestParents.Count);
                        Bitmap currentDaughter = imageCross(bestParents[i], uglyDucks[luckyDuck]);
                        string nombre = "imagen_" + i + "pobl_" + cont;
                        //currentDaughter.Save("e:/Users/rshum/Pictures/VanGoghEvolucional/MasAptos/" + nombre + ".jpg");
                        currentDaughter.Save("c:/Users/Armando/Downloads/Analisis/Mejores/" + nombre + ".jpg");
                        newGeneration.Add(currentDaughter);
                    }
                }


                //Survivors
                while (newGeneration.Count < size)
                {
                        for (int j = 0; j < uglyDucks.Count; j++)
                    {
                        newGeneration.Add(uglyDucks[j]);
                    }
                }

                //Mutation
                while (newGeneration.Count < size)
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
                cont++;
                paintImage(histogramID,distanceID,newGeneration,cont);
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
