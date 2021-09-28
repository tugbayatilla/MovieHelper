using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace MovieHelper
{
    class MouseEvents
    {
        private const UInt32 MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const UInt32 MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const UInt32 MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const UInt32 MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const UInt32 MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const UInt32 MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const UInt32 MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const UInt32 MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const UInt32 MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire 
                                            virtual desktop */
        private const int ABSOLUTE = 0x8000; /* absolute move */
        private const float PI = 3.14f;


        [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern void _SetCursorPosition(Int32 dx, Int32 dy);


        public static void Click()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new IntPtr());
        }

        public static void SetCurserPosition(Int32 dx, Int32 dy)
        {
            _SetCursorPosition(dx, dy);
        }

        public static void DrawSquare(Int32 pix)
        {
            DrawLine(DirectionType.Xplus, pix);
            DrawLine(DirectionType.Yplus, pix);
            DrawLine(DirectionType.Xminus, pix);
            DrawLine(DirectionType.Yminus, pix);
        }
        public static void DrawCircle(Int32 radius)
        {
            //float len = ((float)radius * PI) / 8;
            //double x,y;
            //double angle;
            //for (float i = 0; i < len ; i++)
            //{
            //    angle = i * (PI / len);
            //    x = Math.Cos(angle);
            //    y = Math.Sin(angle);
            //    DrawLine(DirectionType.Xplus, (int)x);
            //    DrawLine(DirectionType.Yplus, (int)y);
            //}
        }
        public enum DirectionType
        {
            Xplus,
            Xminus,
            Yplus,
            Yminus
        }
        public static void DrawLine(DirectionType direction, Int32 pixel)
        {
            DrawLine(direction, pixel, 10);
        }
        public static void DrawLine(DirectionType direction, Int32 pixel, Int32 speed)
        {
            Point p = Cursor.Position;
            switch (direction)
            {
                case DirectionType.Xplus:
                    for (Int32 i = 0; i < pixel; i++)
                    {
                        _SetCursorPosition(p.X + i, p.Y);
                        System.Threading.Thread.Sleep(speed);
                    }
                    break;

                case DirectionType.Xminus:
                    for (Int32 i = 0; i < pixel; i++)
                    {
                        _SetCursorPosition(p.X - i, p.Y);
                        System.Threading.Thread.Sleep(speed);
                    }
                    break;
                case DirectionType.Yplus:
                    for (Int32 i = 0; i < pixel; i++)
                    {
                        _SetCursorPosition(p.X, p.Y + i);
                        System.Threading.Thread.Sleep(speed);
                    }
                    break;
                case DirectionType.Yminus:
                    for (Int32 i = 0; i < pixel; i++)
                    {
                        _SetCursorPosition(p.X, p.Y - i);
                        System.Threading.Thread.Sleep(speed);
                    }
                    break;
            }
        }
    }
}
