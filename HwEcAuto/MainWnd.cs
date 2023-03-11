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
    public partial class MainWnd : Form
    {
        /***************************************************************/
        // 
        Feature g_e = new Feature();
        File g_f = new File();
        PS g_c = new PS();

        static string g_currentPath = System.IO.Directory.GetCurrentDirectory();
        string g_logPath = g_currentPath + @"\ec_test" + @"\log";
        string g_libPath = g_currentPath + @"\ec_test" + @"\lib";
        /***************************************************************/


        public MainWnd()
        {
            InitializeComponent();
        }

        private void LEDBtnClick(object sender, EventArgs e)
        {
            string name = this.LEDBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);

            LEDWnd reg = new LEDWnd();
            //-----------inherit the location of center
            int x = this.Location.X + (Size.Width - reg.Size.Width) / 2;
            int y = this.Location.Y + (Size.Height - reg.Size.Height) / 2;
            reg.Location = new Point(x, y);
            reg.StartPosition = FormStartPosition.Manual;
            //----------------------------------------------------

            //reg.Size = this.Size;
            reg.Show();
            this.Hide();
        }

        private void KbdBtnClick(object sender, EventArgs e)
        {
            string name = this.LcdBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void LidBtnClick(object sender, EventArgs e)
        {
            string name = this.LidBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void FanBtnClick(object sender, EventArgs e)
        {
            string name = this.FanBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void PdBtnClick(object sender, EventArgs e)
        {
            string name = this.PdBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void BatteryBtnClick(object sender, EventArgs e)
        {
            string name = this.BatteryBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ShippingBtnClick(object sender, EventArgs e)
        {
            string name = this.ShippingBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ThermalBtnClick(object sender, EventArgs e)
        {
            string name = this.ThermalBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllTestBtnClick(object sender, EventArgs e)
        {
            string name = this.AllTestBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void AllExitBtnClick(object sender, EventArgs e)
        {
            string name = this.AllExitBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ChargerBtnClick(object sender, EventArgs e)
        {
            string name = this.ChargerBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void LogBtnClick(object sender, EventArgs e)
        {
            g_f.Browser(g_currentPath + @"\..");
            string name = this.LogBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ShutdownCaseBtnClick(object sender, EventArgs e)
        {
            g_f.Browser(g_currentPath + @"\..");
            string name = this.ShutdownCaseBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void KbdTestBtnClick(object sender, EventArgs e)
        {
            string name = this.KbdTestBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
            g_f.FileHandle(g_libPath + @"\KeyboardTest.bat");
        }

        private void LcdBtnClick(object sender, EventArgs e)
        {
            string name = this.LcdBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void ColdBootBtnClick(object sender, EventArgs e)
        {
            string name = this.ColdBootBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void CameraBtnClick(object sender, EventArgs e)
        {
            string name = this.CameraBtn.Text;
            string path = g_libPath + @"\" + name + @".vbe";
            g_f.Log(g_logPath + @"\HWEC.log", path);
            g_f.FileHandle(path);
        }

        private void MainWndClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void LEDBtn_MouseHover(object sender, EventArgs e)
        {
            //LEDBtn.BackColor = g_c.ZhuLv;
        }

        private void LEDBtn_MouseLeave(object sender, EventArgs e)
        {
            //LEDBtn.BackColor = g_c.FenLv;
        }
    }
}
