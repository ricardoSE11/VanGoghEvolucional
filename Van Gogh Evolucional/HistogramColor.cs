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
        public ArrayList histogramsGreen = new ArrayList();
        public ArrayList histogramsBlue = new ArrayList();
       
        //Constructor de la clase
        public HistogramColor()
        {
        }
        public HistogramColor(int amountOfImages)
        {
            Console.WriteLine("- Instantiating the Image Generator with:" + amountOfImages + " -");
        }
        public void ExamineImage(Bitmap Image)
        {
            int red=0;
            int green =0;
            int blue =0;
            int [] histogramRed = new int[255];
            int [] histogramGreen = new int[255];
            int [] histogramBlue = new int[255];

            for(int i = 0; i <= Image.Width - 1; i++)
            {
                for (int j = 0; j <= Image.Height - 1; j++)
                {
                    red = Image.GetPixel(i,j).R;
                    green= Image.GetPixel(i, j).G;
                    blue = Image.GetPixel(i, j).B;
                    //Acumulamos los valores
                    histogramRed[red] +=1;
                    histogramGreen[green] += 1;
                    histogramBlue[blue] += 1;
                }
            }
            Console.Write("Ya saque el histograma");
            histogramsRed.Add(histogramRed);
            histogramsGreen.Add(histogramGreen);
            histogramsBlue.Add(histogramBlue);
            if (histogramsRed.Count==0)
            {
                Console.WriteLine("Estoy vacio");
            }
            else
            {
for (int a = 0; a < histogramsRed.Count; a++)
            {
                    Console.WriteLine("ESCRIBIR COSAS SIGNIFICATIVAS, NO COSAS COMO HOLI, DIOS MIO AYUDA. AWAAAAANTAAAAA.");
                Console.WriteLine("Holi numero uno");
                for(int b=0; b < histogramsRed[a].Length ; b++)
                {

                        Console.Write(histogramsRed[a][b]);
                    
                }
                Console.WriteLine("Holi numero dos");
            }
            Console.WriteLine("Holiiiiiiiiii");
            }
            
        }
    }
}
