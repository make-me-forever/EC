using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32; // registry
// System.Runtime.InteropServices：提供了托管和非托管之间的相互调用功能
using System.Runtime.InteropServices;
// 截图
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// win32
//using System.Runtime.InteropServices;

namespace HwEcAuto
{
    class Feature
    {
        [DllImport("User32.dll")]
        public static extern int GetSystemMetrics(int nIndex);
        public enum SystemMetricsCodes
        {
            SM_CXSCREEN = 0,
            SM_CYSCREEN = 1,
            SM_CXVSCROLL = 2,
            SM_CYHSCROLL = 3,
            SM_CYCAPTION = 4,
            SM_CXBORDER = 5,
            SM_CYBORDER = 6,
            SM_CXDLGFRAME = 7,
            SM_CYDLGFRAME = 8,
            SM_CYVTHUMB = 9,
            SM_CXHTHUMB = 10,
            SM_CXICON = 11,
            SM_CYICON = 12,
            SM_CXCURSOR = 13,
            SM_CYCURSOR = 14,
            SM_CYMENU = 15,
            SM_CXFULLSCREEN = 16,
            SM_CYFULLSCREEN = 17,
            SM_CYKANJIWINDOW = 18,
            SM_MOUSEPRESENT = 19,
            SM_CYVSCROLL = 20,
            SM_CXHSCROLL = 21,
            SM_DEBUG = 22,
            SM_SWAPBUTTON = 23,
            SM_RESERVED1 = 24,
            SM_RESERVED2 = 25,
            SM_RESERVED3 = 26,
            SM_RESERVED4 = 27,
            SM_CXMIN = 28,
            SM_CYMIN = 29,
            SM_CXSIZE = 30,
            SM_CYSIZE = 31,
            SM_CXFRAME = 32,
            SM_CYFRAME = 33,
            SM_CXMINTRACK = 34,
            SM_CYMINTRACK = 35,
            SM_CXDOUBLECLK = 36,
            SM_CYDOUBLECLK = 37,
            SM_CXICONSPACING = 38,
            SM_CYICONSPACING = 39,
            SM_MENUDROPALIGNMENT = 40,
            SM_PENWINDOWS = 41,
            SM_DBCSENABLED = 42,
            SM_CMOUSEBUTTONS = 43,
            SM_CXFIXEDFRAME = SM_CXDLGFRAME,
            SM_CYFIXEDFRAME = SM_CYDLGFRAME,
            SM_CXSIZEFRAME = SM_CXFRAME,
            SM_CYSIZEFRAME = SM_CYFRAME,
            SM_SECURE = 44,
            SM_CXEDGE = 45,
            SM_CYEDGE = 46,
            SM_CXMINSPACING = 47,
            SM_CYMINSPACING = 48,
            SM_CXSMICON = 49,
            SM_CYSMICON = 50,
            SM_CYSMCAPTION = 51,
            SM_CXSMSIZE = 52,
            SM_CYSMSIZE = 53,
            SM_CXMENUSIZE = 54,
            SM_CYMENUSIZE = 55,
            SM_ARRANGE = 56,
            SM_CXMINIMIZED = 57,
            SM_CYMINIMIZED = 58,
            SM_CXMAXTRACK = 59,
            SM_CYMAXTRACK = 60,
            SM_CXMAXIMIZED = 61,
            SM_CYMAXIMIZED = 62,
            SM_NETWORK = 63,
            SM_CLEANBOOT = 67,
            SM_CXDRAG = 68,
            SM_CYDRAG = 69,
            SM_SHOWSOUNDS = 70,
            SM_CXMENUCHECK = 71,
            SM_CYMENUCHECK = 72,
            SM_SLOWMACHINE = 73,
            SM_MIDEASTENABLED = 74,
            SM_MOUSEWHEELPRESENT = 75,
            SM_XVIRTUALSCREEN = 76,
            SM_YVIRTUALSCREEN = 77,
            SM_CXVIRTUALSCREEN = 78,
            SM_CYVIRTUALSCREEN = 79,
            SM_CMONITORS = 80,
            SM_SAMEDISPLAYFORMAT = 81,
            SM_CMETRICS = 83
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(
            string lpClassName,
            string lpWindowName
        );

        /***************************************************************/
        string g_appName = null;
        string g_myPCName = "小骆";
        string g_currentPath = System.IO.Directory.GetCurrentDirectory();
        File g_f = new File();
        /***************************************************************/

        const int WM_SETTINGCHANGE = 0x001A;
        const int HWND_BROADCAST = 0xffff;

        IntPtr result1;


        private Bitmap _screenshot = null;









        /// <summary>
        /// 获取整个屏幕的矩形区域
        /// </summary>
        /// <returns>矩形区域</returns>
        public static Rectangle GetDesktopRect()
        {
            Rectangle rect = new Rectangle();
            rect.X      = GetSystemMetrics(76);
            rect.Y      = GetSystemMetrics(77);
            rect.Width  = GetSystemMetrics(78);
            rect.Height = GetSystemMetrics(79);
            //rect.X = GetSystemMetrics(Win32.SM_XVIRTUALSCREEN);
            //rect.Y = GetSystemMetrics(Win32.SM_YVIRTUALSCREEN);
            //rect.Width = Win32.GetSystemMetrics(Win32.SM_CXVIRTUALSCREEN);
            //rect.Height = Win32.GetSystemMetrics(Win32.SM_CYVIRTUALSCREEN);
            return rect;
        }

        public void ScreenCaptureAll()
        {
            Rectangle rect = GetDesktopRect();
            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //Bitmap image = CaptureScreen();
            Graphics imgGraphics = Graphics.FromImage(image);
            //设置截屏区域 柯乐义
            imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(rect.Width * 3 / 2, rect.Height * 3 / 2));
            string fullName = System.IO.Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
            image.Save(fullName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void GetScreen()
        {
            //创建图象，保存将来截取的图象
            Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics imgGraphics = Graphics.FromImage(image);
            //设置截屏区域 柯乐义
            imgGraphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
            string fullName = System.IO.Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
            image.Save(fullName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void ScreenCapture()
        {
            Rectangle bounds = Screen.GetBounds(System.Drawing.Point.Empty);
            using(Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height)) {
                using(Graphics g = Graphics.FromImage(bitmap)) {
                    g.CopyFromScreen(System.Drawing.Point.Empty, System.Drawing.Point.Empty, bounds.Size);
                }
                string fullName = System.IO.Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
                bitmap.Save(fullName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public enum SendMessageTimeoutFlags : uint
        {
            SMTO_NORMAL = 0x0000,
            SMTO_BLOCK = 0x0001,
            SMTO_ABORTIFHUNG = 0x0002,
            SMTO_NOTIMEOUTIFNOTHUNG = 0x0008
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageTimeout(
        IntPtr windowHandle,
        uint Msg,
        IntPtr wParam,
        IntPtr lParam,
        SendMessageTimeoutFlags flags,
        uint timeout,
        out IntPtr result
        );

        public void ChangeReg()
        {
            //通知所有打开的程序注册表以修改 
            SendMessageTimeout(new IntPtr(HWND_BROADCAST), WM_SETTINGCHANGE, IntPtr.Zero, IntPtr.Zero,

            SendMessageTimeoutFlags.SMTO_NORMAL, 1000, out result1);
        }

        public string GetReg()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            return Convert.ToString(reg.GetValue("LocaleName", null));
        }

        public void SetReg(string language)
        {
            if(language == null) {
                return;
            }
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            if(reg == null) {
                return;
            }
            reg.SetValue("LocaleName", language);
            //ChangeReg();
        }
        
        /*
         * Log自动清理功能
         * 
         */
        public bool InitLog(int days)
        {
            string g_logPath = g_currentPath + @"\Libcore\log\note.log";
            if(!System.IO.File.Exists(g_logPath)) {
                return false;
            }
            // 获取日志初时间x
            string x = g_f.CutTime(g_f.getLine(g_logPath, 1));
            // 获取日志末时间y
            string y = g_f.CutTime(g_f.getLine(g_logPath, g_f.getMaxLine(g_logPath) - 1));
            int total = g_f.DaysDifference(x, y); // 获取日志最大时间差
            if(total >= days) { // 每隔days天清理一次
                bool isInit = g_f.Replace(g_logPath, g_logPath, System.IO.File.ReadAllText(g_logPath), "");
                g_f.Log(g_logPath, "日志已自动清理");
                if(isInit) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        /*
         * 判断用户是否是‘我’
         */
        public bool IsMe()
        {
            string me = System.Environment.GetEnvironmentVariable("ComputerName");
            if(me == g_myPCName) {
                return true;
            } else {
                return false;
            }
        }
    }
}
