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
        int cross_prcnt;
        int mutation_prcnt;
        int genes_prcnt;
        int ugly_Ducks;

        //Constructors
        VariabilityChamber()
        {}

        VariabilityChamber(int crossPrcnt, int mutationPrcnt, int genesPrcnt, int uglyDucks)
        {
            cross_prcnt = crossPrcnt;
            mutation_prcnt = mutationPrcnt;
            genes_prcnt = genesPrcnt;
            ugly_Ducks = uglyDucks;
            Console.WriteLine("Creating a Variability Chamber with the following values: " 
                + "Cross Percentage: " + crossPrcnt + " , " + "Mutation Percentage: " + mutationPrcnt +
                " , " + "Genes Precentage: " + genesPrcnt + " , " + "Ugly ducks: " + uglyDucks);
        }

        public void binaryCross(Bitmap imageOne , Bitmap imageTwo)
        {
            //Lógica implacable de cruce
        }
    }
}
