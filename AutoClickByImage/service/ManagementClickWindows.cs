using AutoClickByImage.calldll;
using AutoClickByImage.exception;
using BotAutoFindItem.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AutoClickByImage.service
{
    class ManagementClickWindows
    {
		private readonly ScreenCapture serviceScreenCapture;
		private readonly SearchImage   serviceScreenImage;

		public ManagementClickWindows ( ScreenCapture screenCapture,SearchImage searchImage)
        {
			this.serviceScreenCapture = screenCapture;
			this.serviceScreenImage   = searchImage;
	    }

		public void BackgroundMouseClick(IntPtr hWnd, CallUser32Dll.VKeys key, int x, int y, int delay = 100)
		{
			switch (key)
			{
				case CallUser32Dll.VKeys.KEY_MBUTTON:
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.MBUTTONDOWN, (uint)key, GetLParam(x, y));
					Thread.Sleep(delay);
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.MBUTTONUP, (uint)key, GetLParam(x, y));
					break;
				case CallUser32Dll.VKeys.KEY_LBUTTON:
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.LBUTTONDOWN, (uint)key, GetLParam(x, y));
					Thread.Sleep(delay);
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.LBUTTONUP, (uint)key, GetLParam(x, y));
					break;
				case CallUser32Dll.VKeys.KEY_RBUTTON:
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.RBUTTONDOWN, (uint)key, GetLParam(x, y));
					Thread.Sleep(delay);
					CallUser32Dll.PostMessage(hWnd, (int)CallUser32Dll.Message.RBUTTONUP, (uint)key, GetLParam(x, y));
					break;
			}
		}

		private uint GetLParam(int x, int y)
		{
			return (uint)((y << 16) | (x & 0xFFFF));
		}

		public bool SingleClickByImage(IntPtr handle, string pathImageSearch, double accuracy ,bool debug = false)
		{
			if (handle != null)
			{
				Bitmap bitmapSearch = null, bitmapOriginal = null;
				try
				{
					bitmapOriginal = serviceScreenCapture.CaptureWindow(handle);

					bitmapSearch = new Bitmap(pathImageSearch);

					PositionMatch position = serviceScreenImage.SingleSearchImage(bitmapOriginal, bitmapSearch, accuracy, debug);

					if (position != null)
					{
						int offsetX = bitmapSearch.Width / 2;
						int offsetY = bitmapSearch.Height / 2;
						int positionX = offsetX + position.x;
						int positionY = offsetY + position.y;

						BackgroundMouseClick(handle, CallUser32Dll.VKeys.KEY_LBUTTON, positionX, positionY, 1);

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
