using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO; // 文件流空间

namespace HwEcAuto
{
    public partial class LEDWnd : Form
    {
        /***************************************************************/
        // 
        Feature g_e = new Feature();
        File g_f = new File();

        static string g_currentPath = System.IO.Directory.GetCurrentDirectory();
        string g_logPath = g_currentPath + @"\ec_test" + @"\log";
        string g_libPath = g_currentPath + @"\ec_test" + @"\lib";
        /***************************************************************/


        public void InitUI()
        {
            int w0 = 100, h0 = 50;
            this.Size = new Size(628, 391);
            Size btnSize = new Size(w0, h0);
            FnBtn.Size = CapsBtn.Size = NumBtn.Size = btnSize;
            MicBtn.Size = ChargerBtn.Size = KblBtn.Size = btnSize;
            AllBlinkBtn.Size = AllLEDBtn.Size = btnSize;
            ResetLEDBtn.Size = ExitLEDBtn.Size = btnSize;

            int x0 = 55, y0 = 60;
            int gapX = 30, gapY = 40;
            FnBtn.Location = new Point(x0, y0);
            CapsBtn.Location = new Point(x0 + w0 + gapX, y0);
            NumBtn.Location = new Point(x0 + (w0 + gapX) * 2, y0);
            MicBtn.Location = new Point(x0 + (w0 + gapX) * 3, y0);
            ChargerBtn.Location  = new Point(x0, y0 + h0 + gapY);
            KblBtn.Location = new Point(x0 + w0 + gapX, y0 + h0 + gapY);
            AllBlinkBtn.Location = new Point(x0 + (w0 + gapX) * 2, y0 + h0 + gapY);
            AllLEDBtn.Location = new Point(x0 + (w0 + gapX) * 3, y0 + h0 + gapY);
            ResetLEDBtn.Location = new Point(x0, y0 + (h0 + gapY) * 2);
            ExitLEDBtn.Location = new Point(x0 + (w0 + gapX) * 3, y0 + (h0 + gapY) * 2);
        }

        public LEDWnd()
        {
            InitializeComponent();
            InitUI();
        }


        private void ExitLEDClick(object sender, EventArgs e)
        {
            MainWnd reg = new MainWnd();

            //-----------inherit the location of center
            int x = this.Location.X + (Size.Width - reg.Size.Width) / 2;
            int y = this.Location.Y + (Size.Height - reg.Size.Height) / 2;
            reg.Location = new Point(x, y);
            reg.StartPosition = FormStartPosition.Manual;
            //----------------------------------------------------
            //reg.Size = this.Size;
            reg.Show();
            this.Hide();
            string name = this.ExitLEDBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void LEDWndClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void FnMake(object sender, MouseEventArgs e)
        {
            FnBtn.BackColor = Color.SpringGreen;
            string name = "FnMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void FnBreak(object sender, MouseEventArgs e)
        {
            FnBtn.BackColor = Color.LightSkyBlue;
            string name = "FnBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void CapsMake(object sender, MouseEventArgs e)
        {
            CapsBtn.BackColor = Color.SpringGreen;
            string name = "CapsMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void CapsBreak(object sender, MouseEventArgs e)
        {
            CapsBtn.BackColor = Color.LightSkyBlue;
            string name = "CapsBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void NumMake(object sender, MouseEventArgs e)
        {
            NumBtn.BackColor = Color.SpringGreen;
            string name = "NumMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void NumBreak(object sender, MouseEventArgs e)
        {
            NumBtn.BackColor = Color.LightSkyBlue;
            string name = "NumBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void MicMake(object sender, MouseEventArgs e)
        {
            MicBtn.BackColor = Color.SpringGreen;
            string name = "MicMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void MicBreak(object sender, MouseEventArgs e)
        {
            MicBtn.BackColor = Color.LightSkyBlue;
            string name = "MicBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ResetLEDClick(object sender, EventArgs e)
        {
            FnBtn.BackColor = Color.White;
            CapsBtn.BackColor = Color.White;
            NumBtn.BackColor = Color.White;
            MicBtn.BackColor = Color.White;
            ChargerBtn.BackColor = Color.White;
            KblBtn.BackColor = Color.White;
            AllBlinkBtn.BackColor = Color.White;
            AllLEDBtn.BackColor = Color.White;
            string name = this.ResetLEDBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllLEDMake(object sender, MouseEventArgs e)
        {
            AllLEDBtn.BackColor = Color.SpringGreen;
            string name = "AllLEDMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllLEDBreak(object sender, MouseEventArgs e)
        {
            AllLEDBtn.BackColor = Color.SpringGreen;
            string name = "AllLEDBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllBlinkMake(object sender, MouseEventArgs e)
        {
            AllBlinkBtn.BackColor = Color.SpringGreen;
            string name = "AllBlinkMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllBlinkBreak(object sender, MouseEventArgs e)
        {
            AllBlinkBtn.BackColor = Color.SpringGreen;
            string name = "AllBlinkBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void KblMake(object sender, MouseEventArgs e)
        {
            KblBtn.BackColor = Color.SpringGreen;
            string name = "KblMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void KblBreak(object sender, MouseEventArgs e)
        {
            KblBtn.BackColor = Color.SpringGreen;
            string name = "KblBreak";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ChargerMake(object sender, MouseEventArgs e)
        {
            ChargerBtn.BackColor = Color.SpringGreen;
            string name = "ChargerMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ChargerBreak(object sender, MouseEventArgs e)
        {
            ChargerBtn.BackColor = Color.SpringGreen;
            string name = "ChargerMake";
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }
    }
}
