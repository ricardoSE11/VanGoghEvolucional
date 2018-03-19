using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class VectorCalculator
    {
        //Constructor
        public VectorCalculator()
        {
            Console.WriteLine("- Instantiating a Color Vector Calculator. -");
        }

        public int[] redVector(Bitmap image)
        {
            int[] redFrequencyVector = new int[256];
            int red = 0;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    red = image.GetPixel(i, j).R;
                    redFrequencyVector[red] += 1;
                }
            }//end of For
            return redFrequencyVector;
        }

        public int[] greenVector(Bitmap image)
        {
            int[] greenFrequencyVector = new int[256];
            int green = 0;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    green = image.GetPixel(i, j).G;
                    greenFrequencyVector[green] += 1;
                }
            }//end of For
            return greenFrequencyVector;
        }

        public int[] blueVector(Bitmap image)
        {
            int[] blueFrequencyVector = new int[256];
            int blue = 0;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    blue = image.GetPixel(i, j).B;
                    blueFrequencyVector[blue] += 1;
                }
            }//end of For
            return blueFrequencyVector;
        }

        public int[] transparencyVector(Bitmap image)
        {
            int[] transparencyFrequencyVector = new int[256];
            int transparency = 0;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    transparency = image.GetPixel(i, j).A;
                    transparencyFrequencyVector[transparency] += 1;
                }
            }//end of For
            return transparencyFrequencyVector;
        }


    }
}
