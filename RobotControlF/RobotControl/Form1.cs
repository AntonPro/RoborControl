
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

    public partial class Form1 : Form

    {
        public List<SerialPort> Connections;

        Brush BlackSh = new SolidBrush(Color.Black);
        Pen BlackShEl = new Pen(Brushes.DimGray, 8);
        const int  JoyStickHeight = 50;
        const int JoyStickWidth = 50;
        bool IsPressed = false;
        string[] ports;

        byte RightSpeed = 0;
        byte LeftSpeed = 0;

        int JoyCenterX;
        int JoyCenterY;
        double X;
        double Y;
        int Ras;

        int Mode = 0; // SpeedMode = 0; WayMode = 1; AngleMode = 2;

        public Form1()
        {

            InitializeComponent();
            Connections = new List<SerialPort>();
            switch (Mode)
            {
                case 0:
                    SpeedMode.Checked = true;
                    WayMode.Checked = false;
                    AngleMode.Checked = false;
                    break;
                case 1:
                    SpeedMode.Checked = false;
                    WayMode.Checked = true;
                    AngleMode.Checked = false;
                    break;
                case 2:
                    SpeedMode.Checked = false;
                    WayMode.Checked = false;
                    AngleMode.Checked = true;
                    break;
            }

            
        }

        private void Connect()
        {
            int count = 0;
            foreach(string port in ports){
                switch (port)
                {
                    case "COM1":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM1Connect.Text = "Отключиться";
                            OpenLog1.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM1Connect.Text = "Подключиться";
                            OpenLog1.Enabled = false;
                        }
                        break;
                    case "COM2":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM2Connect.Text = "Отключиться";
                            OpenLog2.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM2Connect.Text = "Подключиться";
                            OpenLog2.Enabled = false;
                        }
                        break;
                    case "COM3":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM3Connect.Text = "Отключиться";
                            OpenLog3.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM3Connect.Text = "Подключиться";
                            OpenLog3.Enabled = false;
                        }
                        break;
                    case "COM4":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM4Connect.Text = "Отключиться";
                            OpenLog4.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM4Connect.Text = "Подключиться";
                            OpenLog4.Enabled = false;
                        }
                        break;
                    case "COM5":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM5Connect.Text = "Отключиться";
                            OpenLog5.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM5Connect.Text = "Подключиться";
                            OpenLog5.Enabled = false;
                        }
                        break;
                    case "COM6":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM6Connect.Text = "Отключиться";
                            OpenLog6.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM6Connect.Text = "Подключиться";
                            OpenLog6.Enabled = false;
                        }
                        break;
                    case "COM7":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM7Connect.Text = "Отключиться";
                            OpenLog7.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM7Connect.Text = "Подключиться";
                            OpenLog7.Enabled = false;
                        }
                        break;
                    case "COM8":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM8Connect.Text = "Отключиться";
                            OpenLog8.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM8Connect.Text = "Подключиться";
                            OpenLog8.Enabled = false;
                        }
                        break;
                    case "COM9":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM9Connect.Text = "Отключиться";
                            OpenLog9.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM9Connect.Text = "Подключиться";
                            OpenLog9.Enabled = false;
                        }
                        break;
                    case "COM10":
                        if (Connections[count].IsOpen == false)
                        {

                            Connections[count].Open();
                            COM10Connect.Text = "Отключиться";
                            OpenLog10.Enabled = true;
                        }
                        else
                        {
                            Connections[count].Close();
                            COM10Connect.Text = "Подключиться";
                            OpenLog10.Enabled = false;
                        }
                        break;
                }
            }
        }

        private void COM1Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM1Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM1")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }          
        }

        private void COM2Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM2Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM2")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM3Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM3Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM3")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                    break;
                }
            }
        }

        private void COM4Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM4Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM4")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            };
        }

        private void COM5Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM5Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM5")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM6Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM6Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM6")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM7Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM7Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM7")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM8Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM8Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM8")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM9Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM9Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM9")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void COM10Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void COM10Settings_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM10")
                {
                    RobotControl.COMSettingsWindow SettingsWindow = new COMSettingsWindow(Port, this);
                    SettingsWindow.Show();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            foreach (string port in ports){
                switch (port)
                {
                    case "COM1":
                        COM1Menu.Visible = true;
                        Connections.Add(new SerialPort("COM1"));
                        break;
                    case "COM2":
                        COM2Menu.Visible = true;
                        Connections.Add(new SerialPort("COM2"));
                        break;
                    case "COM3":
                        COM3Menu.Visible = true;
                        Connections.Add(new SerialPort("COM3"));
                        break;
                    case "COM4":
                        COM4Menu.Visible = true;
                        Connections.Add(new SerialPort("COM4"));
                        break;
                    case "COM5":
                        COM5Menu.Visible = true;
                        Connections.Add(new SerialPort("COM5"));
                        break;
                    case "COM6":
                        COM6Menu.Visible = true;
                        Connections.Add(new SerialPort("COM6"));
                        break;
                    case "COM7":
                        COM7Menu.Visible = true;
                        Connections.Add(new SerialPort("COM7"));
                        break;
                    case "COM8":
                        COM8Menu.Visible = true;
                        Connections.Add(new SerialPort("COM8"));
                        break;
                    case "COM9":
                        COM9Menu.Visible = true;
                        Connections.Add(new SerialPort("COM9"));
                        break;
                    case "COM10":
                        COM10Menu.Visible = true;
                        Connections.Add(new SerialPort("COM10"));
                        break;
                }
            }
        }

        private void OpenLog1_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM1") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog2_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM2") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog3_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM3") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog4_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM4") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog5_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM5") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog6_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM6") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog7_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM7") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog8_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM8") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog9_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM9") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void OpenLog10_Click(object sender, EventArgs e)
        {
            foreach (SerialPort Port in Connections)
            {
                if ((Port.PortName == "COM10") && Port.IsOpen)
                {
                    RobotControl.LogWindow LogWindow = new LogWindow(Port, this);
                    LogWindow.Show();
                }
            }
        }

        private void SpeedMode_Click(object sender, EventArgs e)
        {
            Mode = 0;
            SpeedMode.Checked = true;
            WayMode.Checked = false;
            AngleMode.Checked = false;
            SpeedModeBox.Enabled = true;
            WayModeBox.Enabled = false;
            AngleModeBox.Enabled = false;
        }

        private void WayMode_Click(object sender, EventArgs e)
        {
            Mode = 1;
            SpeedMode.Checked = false;
            WayMode.Checked = true;
            AngleMode.Checked = false;
            SpeedModeBox.Enabled = false;
            WayModeBox.Enabled = true;
            AngleModeBox.Enabled = false;
        }

        private void AngleMode_Click(object sender, EventArgs e)
        {
            Mode = 3;
            SpeedMode.Checked = false;
            WayMode.Checked = false;
            AngleMode.Checked = true;
            SpeedModeBox.Enabled = false;
            WayModeBox.Enabled = false;
            AngleModeBox.Enabled = true;
        }

        private void ControlMode_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForwardBut.Text = "\u2191";
            BackwardBut.Text = "\u2193";
            RightTurnBut.Text = "\u21BB";
            LeftTurnBut.Text = "\u21BA";
            //Joy = Image.FromFile(@"C:\Users\ANTON\Documents\Visual Studio 2013\Projects\RobotControl\JoyStick.png");
            JoyCenterX = 65;
            JoyCenterY = 65;    
        }

        private void ForwardBut_MouseDown(object sender, MouseEventArgs e)
        {
            LeftSpeed = (byte)Accelerometer.Value;
            RightSpeed = (byte)Accelerometer.Value;

            foreach (SerialPort Port in Connections)
            {
                byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                Port.Write(bytestosend, 0, 5);
             
            }
        }

        private void ForwardBut_MouseUp(object sender, MouseEventArgs e)
        {
            LeftSpeed = 0;
            RightSpeed = 0;


            foreach (SerialPort Port in Connections)
            {
                if (Port.PortName == "COM3")
                {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);

                }

            }
        }

        private void BackwardBut_MouseDown(object sender, MouseEventArgs e)
        {
            LeftSpeed = (byte)-(Accelerometer.Value);
            RightSpeed = (byte)-(Accelerometer.Value);

            foreach (SerialPort Port in Connections)
            {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);

            }
        }

        private void BackwardBut_MouseUp(object sender, MouseEventArgs e)
        {
            LeftSpeed = 0;
            RightSpeed = 0;

            foreach (SerialPort Port in Connections)
            {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);
            }
        }

        private void LeftTurnBut_MouseDown(object sender, MouseEventArgs e)
        {
            int diff = 2 * (byte)Accelerometer.Value / TurnRadius.Value;
            RightSpeed = (byte)Accelerometer.Value;
            LeftSpeed = (byte)(RightSpeed - (byte)diff);

            foreach (SerialPort Port in Connections)
            {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);
            }
        }

        private void LeftTurnBut_MouseUp(object sender, MouseEventArgs e)
        {
            LeftSpeed = 0;
            RightSpeed = 0;

            foreach (SerialPort Port in Connections)
            {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);
            }
        }

        private void RightTurnBut_MouseDown(object sender, MouseEventArgs e)
        {
            int diff = 2 * (byte)Accelerometer.Value / TurnRadius.Value;
            LeftSpeed = (byte)Accelerometer.Value;
            RightSpeed = (byte)(LeftSpeed - (byte)diff);

            foreach (SerialPort Port in Connections)
            {                
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);
            }
        }

        private void RightTurnBut_MouseUp(object sender, MouseEventArgs e)
        {
            LeftSpeed = 0;
            RightSpeed = 0;

            foreach (SerialPort Port in Connections)
            {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);
            }
        }

        private void JoyStick_MouseMove(object sender, MouseEventArgs e)
        {
            double r = 0;
            double ax = 0, ay = 0;
            if (IsPressed)
            {
                JoyCenterX = (e.X) -JoyStickWidth / 2;
                JoyCenterY = (e.Y) -JoyStickHeight / 2;
                if ((Math.Sqrt(Math.Pow((JoyCenterX - 65), 2) + Math.Pow((JoyCenterY - 65), 2))) > 60)
                {
                    //*****************************************************  РАБОТАЕТ
                        float a, b, c;

                        a = 90 - e.Y;
                        b = e.X - 90;
                        c = 90*( e.Y -  e.Y);
                        r = 60;
                        double mult = Math.Sqrt(r*r / (a * a + b * b));                      
                        ax = 90 + b * mult;
                        ay = 90 - a * mult;
                        JoyCenterX = (int)ax - JoyStickWidth / 2;
                        JoyCenterY = (int)ay - JoyStickHeight / 2;



                }
                
                JoyStick.Invalidate();
            }
        }

        private void JoyStick_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressed = false;
            JoyCenterX = 65;
            JoyCenterY = 65;
            JoyStick.Invalidate();
        }

        private void JoyStick_MouseLeave(object sender, EventArgs e)
        {
          /*  IsPressed = false;
            JoyCenterX = 50;
            JoyCenterY = 50;
            JoyStick.Invalidate();*/
        }

        private void JoyStick_MouseDown(object sender, MouseEventArgs e)
        {
            IsPressed = true;
              JoyStick.Invalidate();
        }

        private void DrawJoyStick(Graphics g)
        {

            g.FillEllipse(BlackSh, JoyCenterX, JoyCenterY, JoyStickHeight, JoyStickWidth);
            g.DrawEllipse(BlackShEl, JoyCenterX, JoyCenterY, JoyStickHeight, JoyStickWidth);
            JoyStickToSpeed();
        }

        private void JoyStick_Paint(object sender, PaintEventArgs e)
        {
            DrawJoyStick(e.Graphics);
        }

        private void JoyStickToSpeed()
        {
            float CenterX = JoyCenterX - 65;
            float CenterY = -JoyCenterY + 65;
            X =( 1 / Math.Sqrt(2)*CenterX + 1 / Math.Sqrt(2)*CenterY) / 50;
            Y =( -1 / Math.Sqrt(2) * CenterX + 1 / Math.Sqrt(2) * CenterY ) / 50; // 50 ограничение по максимальной скорости

            X *= Accelerometer.Value;
            Y *= Accelerometer.Value;
            LeftSpeed = (byte)X;
            RightSpeed = (byte)Y;
          /*  textBox1.Text = "";
            byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
           // Port.Write(bytestosend, 0, 5);
            foreach (byte b in bytestosend)
            {
                textBox1.Text += b.ToString();
            }
            */
            
            foreach (SerialPort Port in Connections)
            {
                if (Port.IsOpen)
                {
                    byte[] bytestosend = new byte[] { 0x00, LeftSpeed, RightSpeed, 0x0A, 0x0D };
                    Port.Write(bytestosend, 0, 5);

                }
            }          
        }

        private void JoyStickControl_Click(object sender, EventArgs e)
        {
            JoyStickControl.Checked = true;
            ButtonsControl.Enabled = false;
            ButtonsControl.Checked = false;
            JoyStick.Enabled = true;
            ForwardBut.Enabled = false;
            BackwardBut.Enabled = false;
            LeftTurnBut.Enabled = false;
            RightTurnBut.Enabled = false;
            TurnRadius.Enabled = false;

        }

        private void ButtonsControl_Click(object sender, EventArgs e)
        {
            JoyStickControl.Checked = false;
            ButtonsControl.Enabled = true;
            ButtonsControl.Checked = true;
            JoyStick.Enabled = false;
            ForwardBut.Enabled = true;
            BackwardBut.Enabled = true;
            LeftTurnBut.Enabled = true;
            RightTurnBut.Enabled = true;
            TurnRadius.Enabled = true;
        }
        
    
    }
}
