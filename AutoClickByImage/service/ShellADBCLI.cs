using AutoClickByImage.exception;
using AutoClickByImage.model;
using BotAutoFindItem.model;
using CliWrap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoClickByImage.service
{
    class ShellADBCLI
    {
        private string pathFileAdb;
        private SearchImage serviceSearchImage;
       
        private ShellADBCLI()
        {

        }

        public ShellADBCLI(string pathFileAdb)
        {
            this.pathFileAdb = pathFileAdb;

            CheckFile();
        }



        public ShellADBCLI(string pathFileAdb, SearchImage serviceSearchImage)
            : this(pathFileAdb)
        {
            this.serviceSearchImage = serviceSearchImage;
        }


        private void CheckFile()
        {
            if (!(File.Exists(this.pathFileAdb)))
            {
                throw new FileNotFoundException("Check Path File " + this.pathFileAdb);
            }
        }

        public async Task<string[]> GetListOfIp()
        {
            string[] commandparameter = new string[] { "devices" };
            StringBuilder stdOutBuffer = new StringBuilder();

            await Cli.Wrap(this.pathFileAdb)
             .WithArguments(commandparameter)
             .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
             .ExecuteAsync();

            return FilterIp(stdOutBuffer.ToString());

        }

        private string[] FilterIp(string word)
        {
            List<string> result = new List<string>();
            Regex pattern = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}\b");

            if (!String.IsNullOrEmpty(word.ToString()))
            {
                string[] lines = word.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                int size = lines.Length;

                for (int i = 0; i < size; i++)
                {
                    MatchCollection m = pattern.Matches(lines[i]);
                 
                    if (m.Count > 0)
                    {
                        result.Add(m[0].Value);
                    }
                }
            }
            return result.ToArray();
        }

        private string getFolderTmpImage()
        {
            string currentPathFolder =  Directory.GetCurrentDirectory();

            string folderTmp = currentPathFolder + Path.DirectorySeparatorChar + "tmp";

            if (!Directory.Exists(folderTmp))
            {
                Directory.CreateDirectory(folderTmp);
            }

            return folderTmp;
        }


        private async Task ExcuteComand(string commandparameter)
        {
              await Cli.Wrap(this.pathFileAdb)
               .WithArguments(commandparameter)
               .ExecuteAsync();
        }

        private async Task<string> CaptureScreen(string device)
        {
            string commandparameter = string.Empty;

            string folderImage = getFolderTmpImage();

            commandparameter = "-s" + " " + device + " " + "shell screencap -p" + " " + "/sdcard/Pictures/adb_pic.png";

            await ExcuteComand(commandparameter);

            string outputpath = folderImage + Path.DirectorySeparatorChar + "tmp.png";

            commandparameter = "-s" + " " + device + " " + "pull /sdcard/Pictures/adb_pic.png" + " " + outputpath;

            await ExcuteComand(commandparameter);

            return outputpath;
        }


        public async void Click(string device, int x, int y)
        {
            if (!String.IsNullOrEmpty(device))
            {
                string commandparameter = "-s" + " " + device + " " + "shell input tap" + " " + x + " " + y;

                await Cli.Wrap(this.pathFileAdb)
                .WithArguments(commandparameter)
                .ExecuteAsync();
            }

        }

        public async Task<bool> SingleClickByImage(string device , string  pathImageSearch,double accuracy ,bool debug = false)
        {
            if (!String.IsNullOrEmpty(device))
            {
                Bitmap bitmapSearch = null, bitmapOriginal = null;
                try
                {
                    string pathFileOriginal =  await CaptureScreen(device);

                    bitmapOriginal  = new Bitmap(pathFileOriginal);
                    bitmapSearch    = new Bitmap(pathImageSearch);

                    PositionMatch position = serviceSearchImage.SingleSearchImage(bitmapOriginal, bitmapSearch, accuracy, debug);

                    if (position != null)
                    {
                        string commandparameter = "-s" + " " + device + " " + "shell input tap" + " " + position.x + " " + position.y;

                        await ExcuteComand(commandparameter);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
                catch (OpenCvException error)
                {
                    throw error;
                }
                catch (Exception error)
                {
                    throw error;
                }
                finally
                {
                    if (bitmapSearch != null)
                    {
                        bitmapSearch.Dispose();
                    }

                    if (bitmapOriginal != null)
                    {
                        bitmapOriginal.Dispose();
                    }
                }
            }

            return false;
        }


        public async Task<bool> MutiClickByImage(string device, string pathImageSearch, double accuracy, bool debug = false)
        {
            if (!String.IsNullOrEmpty(device))
            {
                Bitmap bitmapSearch = null, bitmapOriginal = null;
                try
                {
                    string pathFileOriginal = await CaptureScreen(device);

                    bitmapOriginal = new Bitmap(pathFileOriginal);
                    bitmapSearch = new Bitmap(pathImageSearch);

                    List<PositionMatch> listPosition = serviceSearchImage.MutiSearchImages(bitmapOriginal, bitmapSearch, accuracy, debug);
                    int size = listPosition.Count;

                    if (size > 0 )
                    {
                        for (int i=0; i< size; i++)
                        {
                            PositionMatch position = listPosition[i];

                            string commandparameter = "-s" + " " + device + " " + "shell input tap" + " " + position.x + " " + position.y;

                            await ExcuteComand(commandparameter);
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (OpenCvException error)
                {
                    throw error;
                }
                catch (Exception error)
                {
                    throw error;
                }
                finally
                {
                    if (bitmapSearch != null)
                    {
                        bitmapSearch.Dispose();
                    }

                    if (bitmapOriginal != null)
                    {
                        bitmapOriginal.Dispose();
                    }
                }
            }

            return false;
        }

    }
}
