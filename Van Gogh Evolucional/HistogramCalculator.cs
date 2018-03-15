using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class HistogramCalculator
    {
        ColorVectorCalculator colorVectorCalculator = new ColorVectorCalculator();
        //Contructor 
        public HistogramCalculator()
        {
            Console.WriteLine("- Instatiating a Histrogram Calculator -");
        }


        //Format: List[0] = R | List[1] = G | List[2] = B
        public List<int[]> getColorHistogram(Bitmap image)
        {
            List<int[]> colorHistogram = new List<int[]>();
            int[] redVector = colorVectorCalculator.redVector(image);
            int[] greenVector = colorVectorCalculator.greenVector(image);
        }
        
    }
}
