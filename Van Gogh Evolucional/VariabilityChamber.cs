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
        List<Bitmap> population;
        int cross_prcnt;
        int mutation_prcnt;
        int genes_prcnt;
        int ugly_Ducks;

        //Constructors
        public VariabilityChamber()
        {}

        public VariabilityChamber(int crossPrcnt, int mutationPrcnt, int genesPrcnt, int uglyDucks , List<Bitmap> imgPopulation)
        {
            cross_prcnt = crossPrcnt;
            mutation_prcnt = mutationPrcnt;
            genes_prcnt = genesPrcnt;
            ugly_Ducks = uglyDucks;
            population = imgPopulation;
            Console.WriteLine("Creating a Variability Chamber with the following values: " 
                + "Cross Percentage: " + crossPrcnt + " , " + "Mutation Percentage: " + mutationPrcnt +
                " , " + "Genes Precentage: " + genesPrcnt + " , " + "Ugly ducks: " + uglyDucks);
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
