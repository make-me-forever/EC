namespace HwEcAuto
{
    partial class LEDWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEDWnd));
            this.FnBtn = new System.Windows.Forms.Button();
            this.CapsBtn = new System.Windows.Forms.Button();
            this.NumBtn = new System.Windows.Forms.Button();
            this.MicBtn = new System.Windows.Forms.Button();
            this.ResetLEDBtn = new System.Windows.Forms.Button();
            this.ExitLEDBtn = new System.Windows.Forms.Button();
            this.AllLEDBtn = new System.Windows.Forms.Button();
            this.AllBlinkBtn = new System.Windows.Forms.Button();
            this.ChargerBtn = new System.Windows.Forms.Button();
            this.KblBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FnBtn
            // 
            this.FnBtn.BackColor = System.Drawing.Color.White;
            this.FnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FnBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FnBtn.ForeColor = System.Drawing.Color.Black;
            this.FnBtn.Location = new System.Drawing.Point(55, 60);
            this.FnBtn.Name = "FnBtn";
            this.FnBtn.Size = new System.Drawing.Size(100, 50);
            this.FnBtn.TabIndex = 1;
            this.FnBtn.Text = "Fn";
            this.FnBtn.UseVisualStyleBackColor = false;
            this.FnBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FnMake);
            this.FnBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FnBreak);
            // 
            // CapsBtn
            // 
            this.CapsBtn.BackColor = System.Drawing.Color.White;
            this.CapsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CapsBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CapsBtn.ForeColor = System.Drawing.Color.Black;
            this.CapsBtn.Location = new System.Drawing.Point(185, 60);
            this.CapsBtn.Name = "CapsBtn";
            this.CapsBtn.Size = new System.Drawing.Size(100, 50);
            this.CapsBtn.TabIndex = 2;
            this.CapsBtn.Text = "Caps";
            this.CapsBtn.UseVisualStyleBackColor = false;
            this.CapsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CapsMake);
            this.CapsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CapsBreak);
            // 
            // NumBtn
            // 
            this.NumBtn.BackColor = System.Drawing.Color.White;
            this.NumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NumBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumBtn.ForeColor = System.Drawing.Color.Black;
            this.NumBtn.Location = new System.Drawing.Point(315, 60);
            this.NumBtn.Name = "NumBtn";
            this.NumBtn.Size = new System.Drawing.Size(100, 50);
            this.NumBtn.TabIndex = 3;
            this.NumBtn.Text = "Num";
            this.NumBtn.UseVisualStyleBackColor = false;
            this.NumBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NumMake);
            this.NumBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NumBreak);
            // 
            // MicBtn
            // 
            this.MicBtn.BackColor = System.Drawing.Color.White;
            this.MicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MicBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MicBtn.ForeColor = System.Drawing.Color.Black;
            this.MicBtn.Location = new System.Drawing.Point(445, 60);
            this.MicBtn.Name = "MicBtn";
            this.MicBtn.Size = new System.Drawing.Size(100, 50);
            this.MicBtn.TabIndex = 4;
            this.MicBtn.Text = "Mic";
            this.MicBtn.UseVisualStyleBackColor = false;
            this.MicBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MicMake);
            this.MicBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MicBreak);
            // 
            // ResetLEDBtn
            // 
            this.ResetLEDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResetLEDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetLEDBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ResetLEDBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetLEDBtn.Location = new System.Drawing.Point(55, 240);
            this.ResetLEDBtn.Name = "ResetLEDBtn";
            this.ResetLEDBtn.Size = new System.Drawing.Size(100, 50);
            this.ResetLEDBtn.TabIndex = 5;
            this.ResetLEDBtn.Text = "ResetLED";
            this.ResetLEDBtn.UseVisualStyleBackColor = false;
            this.ResetLEDBtn.Click += new System.EventHandler(this.ResetLEDClick);
            // 
            // ExitLEDBtn
            // 
            this.ExitLEDBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExitLEDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitLEDBtn.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.ExitLEDBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitLEDBtn.Location = new System.Drawing.Point(445, 240);
            this.ExitLEDBtn.Name = "ExitLEDBtn";
            this.ExitLEDBtn.Size = new System.Drawing.Size(100, 50);
            this.ExitLEDBtn.TabIndex = 6;
            this.ExitLEDBtn.Text = "ExitLED";
            this.ExitLEDBtn.UseVisualStyleBackColor = false;
            this.ExitLEDBtn.Click += new System.EventHandler(this.ExitLEDClick);
            // 
            // AllLEDBtn
            // 
            this.AllLEDBtn.BackColor = System.Drawing.Color.White;
            this.AllLEDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllLEDBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllLEDBtn.ForeColor = System.Drawing.Color.Black;
            this.AllLEDBtn.Location = new System.Drawing.Point(445, 150);
            this.AllLEDBtn.Name = "AllLEDBtn";
            this.AllLEDBtn.Size = new System.Drawing.Size(100, 50);
            this.AllLEDBtn.TabIndex = 10;
            this.AllLEDBtn.Text = "AllLED";
            this.AllLEDBtn.UseVisualStyleBackColor = false;
            this.AllLEDBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllLEDMake);
            this.AllLEDBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AllLEDBreak);
            // 
            // AllBlinkBtn
            // 
            this.AllBlinkBtn.BackColor = System.Drawing.Color.White;
            this.AllBlinkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllBlinkBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllBlinkBtn.ForeColor = System.Drawing.Color.Black;
            this.AllBlinkBtn.Location = new System.Drawing.Point(315, 150);
            this.AllBlinkBtn.Name = "AllBlinkBtn";
            this.AllBlinkBtn.Size = new System.Drawing.Size(100, 50);
            this.AllBlinkBtn.TabIndex = 9;
            this.AllBlinkBtn.Text = "AllBlink";
            this.AllBlinkBtn.UseVisualStyleBackColor = false;
            this.AllBlinkBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllBlinkMake);
            this.AllBlinkBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AllBlinkBreak);
            // 
            // ChargerBtn
            // 
            this.ChargerBtn.BackColor = System.Drawing.Color.White;
            this.ChargerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChargerBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChargerBtn.ForeColor = System.Drawing.Color.Black;
            this.ChargerBtn.Location = new System.Drawing.Point(55, 150);
            this.ChargerBtn.Name = "ChargerBtn";
            this.ChargerBtn.Size = new System.Drawing.Size(100, 50);
            this.ChargerBtn.TabIndex = 8;
            this.ChargerBtn.Text = "Charger";
            this.ChargerBtn.UseVisualStyleBackColor = false;
            this.ChargerBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChargerMake);
            this.ChargerBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChargerBreak);
            // 
            // KblBtn
            // 
            this.KblBtn.BackColor = System.Drawing.Color.White;
            this.KblBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KblBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KblBtn.ForeColor = System.Drawing.Color.Black;
            this.KblBtn.Location = new System.Drawing.Point(185, 150);
            this.KblBtn.Name = "KblBtn";
            this.KblBtn.Size = new System.Drawing.Size(100, 50);
            this.KblBtn.TabIndex = 7;
            this.KblBtn.Text = "Kbl";
            this.KblBtn.UseVisualStyleBackColor = false;
            this.KblBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KblMake);
            this.KblBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KblBreak);
            // 
            // LEDWnd
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(606, 335);
            this.Controls.Add(this.AllLEDBtn);
            this.Controls.Add(this.AllBlinkBtn);
            this.Controls.Add(this.ChargerBtn);
            this.Controls.Add(this.KblBtn);
            this.Controls.Add(this.ExitLEDBtn);
            this.Controls.Add(this.ResetLEDBtn);
            this.Controls.Add(this.MicBtn);
            this.Controls.Add(this.NumBtn);
            this.Controls.Add(this.CapsBtn);
            this.Controls.Add(this.FnBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LEDWnd";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LEDWnd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LEDWndClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FnBtn;
        private System.Windows.Forms.Button CapsBtn;
        private System.Windows.Forms.Button NumBtn;
        private System.Windows.Forms.Button MicBtn;
        private System.Windows.Forms.Button ResetLEDBtn;
        private System.Windows.Forms.Button ExitLEDBtn;
        private System.Windows.Forms.Button AllLEDBtn;
        private System.Windows.Forms.Button AllBlinkBtn;
        private System.Windows.Forms.Button ChargerBtn;
        private System.Windows.Forms.Button KblBtn;
    }
}