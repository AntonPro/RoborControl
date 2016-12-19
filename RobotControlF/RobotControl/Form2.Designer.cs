namespace RobotControl
{
    partial class COMSettingsWindow
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
            if (disposing && (components != null))
            {
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
            this.COMName = new System.Windows.Forms.Label();
            this.BR600 = new System.Windows.Forms.RadioButton();
            this.BR1200 = new System.Windows.Forms.RadioButton();
            this.BR2400 = new System.Windows.Forms.RadioButton();
            this.BR19200 = new System.Windows.Forms.RadioButton();
            this.BR9600 = new System.Windows.Forms.RadioButton();
            this.BR4800 = new System.Windows.Forms.RadioButton();
            this.BR115200 = new System.Windows.Forms.RadioButton();
            this.BR57600 = new System.Windows.Forms.RadioButton();
            this.BR38400 = new System.Windows.Forms.RadioButton();
            this.BaudRateList = new System.Windows.Forms.Label();
            this.BaudRateBox = new System.Windows.Forms.GroupBox();
            this.DataBitsBox = new System.Windows.Forms.GroupBox();
            this.Bits8 = new System.Windows.Forms.RadioButton();
            this.Bits7 = new System.Windows.Forms.RadioButton();
            this.Bits6 = new System.Windows.Forms.RadioButton();
            this.Bits5 = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BaudRateBox.SuspendLayout();
            this.DataBitsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMName
            // 
            this.COMName.AutoSize = true;
            this.COMName.Location = new System.Drawing.Point(24, 2);
            this.COMName.Name = "COMName";
            this.COMName.Size = new System.Drawing.Size(0, 13);
            this.COMName.TabIndex = 0;
            // 
            // BR600
            // 
            this.BR600.AutoSize = true;
            this.BR600.Location = new System.Drawing.Point(15, 29);
            this.BR600.Name = "BR600";
            this.BR600.Size = new System.Drawing.Size(63, 17);
            this.BR600.TabIndex = 2;
            this.BR600.Text = "600 б/с";
            this.BR600.UseVisualStyleBackColor = true;
            // 
            // BR1200
            // 
            this.BR1200.AutoSize = true;
            this.BR1200.Location = new System.Drawing.Point(15, 52);
            this.BR1200.Name = "BR1200";
            this.BR1200.Size = new System.Drawing.Size(69, 17);
            this.BR1200.TabIndex = 3;
            this.BR1200.TabStop = true;
            this.BR1200.Text = "1200 б/с";
            this.BR1200.UseVisualStyleBackColor = true;
            // 
            // BR2400
            // 
            this.BR2400.AutoSize = true;
            this.BR2400.Location = new System.Drawing.Point(15, 75);
            this.BR2400.Name = "BR2400";
            this.BR2400.Size = new System.Drawing.Size(69, 17);
            this.BR2400.TabIndex = 4;
            this.BR2400.TabStop = true;
            this.BR2400.Text = "2400 б/с";
            this.BR2400.UseVisualStyleBackColor = true;
            // 
            // BR19200
            // 
            this.BR19200.AutoSize = true;
            this.BR19200.Location = new System.Drawing.Point(90, 75);
            this.BR19200.Name = "BR19200";
            this.BR19200.Size = new System.Drawing.Size(75, 17);
            this.BR19200.TabIndex = 7;
            this.BR19200.TabStop = true;
            this.BR19200.Text = "19200 б/с";
            this.BR19200.UseVisualStyleBackColor = true;
            // 
            // BR9600
            // 
            this.BR9600.AutoSize = true;
            this.BR9600.Location = new System.Drawing.Point(90, 52);
            this.BR9600.Name = "BR9600";
            this.BR9600.Size = new System.Drawing.Size(69, 17);
            this.BR9600.TabIndex = 6;
            this.BR9600.TabStop = true;
            this.BR9600.Text = "9600 б/с";
            this.BR9600.UseVisualStyleBackColor = true;
            // 
            // BR4800
            // 
            this.BR4800.AutoSize = true;
            this.BR4800.Location = new System.Drawing.Point(90, 29);
            this.BR4800.Name = "BR4800";
            this.BR4800.Size = new System.Drawing.Size(69, 17);
            this.BR4800.TabIndex = 5;
            this.BR4800.TabStop = true;
            this.BR4800.Text = "4800 б/с";
            this.BR4800.UseVisualStyleBackColor = true;
            // 
            // BR115200
            // 
            this.BR115200.AutoSize = true;
            this.BR115200.Location = new System.Drawing.Point(165, 75);
            this.BR115200.Name = "BR115200";
            this.BR115200.Size = new System.Drawing.Size(81, 17);
            this.BR115200.TabIndex = 10;
            this.BR115200.TabStop = true;
            this.BR115200.Text = "115200 б/с";
            this.BR115200.UseVisualStyleBackColor = true;
            // 
            // BR57600
            // 
            this.BR57600.AutoSize = true;
            this.BR57600.Location = new System.Drawing.Point(165, 52);
            this.BR57600.Name = "BR57600";
            this.BR57600.Size = new System.Drawing.Size(75, 17);
            this.BR57600.TabIndex = 9;
            this.BR57600.TabStop = true;
            this.BR57600.Text = "57600 б/с";
            this.BR57600.UseVisualStyleBackColor = true;
            // 
            // BR38400
            // 
            this.BR38400.AutoSize = true;
            this.BR38400.Location = new System.Drawing.Point(165, 29);
            this.BR38400.Name = "BR38400";
            this.BR38400.Size = new System.Drawing.Size(75, 17);
            this.BR38400.TabIndex = 8;
            this.BR38400.TabStop = true;
            this.BR38400.Text = "38400 б/с";
            this.BR38400.UseVisualStyleBackColor = true;
            // 
            // BaudRateList
            // 
            this.BaudRateList.AutoSize = true;
            this.BaudRateList.Location = new System.Drawing.Point(15, 6);
            this.BaudRateList.Name = "BaudRateList";
            this.BaudRateList.Size = new System.Drawing.Size(0, 13);
            this.BaudRateList.TabIndex = 11;
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.Controls.Add(this.BR2400);
            this.BaudRateBox.Controls.Add(this.COMName);
            this.BaudRateBox.Controls.Add(this.BR600);
            this.BaudRateBox.Controls.Add(this.BR1200);
            this.BaudRateBox.Controls.Add(this.BR4800);
            this.BaudRateBox.Controls.Add(this.BR9600);
            this.BaudRateBox.Controls.Add(this.BaudRateList);
            this.BaudRateBox.Controls.Add(this.BR19200);
            this.BaudRateBox.Controls.Add(this.BR115200);
            this.BaudRateBox.Controls.Add(this.BR38400);
            this.BaudRateBox.Controls.Add(this.BR57600);
            this.BaudRateBox.Location = new System.Drawing.Point(12, 12);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(263, 100);
            this.BaudRateBox.TabIndex = 17;
            this.BaudRateBox.TabStop = false;
            this.BaudRateBox.Text = "Скорость передачи (бит/с)";
            // 
            // DataBitsBox
            // 
            this.DataBitsBox.Controls.Add(this.Bits8);
            this.DataBitsBox.Controls.Add(this.Bits7);
            this.DataBitsBox.Controls.Add(this.Bits6);
            this.DataBitsBox.Controls.Add(this.Bits5);
            this.DataBitsBox.Location = new System.Drawing.Point(286, 14);
            this.DataBitsBox.Name = "DataBitsBox";
            this.DataBitsBox.Size = new System.Drawing.Size(129, 69);
            this.DataBitsBox.TabIndex = 18;
            this.DataBitsBox.TabStop = false;
            this.DataBitsBox.Text = "Биты данных";
            // 
            // Bits8
            // 
            this.Bits8.AutoSize = true;
            this.Bits8.Location = new System.Drawing.Point(74, 46);
            this.Bits8.Name = "Bits8";
            this.Bits8.Size = new System.Drawing.Size(51, 17);
            this.Bits8.TabIndex = 20;
            this.Bits8.TabStop = true;
            this.Bits8.Text = "8 бит";
            this.Bits8.UseVisualStyleBackColor = true;
            // 
            // Bits7
            // 
            this.Bits7.AutoSize = true;
            this.Bits7.Location = new System.Drawing.Point(74, 23);
            this.Bits7.Name = "Bits7";
            this.Bits7.Size = new System.Drawing.Size(51, 17);
            this.Bits7.TabIndex = 19;
            this.Bits7.TabStop = true;
            this.Bits7.Text = "7 бит";
            this.Bits7.UseVisualStyleBackColor = true;
            // 
            // Bits6
            // 
            this.Bits6.AutoSize = true;
            this.Bits6.Location = new System.Drawing.Point(17, 46);
            this.Bits6.Name = "Bits6";
            this.Bits6.Size = new System.Drawing.Size(51, 17);
            this.Bits6.TabIndex = 18;
            this.Bits6.TabStop = true;
            this.Bits6.Text = "6 бит";
            this.Bits6.UseVisualStyleBackColor = true;
            // 
            // Bits5
            // 
            this.Bits5.AutoSize = true;
            this.Bits5.Location = new System.Drawing.Point(17, 23);
            this.Bits5.Name = "Bits5";
            this.Bits5.Size = new System.Drawing.Size(51, 17);
            this.Bits5.TabIndex = 17;
            this.Bits5.TabStop = true;
            this.Bits5.Text = "5 бит";
            this.Bits5.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(286, 89);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // COMSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 117);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataBitsBox);
            this.Controls.Add(this.BaudRateBox);
            this.Name = "COMSettingsWindow";
            this.Text = "Настройки подключения";
            this.Load += new System.EventHandler(this.COMSettingsWindow_Load);
            this.BaudRateBox.ResumeLayout(false);
            this.BaudRateBox.PerformLayout();
            this.DataBitsBox.ResumeLayout(false);
            this.DataBitsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label COMName;
        private System.Windows.Forms.RadioButton BR600;
        private System.Windows.Forms.RadioButton BR1200;
        private System.Windows.Forms.RadioButton BR2400;
        private System.Windows.Forms.RadioButton BR19200;
        private System.Windows.Forms.RadioButton BR9600;
        private System.Windows.Forms.RadioButton BR4800;
        private System.Windows.Forms.RadioButton BR115200;
        private System.Windows.Forms.RadioButton BR57600;
        private System.Windows.Forms.RadioButton BR38400;
        private System.Windows.Forms.Label BaudRateList;
        private System.Windows.Forms.GroupBox BaudRateBox;
        private System.Windows.Forms.GroupBox DataBitsBox;
        private System.Windows.Forms.RadioButton Bits8;
        private System.Windows.Forms.RadioButton Bits7;
        private System.Windows.Forms.RadioButton Bits6;
        private System.Windows.Forms.RadioButton Bits5;
        private System.Windows.Forms.Button SaveButton;
    }
}