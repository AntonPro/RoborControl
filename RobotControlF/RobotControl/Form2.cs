using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RobotControl
{
    public partial class COMSettingsWindow : Form
    {
        public int BaudRate;
        public int DataBits;
        SerialPort Port;
        Form1 MainWindow;

        public COMSettingsWindow(SerialPort Port, Form1 Window)
            
        {

            InitializeComponent();
            this.MainWindow = Window;
            this.Port = Port;
            switch (Port.BaudRate)
            {
                case 600:
                    BR600.Checked = true;
                    break;
                case 1200:
                    BR1200.Checked = true;
                    break;
                case 2400:
                    BR2400.Checked = true;
                    break;
                case 4800:
                    BR4800.Checked = true;
                    break;
                case 9600:
                    BR9600.Checked = true;
                    break;
                case 19200:
                    BR19200.Checked = true;
                    break;
                case 38400:
                    BR38400.Checked = true;
                    break;
                case 57600:
                    BR57600.Checked = true;
                    break;
                case 115200:
                    BR115200.Checked = true;
                    break;
            }                
            switch (Port.DataBits)
            {
                case 5:
                    Bits5.Checked = true;
                    break;
                case 6:
                    Bits6.Checked = true;
                    break;
                case 7:
                    Bits7.Checked = true;
                    break;
                case 8:
                    Bits8.Checked = true;
                    break;
            }
      
        }

        private void COMSettingsWindow_Load(object sender, EventArgs e)
        {
           // COMName = 
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (BR600.Checked) BaudRate = 600;
            if (BR1200.Checked) BaudRate = 1200;
            if (BR2400.Checked) BaudRate = 2400;
            if (BR4800.Checked) BaudRate = 4800;
            if (BR9600.Checked) BaudRate = 9600;
            if (BR19200.Checked) BaudRate = 19200;
            if (BR38400.Checked) BaudRate = 38400;
            if (BR57600.Checked) BaudRate = 57600;
            if (BR115200.Checked) BaudRate = 115200;
            if (Bits5.Checked) DataBits = 5;
            if (Bits6.Checked) DataBits = 6;
            if (Bits7.Checked) DataBits = 7;
            if (Bits8.Checked) DataBits = 8;


            for (int count = 0; count < MainWindow.Connections.Count; count++ )
            {
                if (MainWindow.Connections[count].PortName == Port.PortName)
                {
                    MainWindow.Connections[count].BaudRate = BaudRate;
                    MainWindow.Connections[count].DataBits = DataBits;
                    MainWindow.Refresh();
                }
            }

            this.Close();
        }



    }
}
