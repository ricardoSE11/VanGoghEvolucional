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
            //Console.WriteLine("- Instatiating a Histrogram Calculator -");
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

            //Console.WriteLine("Calculated ColorHistogram");
            return colorHistogram;
        }


        public int[] getLBPHistogram(Bitmap image)

        {
            ImageHandler converter = new ImageHandler();
            int sizeVector = (image.Height * image.Width) - (2 * (image.Height) + 2 * (image.Width));
            int [] LBPHistogram = new int[sizeVector];
            List<int[]> LHPHistograms= new List<int[]>();
            Bitmap imageGrayScale = converter.GrayFilter(image);
            int newValor = 0;
            for (int i = 0; i < imageGrayScale.Width; i++)
            {
                for (int j = 0; j < imageGrayScale.Height; j++)
                {
                    int center = imageGrayScale.GetPixel(i, j).G;
                    //the edges are not evaluated
                    if (i != 0)
                    {
                        if (i + 1 != imageGrayScale.Width)
                        {
                            if (j != 0)
                            {
                                if (j + 1 != imageGrayScale.Height)
                                {
                                    int[] pos = new int[8];
                                    pos[0] = imageGrayScale.GetPixel(i - 1, j - 1).G;
                                    pos[1] = imageGrayScale.GetPixel(i - 1, j).G;
                                    pos[2] = imageGrayScale.GetPixel(i - 1, j + 1).G;
                                    pos[3] = imageGrayScale.GetPixel(i, j - 1).G;
                                    pos[4] = imageGrayScale.GetPixel(i, j + 1).G;
                                    pos[5] = imageGrayScale.GetPixel(i + 1, j - 1).G;
                                    pos[6] = imageGrayScale.GetPixel(i + 1, j).G;
                                    pos[7] = imageGrayScale.GetPixel(i + 1, j + 1).G;
                                    for (int p = 0; p < pos.Length; p++)
                                    {
                                        if (pos[p] > center)
                                        {
                                            newValor += 2 ^ (7 - p);
                                        }
                                    }
                                    LBPHistogram[i+j]=newValor;
                                    newValor = 0;
                                }
                            }
                        }
                    }
                    //the edges are not evaluated
                }
            }
            LHPHistograms.Add(LBPHistogram);
            //Finish LBPHistogram
            //Console.WriteLine("Finish LBPHistogram");
            return LBPHistogram;
        }
    }
}

