using AutoClickByImage.calldll;
using AutoClickByImage.exception;
using BotAutoFindItem.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;


namespace AutoClickByImage.service
{
    class ManagementClickWindows
    {
        private readonly ScreenCapture serviceScreenCapture;
        private readonly SearchImage serviceScreenImage;
        public  bool debugImageDrawWindows { get; set; } = false;
        

        public ManagementClickWindows(ScreenCapture screenCapture, SearchImage searchImage)
        {
            this.serviceScreenCapture = screenCapture;
            this.serviceScreenImage = searchImage;
        }


        public void BackgroundMouseClick(IntPtr hWnd, CallUser32Dll.VKeys key, int x, int y, int delay = 100)
        {
            switch (key)
            {
                case CallUser32Dll.VKeys.KEY_MBUTTON:
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.MBUTTONDOWN, 0x00000001, GetLParam(x, y));
                    Thread.Sleep(delay);
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.MBUTTONUP, 0x00000000, GetLParam(x, y));
                    break;
                case CallUser32Dll.VKeys.KEY_LBUTTON:
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.LBUTTONDOWN, 0x00000001, GetLParam(x, y));
                    Thread.Sleep(delay);
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.LBUTTONUP, 0x00000000, GetLParam(x, y));
                    break;
                case CallUser32Dll.VKeys.KEY_RBUTTON:
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.RBUTTONDOWN, 0x00000001, GetLParam(x, y));
                    Thread.Sleep(delay);
                    CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.RBUTTONUP, 0x00000000, GetLParam(x, y));
                    break;
            }
        }

        private uint GetLParam(int x, int y)
        {
            return (uint)((y << 16) | (x & 0xFFFF));
        }

        public bool SingleClickByImage(IntPtr handle, string pathImageSearch, double accuracy)
        {
            if (handle != null)
            {
                Bitmap bitmapSearch = null, bitmapOriginal = null;
                try
                {
                    bitmapOriginal = serviceScreenCapture.CaptureWindow(handle);

                    bitmapSearch = new Bitmap(pathImageSearch);

                    PositionMatch position = serviceScreenImage.SingleSearchImage(bitmapOriginal, bitmapSearch, accuracy);


                    if (position != null)
                    {
                        Size size = bitmapSearch.Size;
                        int offsetX = bitmapSearch.Width / 2;
                        int offsetY = bitmapSearch.Height / 2;
                        int positionX = offsetX + position.x;
                        int positionY = offsetY + position.y;

                        if (debugImageDrawWindows)
                        {
                            new Thread(delegate ()
                            {
                                serviceScreenCapture.debugWindows(handle, size, position);
                            }).Start();
                        }

                        BackgroundMouseClick(handle, CallUser32Dll.VKeys.KEY_LBUTTON, positionX, positionY, 100);

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

        public bool MutiClickByImage(IntPtr handle, string pathImageSearch, double accuracy)
        {
            if (handle != null)
            {
                Bitmap bitmapSearch = null, bitmapOriginal = null;
                try
                {
                    bitmapOriginal = serviceScreenCapture.CaptureWindow(handle);

                    bitmapSearch = new Bitmap(pathImageSearch);
                    List<PositionMatch> positions = serviceScreenImage.MutiSearchImages(bitmapOriginal, bitmapSearch, accuracy);
                    int sizePositions = positions.Count;

                    if (sizePositions > 0)
                    {
                        Size size = bitmapSearch.Size;
                        int offsetX = bitmapSearch.Width / 2;
                        int offsetY = bitmapSearch.Height / 2;

                        if (debugImageDrawWindows)
                        {
                            new Thread(delegate ()
                            {
                                serviceScreenCapture.debugWindows(handle, size, positions);
                            }).Start();
                        }

                        for (int i = 0; i < sizePositions; i++)
                        {
                            PositionMatch position = positions[i];

                            int positionX = offsetX + position.x;
                            int positionY = offsetY + position.y;

                            BackgroundMouseClick(handle, CallUser32Dll.VKeys.KEY_LBUTTON, positionX, positionY, 500);
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
