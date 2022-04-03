using System;
using System.Runtime.InteropServices;

namespace AutoClickByImage.calldll
{
    class CallUser32Dll
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("User32.dll")]
        public static extern Int32 SendMessage(
            IntPtr hWnd,               // handle to destination window
            int Msg,                // message
            int wParam,             // first message parameter
            int lParam);			// second message parameter

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);

        public enum Message
        {
            LBUTTONDOWN = (0x201), //Left mousebutton down 
            LBUTTONUP = (0x202), //Left mousebutton up 
            LBUTTONDBLCLK = (0x203), //Left mousebutton doubleclick 
            RBUTTONDOWN = (0x204), //Right mousebutton down 
            RBUTTONUP = (0x205), //Right mousebutton up 
            RBUTTONDBLCLK = (0x206), //Right mousebutton doubleclick
            /// <summary>Middle mouse button down</summary>
            MBUTTONDOWN = (0x207),

            /// <summary>Middle mouse button up</summary>
            MBUTTONUP = (0x208)
        }
        [Serializable]
        public enum VKeys
        {
            KEY_LBUTTON = 0x01, //Left mouse button 
            KEY_RBUTTON = 0x02, //Right mouse button 
            KEY_CANCEL = 0x03, //Control-break processing 
            KEY_MBUTTON = 0x04, //Middle mouse button (three-button mouse) 
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);


    }
}
