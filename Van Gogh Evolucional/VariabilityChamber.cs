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

                        if (currentDistance < comparingDistance)
                            orderedList.Insert(orderedList.IndexOf(orderedList[j]), images[i]);

                        if (currentDistance > lastDistance)
                            orderedList.Add(images[i]);
                    }
                    
                }
            }
            return orderedList;
        }

        public Bitmap imageCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
            return imageOne; //mientras tanto
        }

        public Bitmap imageMutation(Bitmap imageOne, Bitmap imageTwo)
        {
            //Lógica implacable de mutación
            return imageOne; //mientras tanto
        }
    }
}
