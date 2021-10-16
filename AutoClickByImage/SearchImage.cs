using AutoClickByImage.model;
using BotAutoFindItem.model;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace AutoClickByImage
{
    class SearchImage
    {

        public PositionMatch SingleSearchImage(Bitmap imgSource, Bitmap imgSeach, double accuracy)
        {
            Image<Bgr, byte> template = null , source = null;
            Image<Gray, float> result = null;

            try
            {
                 template =  imgSeach.ToImage<Bgr, byte>();
                 source   =  imgSource.ToImage<Bgr, byte>();
               
                 result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed);


                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > accuracy)
                {
                   
                    return new PositionMatch(maxLocations[0].X, maxLocations[0].Y);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
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


        public List<PositionMatch> MutiSearchImages(Bitmap imageOriginal, Bitmap imageSearch, double accuracy)
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
                       
                        using (Image<Gray, float> result = imageCloneOriginal.MatchTemplate(imgSearchByte, TemplateMatchingType.CcoeffNormed))
                        {

                            double[] minValues, maxValues;
                            Point[] minLocations, maxLocations;
                            result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                            if (maxValues[0] > accuracy)
                            {
                                listOfPositionMatch.Add(new PositionMatch(maxLocations[0].X, maxLocations[0].Y) );
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }

                return listOfPositionMatch;

            }
            catch (Exception ex)
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


    }
}
