using AutoClickByImage.calldll;
using AutoClickByImage.model;
using BotAutoFindItem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace AutoClickByImage.service
{
    class ScreenCapture
    {
        public ItemProcess[] getListProcess()
        {
            List<ItemProcess> list = new List<ItemProcess>();

            foreach (Process itemProcess in Process.GetProcesses())
            {
                try
                {
                    ItemProcess item = new ItemProcess();
                    string text = "[" + itemProcess.Id + "]" + " - " + itemProcess.ProcessName;
                    IntPtr value = itemProcess.MainWindowHandle;

                    item.displayText = text;
                    item.valueHandle = value;
                    item.processName = itemProcess.ProcessName;

                    list.Add(item);

                }
                catch (Win32Exception error)
                {
                    throw error;
                }
            }

            list.Sort();

            return list.ToArray();
        }


        public Bitmap CaptureWindow(IntPtr handle)
        {
            // get te hDC of the target window
            IntPtr hdcSrc = CallUser32Dll.GetWindowDC(handle);
            // get the sizea
            CallUser32Dll.Rect windowRect = new CallUser32Dll.Rect();
            CallUser32Dll.GetWindowRect(handle, ref windowRect);
            int width = windowRect.Right - windowRect.Left;
            int height = windowRect.Bottom - windowRect.Top;
            // create a device context we can copy to
            IntPtr hdcDest = CallGDI32Dll.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = CallGDI32Dll.CreateCompatibleBitmap(hdcSrc, width, height);
            // select the bitmap object
            IntPtr hOld = CallGDI32Dll.SelectObject(hdcDest, hBitmap);
            // bitblt over
            CallGDI32Dll.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, CallGDI32Dll.SRCCOPY);
            // restore selection
            CallGDI32Dll.SelectObject(hdcDest, hOld);
            // clean up
            CallGDI32Dll.DeleteDC(hdcDest);
            CallUser32Dll.ReleaseDC(handle, hdcSrc);
            // get a .NET image object for it
            Bitmap img = Image.FromHbitmap(hBitmap);

            // free up the Bitmap object
            CallGDI32Dll.DeleteObject(hBitmap);

            return img;
        }

        public void debugWindows(IntPtr handle, Size sizeImageSearch, PositionMatch position)
        {
            CallUser32Dll.Rect windowsInfo = new CallUser32Dll.Rect();

            CallUser32Dll.GetWindowRect(handle, ref windowsInfo);

            int width = windowsInfo.Right - windowsInfo.Left;
            int height = windowsInfo.Bottom - windowsInfo.Top;

            Point positionPoint = new Point(position.x, position.y);
            Point location = new Point(windowsInfo.Left, windowsInfo.Top);
            Size sizeForm = new Size(width, height);

            DebugForm debugForm = new DebugForm(positionPoint, location, sizeForm, sizeImageSearch);

            debugForm.Show();

            Thread.Sleep(500);

            debugForm.closeForm();
        }

        public void debugWindows(IntPtr handle, Size sizeImageSearch, List<PositionMatch> positions)
        {
            CallUser32Dll.Rect windowsInfo = new CallUser32Dll.Rect();

            CallUser32Dll.GetWindowRect(handle, ref windowsInfo);

            int width = windowsInfo.Right - windowsInfo.Left;
            int height = windowsInfo.Bottom - windowsInfo.Top;

            Point location = new Point(windowsInfo.Left, windowsInfo.Top);
            Size sizeForm = new Size(width, height);

            DebugForm debugForm = new DebugForm(positions, location, sizeForm, sizeImageSearch);

            debugForm.Show();

            Thread.Sleep(500);

            debugForm.closeForm();
        }

    }
}
