using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HwEcAuto
{
    static class Program
    {
        /***************************************************************/
        // 
        static File g_f = new File();
        /***************************************************************/
        static string g_currentPath = System.IO.Directory.GetCurrentDirectory();
        public static void InitDirectory()
        {
            string ecDirectory = g_currentPath + @"\ec_test";
            g_f.CreatFolder(g_currentPath, @"ec_test");
            g_f.CreatFolder(ecDirectory, @"log");
            g_f.CreatFolder(ecDirectory, @"lib");
        }
        static void InitMain()
        {
            InitDirectory();
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitMain();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWnd main = new MainWnd();
            Application.Run(main);

            Application.Exit();
            main.Close();
            System.Environment.Exit(0);
            Application.ExitThread();
        }
    }
}
