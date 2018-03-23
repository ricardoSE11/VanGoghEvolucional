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
        public List<List<Bitmap>> getBestAndWorstImgs(List<Bitmap> images , int histogramID , int distanceID)
        {
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            List<List<Bitmap>> orderedList = new List<List<Bitmap>>();
            List<Bitmap> orderedListMin = new List<Bitmap>();
            List<Bitmap> orderedListMax = new List<Bitmap>();
            List<Bitmap> copyPopulation = new List<Bitmap>();
            //Console.WriteLine("SI LLEGO LA POBLACION " + images.Count);
            for (int i = 0; i < size; i++)
            {
                copyPopulation.Add(images[i]);
            }
            //Console.WriteLine("SI LE METIO A LA VARIABLE COPYPOPULATION " + copyPopulation.Count);
            List<int> distances = new List<int>();
            int index = 0;
            int total = size;
            if (distanceID==1)
            {
                //Console.WriteLine(" Prueba 305454 "+copyPopulation[0].ToString());
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
                orderedListMin.Add(copyPopulation[index]);
                distances.RemoveAt(index);
                copyPopulation.RemoveAt(index);
            }
            Console.WriteLine("========================================================");
            for (int x = 0; x < ugly_Ducks; x++)
            {
                index = distances.IndexOf(distances.Max());
                Console.WriteLine("Imagen con distancia max" + distanceID + " " + histogramID + " " + x + ":" + distances.Max());
                orderedListMax.Add(copyPopulation[index]);
                distances.RemoveAt(index);
                copyPopulation.RemoveAt(index);
            }

            orderedList.Add(orderedListMin);
            orderedList.Add(orderedListMax);
            return orderedList;
        }

        //Codes: Red[R] - Green[G] - Blue[B]  
        public int bestColor(Bitmap imageOne, Bitmap imageTwo, String colorCode,int i, int j)
        {

            //ALPHA
            if (colorCode == "A")
            {
                int metaPixel = metaImage.GetPixel(i, j).A;
                int pixelOne = imageOne.GetPixel(i, j).A;
                int pixelTwo = imageTwo.GetPixel(i, j).A;

                if (Math.Abs(metaPixel - pixelOne) < Math.Abs(metaPixel - pixelTwo))
                {
                    return pixelOne;
                }
                else
                {
                    return pixelTwo;
                }

            }
            //Red
            if (colorCode == "R")
            {
                int metaPixel = metaImage.GetPixel(i, j).R;
                int pixelOne = imageOne.GetPixel(i, j).R;
                int pixelTwo = imageTwo.GetPixel(i, j).R;

                if (Math.Abs(metaPixel - pixelOne) < Math.Abs(metaPixel - pixelTwo))
                {
                    return pixelOne;
                }
                else
                {
                    return pixelTwo;
                }
                    
            }

            //Green
            if (colorCode == "G")
            {
                int metaPixel = metaImage.GetPixel(i, j).G;
                int pixelOne = imageOne.GetPixel(i, j).G;
                int pixelTwo = imageTwo.GetPixel(i, j).G;

                if (Math.Abs(metaPixel - pixelOne) < Math.Abs(metaPixel - pixelTwo))
                {
                    return pixelOne;
                }
                else
                {
                    return pixelTwo;
                }
            }

            //Blue
            if (colorCode == "B")
            {
                int metaPixel = metaImage.GetPixel(i, j).B;
                int pixelOne = imageOne.GetPixel(i, j).B;
                int pixelTwo = imageTwo.GetPixel(i, j).B;

                if (Math.Abs(metaPixel - pixelOne) < Math.Abs(metaPixel - pixelTwo))
                {
                    return pixelOne;
                }
                else
                {
                    return pixelTwo;
                }
            }
            return 0;
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
                    int prob = rand.Next(0, 255);
                    if (prob<=10)
                    {
                        int a = rand.Next(256);//bestColor(imageOne, imageTwo, "A", i, j);
                        int r = bestColor(imageOne, imageTwo, "R", i, j);
                        int g = bestColor(imageOne, imageTwo, "G", i, j);
                        int b = bestColor(imageOne, imageTwo, "B", i, j);

                        daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                    }
                    else
                    {
                        int metaPixel = metaImage.GetPixel(i, j).R + metaImage.GetPixel(i, j).G + metaImage.GetPixel(i, j).B;
                        int pixelOne = imageOne.GetPixel(i, j).R + imageOne.GetPixel(i, j).G + imageOne.GetPixel(i, j).B;
                        int pixelTwo = imageTwo.GetPixel(i, j).R + imageTwo.GetPixel(i, j).G + imageTwo.GetPixel(i, j).B;

                        if (Math.Abs(metaPixel - pixelOne) < Math.Abs(metaPixel - pixelTwo))
                        {
                            int a = rand.Next(256);
                            int r = imageOne.GetPixel(i, j).R; 
                            int g = imageOne.GetPixel(i, j).G;
                            int b = imageOne.GetPixel(i, j).B;
                            daughter.SetPixel(i, j, Color.FromArgb(a, r, g, b));
                        }
                        else
                        {
                            int a = rand.Next(256);
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
            //daughter = imgHandler.resizeImage(daughter, 100, 100);
            return daughter;
        }

        public Bitmap mutateImage(Bitmap image, int genesPercentage)
        {
            Bitmap newImage = image;

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
            Console.WriteLine("Generacion " + cont);
            Console.WriteLine("Poblacion entrante "+ population.Count);
            List<Bitmap> bestParents = null;
            List<Bitmap> uglyDucks = null;
            List<Bitmap> newGeneration = null;
            Random randomGenerator = new Random();
            if (cont < amount)
            {
                List<List<Bitmap>> bestAndWorstImgs= getBestAndWorstImgs(population, histogramID, distanceID);
                bestParents = bestAndWorstImgs[0];
                Console.WriteLine("Hizo los mas pros  " + bestParents.Count);
                uglyDucks = bestAndWorstImgs[1];
                Console.WriteLine("Hizo los mas noobs  " + uglyDucks.Count);

                newGeneration = new List<Bitmap>();
                for (int i = 0; i < bestParents.Count; i++)
                {
                    string nombre = "imagen_" + i + "_pobl_" + cont;
                    bestParents[i].Save("e:/Analisis de Algoritmos/Pruebas/" + nombre + ".jpg");
                }
                for (int i = 0; i < uglyDucks.Count; i++)
                {
                    newGeneration.Add(uglyDucks[i]);
                }

                while (newGeneration.Count < size)
                {
                    //Random numbers to determine variability factors
                    int rCrossingProb = randomGenerator.Next(0, 100);
                    int rMutationProb = randomGenerator.Next(0, 100);
                    int rGenesPrcnt = randomGenerator.Next(0, 100);
                    int random = randomGenerator.Next(0, size);

                    //Cross
                    if (rCrossingProb >= cross_prob)
                    {
                        Console.WriteLine("Cruce rikolino");
                        int luckyDuck = randomGenerator.Next(0, population.Count);
                        int luckyParent = randomGenerator.Next(0, population.Count);
                        Bitmap currentDaughter = imageCross(population[luckyParent], population[luckyDuck]);
                        //string nombre = "imagen_" + contImg + "_pobl_" + cont;
                        //currentDaughter.Save("e:/Users/rshum/Pictures/VanGoghEvolucional/MasAptos/" + nombre + ".jpg");
                        //currentDaughter.Save("e:/Users/Armando/Downloads/Analisis/Mejores/" + nombre + ".jpg");
                        //currentDaughter.Save("e:/Analisis de Algoritmos/Pruebas/" + nombre + ".jpg");
                        newGeneration.Add(currentDaughter);
                    }
                    if (newGeneration.Count < size)
                    {
                        //Mutation
                        if (rMutationProb <= mutation_prob)
                        {
                            int luckyDude = randomGenerator.Next(0, population.Count);
                            newGeneration.Add(mutateImage(population[luckyDude], genes_prcnt));

                        }
                        if (newGeneration.Count < size)
                        {
                            //Survivors
                            newGeneration.Add(population[random]);
                        }
                    }
                }
                Console.WriteLine("Salio con una nueva generacion de "+newGeneration.Count);
                Console.WriteLine("==============================================================================================================");
                cont++;
                paintImage(histogramID,distanceID, newGeneration, cont);
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
