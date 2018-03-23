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
        public DistanceCalculator()
        {
            histogramCalculator = new HistogramCalculator();
            Console.WriteLine("- Instantiating a Distance Calculator -");
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

        //Accuracy is going to be lost
        public int intImgManhattanDistance(Bitmap imageOne, Bitmap imageTwo , int histogramID)
        {
            if (histogramID == 1)
            {
                int result = 0;
                int redDistance = 0;
                int greenDistance = 0;
                int blueDistance = 0;
                //Random randomGenerator = new Random();
                //imageTwo.Save("e:/Analisis de Algoritmos/Pruebas/" + randomGenerator.Next(0, 10000000) + ".jpg");
                //Console.WriteLine(" La imagen uno es " +imageOne.ToString());
                //Console.WriteLine(" La imagen dos es " + imageTwo.ToString());
                List<int[]> histogramOne = histogramCalculator.getColorHistogram(imageOne);
                List<int[]> histogramTwo = histogramCalculator.getColorHistogram(imageTwo);

                redDistance = manhattanDistance(histogramOne[0], histogramTwo[0]);
                greenDistance = manhattanDistance(histogramOne[1], histogramTwo[1]);
                blueDistance = manhattanDistance(histogramOne[2], histogramTwo[2]);
                //Console.WriteLine("El usuario eligió ColorHistogram con Manhattan [R =" + result + "]");
                result = redDistance + greenDistance + blueDistance;
                return result;
            }

            else
            {
                int result = 0;
                int[] histogramOne = histogramCalculator.getLBPHistogram(imageOne);
                int[] histogramTwo = histogramCalculator.getLBPHistogram(imageTwo);
                result = manhattanDistance(histogramOne, histogramTwo);

                //Console.WriteLine("El usuario eligió LBP con Manhattan ");
                return result;
            }
        }

        public int siONoRazaDistance(int[] vectorOne, int[] vectorTwo)
        {
            int result = vectorOne.Length;
            List<int> distances = new List<int>();
            for (int i = 0; i < vectorOne.Length; i++)
            {
                result-=vectorOne[i] = vectorTwo[i];
            }
            return result;
        }

        public int intImgSiONoRazaDistance(Bitmap imageOne, Bitmap imageTwo , int histogramID)
        {
            int result = 0;
            if (histogramID == 1)
            {
                
                int redDistance = 0;
                int greenDistance = 0;
                int blueDistance = 0;

                List<int[]> histogramOne = histogramCalculator.getColorHistogram(imageOne);
                List<int[]> histogramTwo = histogramCalculator.getColorHistogram(imageTwo);

                redDistance = siONoRazaDistance(histogramOne[0], histogramTwo[0]);
                greenDistance = siONoRazaDistance(histogramOne[1], histogramTwo[1]);
                blueDistance = siONoRazaDistance(histogramOne[2], histogramTwo[2]);
                //Console.WriteLine("El usuario eligió ColorHistogram con Si o No Raza? ");
                result = redDistance + greenDistance + blueDistance;
            }

            if(histogramID==2)
            {
                int[] histogramOne = histogramCalculator.getLBPHistogram(imageOne);
                int[] histogramTwo = histogramCalculator.getLBPHistogram(imageTwo);
                result = siONoRazaDistance(histogramOne, histogramTwo);

                //Console.WriteLine("El usuario eligió LBP con Si o No Raza? ");
            }
            return result;
        }


    }
}
