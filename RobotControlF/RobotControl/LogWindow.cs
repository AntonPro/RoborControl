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
    public partial class LogWindow : Form
    {
        Form1 MainWindow;
        SerialPort Connection;
        public AddDataDelegate MyDelegate;
        public delegate void AddDataDelegate(String myString);

        public LogWindow(SerialPort Port, Form1 Main)
        {
            this.Connection = Port;
            this.MainWindow = Main;
            this.MyDelegate = new AddDataDelegate(AddDataMethod);
            Connection.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            InitializeComponent();
        }

        public void AddDataMethod(String myString)
        {
            UARTOut.AppendText(myString);
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            sp.BaudRate = Connection.BaudRate;
            sp.DataBits = Connection.DataBits;
            string s = sp.ReadExisting();
            try
            {
                UARTOut.Invoke(this.MyDelegate, new Object[] { s });
            }
            catch
            {
                MessageBox.Show("Окно лога закрыто");
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Connection.WriteLine(UARTIn.Text);
            UARTOut.AppendText(UARTIn.Text + "\r\n");
            UARTIn.Text = "";
        }
    }
}
