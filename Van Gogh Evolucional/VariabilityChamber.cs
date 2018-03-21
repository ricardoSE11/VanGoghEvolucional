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
        DistanceCalculator distanceCalculator; 
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
            distanceCalculator = new DistanceCalculator();
            Console.WriteLine("Creating a Variability Chamber with the following values: " 
                + "Cross Percentage: " + crossPrcnt + " , " + "Mutation Percentage: " + mutationPrcnt +
                " , " + "Genes Precentage: " + genesPrcnt + " , " + "Ugly ducks: " + uglyDucks);
        }

        public List<Bitmap> orderByDistance(List<Bitmap> images , int histogramID , int distanceID)
        {
            List<Bitmap> orderedList = new List<Bitmap>();

            for (int i = 0; i < images.Count; i++)
            {
                Bitmap currentImage = images[i];
                if (orderedList.Count == 0)
                    orderedList.Add(images[i]);

                else
                {
                    //Distancia Manhattan
                    if (distanceID == 1)
                    {
                        for (int j = 0; j < orderedList.Count; j++)
                        {
                            int currentDistance = distanceCalculator.intImgManhattanDistance(metaImage, images[i], histogramID);
                            int comparingDistance = distanceCalculator.intImgManhattanDistance(metaImage, orderedList[j], histogramID);
                            int lastDistance = distanceCalculator.intImgManhattanDistance(metaImage, orderedList[orderedList.Count - 1], histogramID);

                            if (currentDistance <= comparingDistance)
                                orderedList.Insert(orderedList.IndexOf(orderedList[j]), images[i]);

                            if (currentDistance > lastDistance)
                                orderedList.Add(images[i]);
                        }
                    }

                    //Distancia Si O No Raza
                    else
                    {
                        for (int j = 0; j < orderedList.Count; j++)
                        {
                            int currentDistance = distanceCalculator.intImgSiONoRazaDistance(metaImage, images[i], histogramID);
                            int comparingDistance = distanceCalculator.intImgSiONoRazaDistance(metaImage, orderedList[j], histogramID);
                            int lastDistance = distanceCalculator.intImgSiONoRazaDistance(metaImage, orderedList[orderedList.Count - 1], histogramID);

                            if (currentDistance <= comparingDistance)
                                orderedList.Insert(orderedList.IndexOf(orderedList[j]), images[i]);

                            if (currentDistance > lastDistance)
                                orderedList.Add(images[i]);
                        }
                    }
                    
                }
            }
            prueba(orderedList, metaImage);
            return orderedList;
        }

        // -PENDIENTE-
        public Bitmap imageCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
            return imageOne; //mientras tanto
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

        public void prueba(List<Bitmap> images , Bitmap metaImage)
        {
            for (int i = 0; i < 10; i++)
            {
                int distancia = distanceCalculator.intImgManhattanDistance(metaImage, images[i] , 1);
                Console.WriteLine("Imagen: " + i + " - distancia: " + distancia );
            }
        }
    }
}
