namespace HwEcAuto
{
    partial class MainWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWnd));
            this.LEDBtn = new System.Windows.Forms.Button();
            this.PdBtn = new System.Windows.Forms.Button();
            this.LcdBtn = new System.Windows.Forms.Button();
            this.FanBtn = new System.Windows.Forms.Button();
            this.LidBtn = new System.Windows.Forms.Button();
            this.BatteryBtn = new System.Windows.Forms.Button();
            this.ShippingBtn = new System.Windows.Forms.Button();
            this.AllTestBtn = new System.Windows.Forms.Button();
            this.AllExitBtn = new System.Windows.Forms.Button();
            this.ThermalBtn = new System.Windows.Forms.Button();
            this.ChargerBtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.ShutdownCaseBtn = new System.Windows.Forms.Button();
            this.ColdBootBtn = new System.Windows.Forms.Button();
            this.CameraBtn = new System.Windows.Forms.Button();
            this.KbdTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LEDBtn
            // 
            this.LEDBtn.BackColor = System.Drawing.Color.Cyan;
            this.LEDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LEDBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LEDBtn.ForeColor = System.Drawing.Color.Black;
            this.LEDBtn.Location = new System.Drawing.Point(55, 30);
            this.LEDBtn.Name = "LEDBtn";
            this.LEDBtn.Size = new System.Drawing.Size(100, 50);
            this.LEDBtn.TabIndex = 0;
            this.LEDBtn.Text = "LED";
            this.LEDBtn.UseVisualStyleBackColor = false;
            this.LEDBtn.Click += new System.EventHandler(this.LEDBtnClick);
            this.LEDBtn.MouseLeave += new System.EventHandler(this.LEDBtn_MouseLeave);
            this.LEDBtn.MouseHover += new System.EventHandler(this.LEDBtn_MouseHover);
            // 
            // PdBtn
            // 
            this.PdBtn.BackColor = System.Drawing.Color.Cyan;
            this.PdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PdBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PdBtn.ForeColor = System.Drawing.Color.Black;
            this.PdBtn.Location = new System.Drawing.Point(315, 100);
            this.PdBtn.Name = "PdBtn";
            this.PdBtn.Size = new System.Drawing.Size(100, 50);
            this.PdBtn.TabIndex = 1;
            this.PdBtn.Text = "Pd";
            this.PdBtn.UseVisualStyleBackColor = false;
            this.PdBtn.Click += new System.EventHandler(this.PdBtnClick);
            // 
            // LcdBtn
            // 
            this.LcdBtn.BackColor = System.Drawing.Color.Cyan;
            this.LcdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LcdBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LcdBtn.ForeColor = System.Drawing.Color.Black;
            this.LcdBtn.Location = new System.Drawing.Point(185, 30);
            this.LcdBtn.Name = "LcdBtn";
            this.LcdBtn.Size = new System.Drawing.Size(100, 50);
            this.LcdBtn.TabIndex = 2;
            this.LcdBtn.Text = "Lcd";
            this.LcdBtn.UseVisualStyleBackColor = false;
            this.LcdBtn.Click += new System.EventHandler(this.LcdBtnClick);
            // 
            // FanBtn
            // 
            this.FanBtn.BackColor = System.Drawing.Color.Cyan;
            this.FanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FanBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FanBtn.ForeColor = System.Drawing.Color.Black;
            this.FanBtn.Location = new System.Drawing.Point(445, 30);
            this.FanBtn.Name = "FanBtn";
            this.FanBtn.Size = new System.Drawing.Size(100, 50);
            this.FanBtn.TabIndex = 3;
            this.FanBtn.Text = "Fan";
            this.FanBtn.UseVisualStyleBackColor = false;
            this.FanBtn.Click += new System.EventHandler(this.FanBtnClick);
            // 
            // LidBtn
            // 
            this.LidBtn.BackColor = System.Drawing.Color.Cyan;
            this.LidBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LidBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LidBtn.ForeColor = System.Drawing.Color.Black;
            this.LidBtn.Location = new System.Drawing.Point(315, 30);
            this.LidBtn.Name = "LidBtn";
            this.LidBtn.Size = new System.Drawing.Size(100, 50);
            this.LidBtn.TabIndex = 4;
            this.LidBtn.Text = "Lid";
            this.LidBtn.UseVisualStyleBackColor = false;
            this.LidBtn.Click += new System.EventHandler(this.LidBtnClick);
            // 
            // BatteryBtn
            // 
            this.BatteryBtn.BackColor = System.Drawing.Color.Cyan;
            this.BatteryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BatteryBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BatteryBtn.ForeColor = System.Drawing.Color.Black;
            this.BatteryBtn.Location = new System.Drawing.Point(55, 100);
            this.BatteryBtn.Name = "BatteryBtn";
            this.BatteryBtn.Size = new System.Drawing.Size(100, 50);
            this.BatteryBtn.TabIndex = 5;
            this.BatteryBtn.Text = "Battery";
            this.BatteryBtn.UseVisualStyleBackColor = false;
            this.BatteryBtn.Click += new System.EventHandler(this.BatteryBtnClick);
            // 
            // ShippingBtn
            // 
            this.ShippingBtn.BackColor = System.Drawing.Color.Cyan;
            this.ShippingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShippingBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShippingBtn.ForeColor = System.Drawing.Color.Black;
            this.ShippingBtn.Location = new System.Drawing.Point(185, 170);
            this.ShippingBtn.Name = "ShippingBtn";
            this.ShippingBtn.Size = new System.Drawing.Size(100, 50);
            this.ShippingBtn.TabIndex = 7;
            this.ShippingBtn.Text = "Shipping";
            this.ShippingBtn.UseVisualStyleBackColor = false;
            this.ShippingBtn.Click += new System.EventHandler(this.ShippingBtnClick);
            // 
            // AllTestBtn
            // 
            this.AllTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AllTestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllTestBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.AllTestBtn.ForeColor = System.Drawing.Color.Black;
            this.AllTestBtn.Location = new System.Drawing.Point(55, 240);
            this.AllTestBtn.Name = "AllTestBtn";
            this.AllTestBtn.Size = new System.Drawing.Size(100, 50);
            this.AllTestBtn.TabIndex = 8;
            this.AllTestBtn.Text = "AllTest";
            this.AllTestBtn.UseVisualStyleBackColor = false;
            this.AllTestBtn.Click += new System.EventHandler(this.AllTestBtnClick);
            // 
            // AllExitBtn
            // 
            this.AllExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AllExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllExitBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.AllExitBtn.ForeColor = System.Drawing.Color.Black;
            this.AllExitBtn.Location = new System.Drawing.Point(445, 240);
            this.AllExitBtn.Name = "AllExitBtn";
            this.AllExitBtn.Size = new System.Drawing.Size(100, 50);
            this.AllExitBtn.TabIndex = 9;
            this.AllExitBtn.Text = "AllExit";
            this.AllExitBtn.UseVisualStyleBackColor = false;
            this.AllExitBtn.Click += new System.EventHandler(this.AllExitBtnClick);
            // 
            // ThermalBtn
            // 
            this.ThermalBtn.BackColor = System.Drawing.Color.Cyan;
            this.ThermalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ThermalBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThermalBtn.ForeColor = System.Drawing.Color.Black;
            this.ThermalBtn.Location = new System.Drawing.Point(445, 100);
            this.ThermalBtn.Name = "ThermalBtn";
            this.ThermalBtn.Size = new System.Drawing.Size(100, 50);
            this.ThermalBtn.TabIndex = 10;
            this.ThermalBtn.Text = "Thermal";
            this.ThermalBtn.UseVisualStyleBackColor = false;
            this.ThermalBtn.Click += new System.EventHandler(this.ThermalBtnClick);
            // 
            // ChargerBtn
            // 
            this.ChargerBtn.BackColor = System.Drawing.Color.Cyan;
            this.ChargerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChargerBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChargerBtn.ForeColor = System.Drawing.Color.Black;
            this.ChargerBtn.Location = new System.Drawing.Point(185, 100);
            this.ChargerBtn.Name = "ChargerBtn";
            this.ChargerBtn.Size = new System.Drawing.Size(100, 50);
            this.ChargerBtn.TabIndex = 11;
            this.ChargerBtn.Text = "Charger";
            this.ChargerBtn.UseVisualStyleBackColor = false;
            this.ChargerBtn.Click += new System.EventHandler(this.ChargerBtnClick);
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogBtn.ForeColor = System.Drawing.Color.Black;
            this.LogBtn.Location = new System.Drawing.Point(315, 240);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(100, 50);
            this.LogBtn.TabIndex = 12;
            this.LogBtn.Text = "Log";
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.LogBtnClick);
            // 
            // ShutdownCaseBtn
            // 
            this.ShutdownCaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShutdownCaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShutdownCaseBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ShutdownCaseBtn.ForeColor = System.Drawing.Color.Black;
            this.ShutdownCaseBtn.Location = new System.Drawing.Point(185, 240);
            this.ShutdownCaseBtn.Name = "ShutdownCaseBtn";
            this.ShutdownCaseBtn.Size = new System.Drawing.Size(100, 50);
            this.ShutdownCaseBtn.TabIndex = 16;
            this.ShutdownCaseBtn.Text = "ShutdownCase";
            this.ShutdownCaseBtn.UseVisualStyleBackColor = false;
            this.ShutdownCaseBtn.Click += new System.EventHandler(this.ShutdownCaseBtnClick);
            // 
            // ColdBootBtn
            // 
            this.ColdBootBtn.BackColor = System.Drawing.Color.Cyan;
            this.ColdBootBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColdBootBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColdBootBtn.ForeColor = System.Drawing.Color.Black;
            this.ColdBootBtn.Location = new System.Drawing.Point(445, 170);
            this.ColdBootBtn.Name = "ColdBootBtn";
            this.ColdBootBtn.Size = new System.Drawing.Size(100, 50);
            this.ColdBootBtn.TabIndex = 15;
            this.ColdBootBtn.Text = "ColdBoot";
            this.ColdBootBtn.UseVisualStyleBackColor = false;
            this.ColdBootBtn.Click += new System.EventHandler(this.ColdBootBtnClick);
            // 
            // CameraBtn
            // 
            this.CameraBtn.BackColor = System.Drawing.Color.Cyan;
            this.CameraBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CameraBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CameraBtn.ForeColor = System.Drawing.Color.Black;
            this.CameraBtn.Location = new System.Drawing.Point(55, 170);
            this.CameraBtn.Name = "CameraBtn";
            this.CameraBtn.Size = new System.Drawing.Size(100, 50);
            this.CameraBtn.TabIndex = 14;
            this.CameraBtn.Text = "Camera";
            this.CameraBtn.UseVisualStyleBackColor = false;
            this.CameraBtn.Click += new System.EventHandler(this.CameraBtnClick);
            // 
            // KbdTestBtn
            // 
            this.KbdTestBtn.BackColor = System.Drawing.Color.Cyan;
            this.KbdTestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KbdTestBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KbdTestBtn.ForeColor = System.Drawing.Color.Black;
            this.KbdTestBtn.Location = new System.Drawing.Point(315, 170);
            this.KbdTestBtn.Name = "KbdTestBtn";
            this.KbdTestBtn.Size = new System.Drawing.Size(100, 50);
            this.KbdTestBtn.TabIndex = 13;
            this.KbdTestBtn.Text = "KbdTest";
            this.KbdTestBtn.UseVisualStyleBackColor = false;
            this.KbdTestBtn.Click += new System.EventHandler(this.KbdTestBtnClick);
            // 
            // MainWnd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.ShutdownCaseBtn);
            this.Controls.Add(this.ColdBootBtn);
            this.Controls.Add(this.CameraBtn);
            this.Controls.Add(this.KbdTestBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.ChargerBtn);
            this.Controls.Add(this.ThermalBtn);
            this.Controls.Add(this.AllExitBtn);
            this.Controls.Add(this.AllTestBtn);
            this.Controls.Add(this.ShippingBtn);
            this.Controls.Add(this.BatteryBtn);
            this.Controls.Add(this.LidBtn);
            this.Controls.Add(this.FanBtn);
            this.Controls.Add(this.LcdBtn);
            this.Controls.Add(this.PdBtn);
            this.Controls.Add(this.LEDBtn);
            this.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWnd";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HWEC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWndClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LEDBtn;
        private System.Windows.Forms.Button PdBtn;
        private System.Windows.Forms.Button LcdBtn;
        private System.Windows.Forms.Button FanBtn;
        private System.Windows.Forms.Button LidBtn;
        private System.Windows.Forms.Button BatteryBtn;
        private System.Windows.Forms.Button ShippingBtn;
        private System.Windows.Forms.Button AllTestBtn;
        private System.Windows.Forms.Button AllExitBtn;
        private System.Windows.Forms.Button ThermalBtn;
        private System.Windows.Forms.Button ChargerBtn;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Button ShutdownCaseBtn;
        private System.Windows.Forms.Button ColdBootBtn;
        private System.Windows.Forms.Button CameraBtn;
        private System.Windows.Forms.Button KbdTestBtn;
    }
}