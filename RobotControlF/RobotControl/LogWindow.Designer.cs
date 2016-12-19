namespace RobotControl
{
    partial class LogWindow
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
            this.UARTOut = new System.Windows.Forms.TextBox();
            this.UARTIn = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.UARTOutScroll = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // UARTOut
            // 
            this.UARTOut.Location = new System.Drawing.Point(13, 13);
            this.UARTOut.Multiline = true;
            this.UARTOut.Name = "UARTOut";
            this.UARTOut.ReadOnly = true;
            this.UARTOut.Size = new System.Drawing.Size(1004, 467);
            this.UARTOut.TabIndex = 0;
            // 
            // UARTIn
            // 
            this.UARTIn.Location = new System.Drawing.Point(122, 486);
            this.UARTIn.Name = "UARTIn";
            this.UARTIn.Size = new System.Drawing.Size(895, 20);
            this.UARTIn.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(13, 486);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(103, 20);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // UARTOutScroll
            // 
            this.UARTOutScroll.Location = new System.Drawing.Point(995, 13);
            this.UARTOutScroll.Name = "UARTOutScroll";
            this.UARTOutScroll.Size = new System.Drawing.Size(21, 467);
            this.UARTOutScroll.TabIndex = 3;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.UARTOutScroll);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.UARTIn);
            this.Controls.Add(this.UARTOut);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UARTOut;
        private System.Windows.Forms.TextBox UARTIn;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.VScrollBar UARTOutScroll;
    }
}