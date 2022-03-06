using AutoClickByImage.exception;
using AutoClickByImage.model;
using BotAutoFindItem.model;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace AutoClickByImage.service
{
    class SearchImage
    {
        private readonly string FODER_DEBUG_IMAGE = "debugimage";
    
        public PositionMatch SingleSearchImage(Bitmap imgSource, Bitmap imgSeach, double accuracy , bool debug = false)
        {
            Image<Bgr, byte> template = null , source = null;
            Image<Gray, float> result = null;

            try
            {
                 template =  imgSeach.ToImage<Bgr, byte>();
                 source   =  imgSource.ToImage<Bgr, byte>();

                try
                {
                    result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed);
                }
                catch (Exception error)
                {
                    throw new OpenCvException(error.Message,error);
                }

                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > accuracy)
                {
                    if (debug)
                    {
                        debugImage(source, maxLocations[0], template.Size);
                    }

                    return new PositionMatch(maxLocations[0].X, maxLocations[0].Y);
                }
                else
                {
                    return null;
                }

            }
            catch (OpenCvException ex)
            {
                throw ex;
            }
            finally
            {
                if (template != null)
                {
                    template.Dispose();
                }

                if (source != null)
                {
                    source.Dispose();
                }

                if (result != null)
                {
                    result.Dispose();
                }
 
            }
        }

      
        public List<PositionMatch> MutiSearchImages(Bitmap imageOriginal, Bitmap imageSearch, double accuracy, bool debug = false)
        {
            Image<Bgr, byte> imgOriginalByte = null, imgSearchByte = null;
            List<PositionMatch> listOfPositionMatch = new List<PositionMatch>();

            try
            {
                imgOriginalByte = imageOriginal.ToImage<Bgr, byte>();
                imgSearchByte   = imageSearch.ToImage<Bgr, byte>();
              
                using (Image<Bgr, byte> imageCloneOriginal = imgOriginalByte.Copy())
                {
                    while (true)
                    {
                        try
                        {
                            using (Image<Gray, float> result = imageCloneOriginal.MatchTemplate(imgSearchByte, TemplateMatchingType.CcoeffNormed))
                            {

                                double[] minValues, maxValues;
                                Point[] minLocations, maxLocations;
                                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                                if (maxValues[0] > accuracy)
                                {
                                    listOfPositionMatch.Add(new PositionMatch(maxLocations[0].X, maxLocations[0].Y));
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        catch (Exception error)
                        {
                            throw new OpenCvException(error.Message, error);
                        }

                    }
                }

                if (debug)
                {
                    debugImage(imgSearchByte, listOfPositionMatch, imgOriginalByte.Size);
                }

                return listOfPositionMatch;

            }
            catch (OpenCvException ex)
            {
                throw ex;
            }
            finally
            {
               
                if (imgOriginalByte != null)
                {
                    imgOriginalByte.Dispose();
                }

                if (imgSearchByte != null)
                {
                    imgSearchByte.Dispose();
                }

            }
        }

        private void debugImage(Image<Bgr, byte> sourceImg, Point location, Size size)
        {
            string folder = FODER_DEBUG_IMAGE;

            debugFolder(folder);

            string fileName = Directory.GetCurrentDirectory() + "/" + folder + "/" + DateTime.Now.ToFileTime().ToString() + ".png";

            using (Image<Bgr, byte> imageCopy = sourceImg.Copy())
            {
                Rectangle match = new Rectangle(location, size);

                imageCopy.Draw(match, new Bgr(Color.Blue), 3);

                imageCopy.Save(fileName);

                imageCopy.Dispose();
            }
        }

        private void debugImage(Image<Bgr, byte> sourceImg, List<PositionMatch> listOfPositionMatch, Size size)
        {
            string folder = FODER_DEBUG_IMAGE;

            debugFolder(folder);

            string fileName = Directory.GetCurrentDirectory() + "/" + folder + "/" + DateTime.Now.ToFileTime().ToString() + ".png";

            using (Image<Bgr, byte> imageCopy = sourceImg.Copy())
            {
                int sizePoint = listOfPositionMatch.Count;

                for (int i = 0; i < sizePoint; i++)
                {
                    int x = listOfPositionMatch[i].x;
                    int y = listOfPositionMatch[i].y;

                    Rectangle match = new Rectangle(new Point(x, y), size);

                    imageCopy.Draw(match, new Bgr(Color.Blue), 3);
                }

                imageCopy.Save(fileName);

                imageCopy.Dispose();
            }
        }

        private void debugFolder(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }



    }
}
