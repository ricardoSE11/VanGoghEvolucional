using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class HistogramColor
    {
        public List<int[]> histogramsRed = new List<int[]>();
        public List<int[]> histogramsGreen = new List<int[]>();
        public List<int[]> histogramsBlue = new List<int[]>();

        //Class contructor 
        public HistogramColor()
        {
        }
        public HistogramColor(int amountOfImages)
        {
            Console.WriteLine("- Instantiating the HistogramColor with:");
        }
        public void ExamineImage(Bitmap Image)
        {
            //Variables
            int red = 0;
            int green = 0;
            int blue = 0;
            int[] histogramRed = new int[255];
            int[] histogramGreen = new int[255];
            int[] histogramBlue = new int[255];

            for (int i = 0; i <= Image.Width - 1; i++)
            {
                for (int j = 0; j <= Image.Height - 1; j++)
                {
                    red = Image.GetPixel(i, j).R;
                    green = Image.GetPixel(i, j).G;
                    blue = Image.GetPixel(i, j).B;
                    //Accumulate values
                    histogramRed[red] += 1;
                    histogramGreen[green] += 1;
                    histogramBlue[blue] += 1;
                }
            }
            Console.Write("Histograms creates\n");
            histogramsRed.Add(histogramRed);
            histogramsGreen.Add(histogramGreen);
            histogramsBlue.Add(histogramBlue);
            Console.WriteLine("GlobalHistograms ADD\n");
            //HistogramR test

            //if (histogramsRed.Count == 0)
            //{
            //    Console.WriteLine("Null\n");
            //}
            //else
            //{
            //    for (int a = 0; a < histogramsRed.Count; a++)
            //    {
            //        Console.WriteLine("Histogram Red" + "\n");

            //        for (int b = 0; b < histogramsRed[a].Length; b++)
            //        {

            //            Console.WriteLine(b+" "+histogramsRed[a][b]+"\n");

            //        }
            //    }
            //    for (int a = 0; a < histogramsGreen.Count; a++)
            //    {
            //        Console.WriteLine("Histogram Green"+"\n");
            //        for (int b = 0; b < histogramsGreen[a].Length; b++)
            //        {

            //            Console.WriteLine(b + " " + histogramsGreen[a][b] + "\n");

            //        }
            //    }
            //    for (int a = 0; a < histogramsBlue.Count; a++)
            //    {
            //        Console.WriteLine("Histogram Blue" + "\n");
            //        for (int b = 0; b < histogramsBlue[a].Length; b++)
            //        {

            //            Console.WriteLine(b + " " + histogramsBlue[a][b] + "\n");

            //        }
            //    }

            //}

        }
    }
}
