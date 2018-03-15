using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class DistanceCalculator
    {
        HistogramCalculator histogramCalculator;
        //Constructor
        DistanceCalculator()
        {
            histogramCalculator = new HistogramCalculator();
            Console.WriteLine(" - Instantiating a Distance Calculator -");
        }

        public int manhattanDistance(int[] vectorOne, int[] vectorTwo)
        {
            int result = 0;
            for (int i = 0; i < 255; i++)
            {
                result += Math.Abs(vectorOne[i] - vectorTwo[i]);
            }
            return result;
        }

        //Gives the Manhattan Distance between two images.
        //Format:  List[0] = R | List[1] = G | List[2] = B
        public List<int> imgManhattanDistance(Bitmap imageOne, Bitmap imageTwo)
        {
            List<int> result = new List<int>();
            int redDistance = 0;
            int greenDistance = 0;
            int blueDistance = 0;

            List<int[]> histogramOne = histogramCalculator.getColorHistogram(imageOne);
            List<int[]> histogramTwo = histogramCalculator.getColorHistogram(imageTwo);

            redDistance = manhattanDistance(histogramOne[0], histogramTwo[0]);
            greenDistance = manhattanDistance(histogramOne[1], histogramTwo[1]);
            blueDistance = manhattanDistance(histogramOne[2], histogramTwo[2]);

            result.Add(redDistance);
            result.Add(greenDistance);
            result.Add(blueDistance);

            return result;
        }
    }
}
