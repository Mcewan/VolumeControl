using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
// ReSharper disable MemberCanBePrivate.Global


    namespace VolumeControl
    {
        public class Muter
        {
            private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
            private const int APPCOMMAND_VOLUME_UP = 0xA0000;
            private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
            private const int WM_APPCOMMAND = 0x319;

            private readonly IntPtr windowHandle;
            private Timer timer = new Timer();

            public Muter(Form OwnerForm)
            {
                windowHandle = OwnerForm.Handle;
                timer.Elapsed += Timer_Elapsed;
            }
            [DllImport("user32.dll")]
            public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
                IntPtr wParam, IntPtr lParam);

            internal void Mute()
            {
                SendMessageW(windowHandle, WM_APPCOMMAND, windowHandle,
                    (IntPtr)APPCOMMAND_VOLUME_MUTE);
            }

            internal void VolDown()
            {
                SendMessageW(windowHandle, WM_APPCOMMAND, windowHandle,
                    (IntPtr)APPCOMMAND_VOLUME_DOWN);
            }

            internal void VolUp()
            {
                SendMessageW(this.windowHandle, WM_APPCOMMAND, windowHandle,
                    (IntPtr)APPCOMMAND_VOLUME_UP);
            }

            internal void Mute(double i)
            {
                timer.Enabled = true;
                timer.Interval = i;
                
                Mute();
            }

            internal void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                Mute();
                timer.Enabled = false;
            }

            internal void Unmute()
            {
                VolDown();
                VolUp();
            }
        }
    }
