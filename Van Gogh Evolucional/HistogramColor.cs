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

        //Antes era ExamineImage
        public void getColorHistogram(Bitmap Image)
        {
            //Variables
            int red = 0;
            int green = 0;
            int blue = 0;
            int[] histogramRed = new int[256];
            int[] histogramGreen = new int[256];
            int[] histogramBlue = new int[256];

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

            //if (histogramsred.count == 0)
            //{
            //    console.writeline("null\n");
            //}
            //else
            //{
            //    for (int a = 0; a < histogramsred.count; a++)
            //    {
            //        console.writeline("histogram red" + "\n");

            //        for (int b = 0; b < histogramsred[a].length; b++)
            //        {

            //            console.writeline(b + " " + histogramsred[a][b] + "\n");

            //        }
            //    }
            //    for (int a = 0; a < histogramsgreen.count; a++)
            //    {
            //        console.writeline("histogram green" + "\n");
            //        for (int b = 0; b < histogramsgreen[a].length; b++)
            //        {

            //            console.writeline(b + " " + histogramsgreen[a][b] + "\n");

            //        }
            //    }
            //    for (int a = 0; a < histogramsblue.count; a++)
            //    {
            //        console.writeline("histogram blue" + "\n");
            //        for (int b = 0; b < histogramsblue[a].length; b++)
            //        {

            //            console.writeline(b + " " + histogramsblue[a][b] + "\n");

            //        }
            //    }

            //}

        }
    }
}
