using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{
    class ImageHandler
    {
        //Constructor
        public ImageHandler()
        {
            //Console.WriteLine("Instatiating an ImageProcessor.");
        }

        public Bitmap resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var resizedImage = new Bitmap(width, height);

            resizedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            //Console.WriteLine("Resizing image to: " + width + " x " + height);
            return resizedImage;
        }

        public Bitmap resizeImgWithChoosingQuality(Bitmap image, int maxWidth, int maxHeight, int quality)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            //Console.WriteLine("Resizing meta image to: " + maxWidth + " x " + maxWidth);
            return newImage;
        }

        public Bitmap blurFilter(Bitmap image, Int32 blurSize)
        {
            //Console.WriteLine("Blurring the image: " + image.ToString());
            return blurImage(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        //No special reason to keep it private
        private static Bitmap blurImage(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }

        public List<Bitmap> blurImages(List<Bitmap> images)
        {
            List<Bitmap> blurredList = new List<Bitmap>();
            for (int i = 0; i < images.Count; i++)
            {
                images[i] = blurFilter(images[i], 5);
                blurredList.Add(images[i]);
            }
            //Console.WriteLine("Blurred: " + images.Count + " images");
            return blurredList;
        }

        public Bitmap GrayFilter(Bitmap image)
        {
            //Console.WriteLine("Turning to gray the image: " + image.ToString());
            return GrayImage(image);
        }

        private Bitmap GrayImage(Bitmap image)
        {
            Color actual;
            Color newColor;
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < image.Width; i++)
            {

                for (int j = 0; j < image.Height; j++)
                {

                    actual = image.GetPixel(i, j);
                    //Console.WriteLine("actual; " + image.GetPixel(i, j));
                    //Create newColor
                    newColor = Color.FromArgb((actual.R + actual.B + actual.G) / 3, (actual.R + actual.B + actual.G) / 3, (actual.R + actual.B + actual.G) / 3);
                    newImage.SetPixel(i, j, newColor);
                    //Console.WriteLine("Prueba " + newImage.GetPixel(i, j));
                }
            }//end of For
            //Console.WriteLine("- Image converted to grayscale -");
            return newImage;

        }

        public Bitmap concatenateBitmaps(Bitmap imgOne, Bitmap imgTwo)
        {
            
            //read all images into memory
            List<Bitmap> images = new List<Bitmap>();
            images.Add(imgTwo);
            images.Add(imgOne);
            Bitmap finalImage = null;

            int width = imgOne.Width * 2;
            int height = imgOne.Height;

            //create a bitmap to hold the combined image
            finalImage = new Bitmap(width, height);

            //get a graphics object from the image so we can draw on it
            using (Graphics g = Graphics.FromImage(finalImage))

            {
                //set background color
                g.Clear(Color.Black);

                //go through each image and draw it on the final image
                int offset = 0;
                foreach (Bitmap image in images)
                {
                    g.DrawImage(image,
                        new Rectangle(offset, 0, image.Width, image.Height));
                    offset += image.Width;
                }
            }
            if (finalImage.Equals(null))
                Console.WriteLine("Ya llegué aquí: " + finalImage.ToString());

            return finalImage;
        }

        public Bitmap cropAtRectangle(Bitmap b, int width, int height)
        {
            Rectangle r = new Rectangle(0, 0, width, height);
            Bitmap nb = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(nb);
            g.DrawImage(b, -r.X, -r.Y);
            //Console.WriteLine("Croping an image. Result dimension:" + nb.Width + " x " + nb.Height);
            return nb;
        }


    }
}