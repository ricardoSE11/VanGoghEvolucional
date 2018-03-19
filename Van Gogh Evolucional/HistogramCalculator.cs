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
        ColorVectorCalculator colorVectorCalculator; 
        //Contructor 
        public HistogramCalculator()
        {
            colorVectorCalculator = new ColorVectorCalculator();
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

            return colorHistogram;
        }

        public List<int[]> getCCVColorHistogram(Bitmap image)
        {
            List<int[]> ccvColorHistogram = new List<int[]>();
            //Calculating vectors
            int[] redVector = colorVectorCalculator.redVectorForCCV(image);
            int[] greenVector = colorVectorCalculator.greenVectorForCCV(image);
            int[] blueVector = colorVectorCalculator.blueVectorForCCV(image);
            //Adding vectors to histogram
            ccvColorHistogram.Add(redVector);
            ccvColorHistogram.Add(greenVector);
            ccvColorHistogram.Add(blueVector);

            return ccvColorHistogram;
        }
    }

}
