using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class HistogramCalculator
    {
        VectorCalculator colorVectorCalculator; 
        //Contructor 
        public HistogramCalculator()
        {
            colorVectorCalculator = new VectorCalculator();
            Console.WriteLine("- Instatiating a Histrogram Calculator -");
        }

        //Format:  List[0] = R | List[1] = G | List[2] = B
        public List<int[]> getColorHistogram(Bitmap image)
        {
            List<int[]> colorHistogram = new List<int[]>();
            //Calculating vectors
            int[] redVector = colorVectorCalculator.redVector(image);
            int[] greenVector = colorVectorCalculator.greenVector(image);
            int[] blueVector = colorVectorCalculator.blueVector(image);
            //Adding vectors to histogram
            colorHistogram.Add(redVector);
            colorHistogram.Add(greenVector);
            colorHistogram.Add(blueVector);

            Console.WriteLine("Calculated ColorHistogram");
            return colorHistogram;
        }

    }

}
