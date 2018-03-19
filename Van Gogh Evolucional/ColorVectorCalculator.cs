using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class ColorVectorCalculator
    {
        //Constructor
        public ColorVectorCalculator()
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
        
        // ----- Color Coherence Vector -----
        //The length of the vector will be 10.
        public int[] redVectorForCCV(Bitmap image)
        {
            int[] redVector = new int[10];
            int red = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    red = (image.GetPixel(i, j).R)/10 ;
                    redVector[red] += 1;
                }
            }//end of For
            return redVector;
        }

        public int[] greenVectorForCCV(Bitmap image)
        {
            int[] greenVector = new int[10];
            int green = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    green = (image.GetPixel(i, j).G ) / 10;
                    greenVector[green] += 1;
                }
            }//end of For
            return greenVector;
        }

        public int[] blueVectorForCCV(Bitmap image)
        {
            int[] blueVector = new int[10];
            int blue = 0;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    blue = (image.GetPixel(i, j).B) / 10;
                    blueVector[blue] += 1;
                }
            }//end of For
            return blueVector;
        }


    }
}
