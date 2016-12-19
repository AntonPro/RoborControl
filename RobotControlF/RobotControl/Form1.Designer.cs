namespace RobotControl
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.COM1Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM1Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM1Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM2Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM2Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM2Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog2 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM3Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM3Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM3Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog3 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM4Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM4Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM4Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog4 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM5Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM5Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM5Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog5 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM6Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM6Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM6Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog6 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM7Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM7Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM7Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog7 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM8Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM8Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM8Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog8 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM9Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM9Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM9Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog9 = new System.Windows.Forms.ToolStripMenuItem();
            this.COM10Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.COM10Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.COM10Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenLog10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlMode = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedMode = new System.Windows.Forms.ToolStripMenuItem();
            this.JoyStickControl = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonsControl = new System.Windows.Forms.ToolStripMenuItem();
            this.WayMode = new System.Windows.Forms.ToolStripMenuItem();
            this.AngleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SpeedModeBox = new System.Windows.Forms.GroupBox();
            this.JoyStick = new System.Windows.Forms.PictureBox();
            this.LeftTurnBut = new System.Windows.Forms.Button();
            this.RightTurnBut = new System.Windows.Forms.Button();
            this.BackwardBut = new System.Windows.Forms.Button();
            this.ForwardBut = new System.Windows.Forms.Button();
            this.WayModeBox = new System.Windows.Forms.GroupBox();
            this.AngleModeBox = new System.Windows.Forms.GroupBox();
            this.Accelerometer = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TurnRadius = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SpeedModeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JoyStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accelerometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connection,
            this.ControlMode});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Connection
            // 
            this.Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM1Menu,
            this.COM2Menu,
            this.COM3Menu,
            this.COM4Menu,
            this.COM5Menu,
            this.COM6Menu,
            this.COM7Menu,
            this.COM8Menu,
            this.COM9Menu,
            this.COM10Menu});
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(97, 20);
            this.Connection.Text = "Подключение";
            // 
            // COM1Menu
            // 
            this.COM1Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM1Connect,
            this.COM1Settings,
            this.OpenLog1});
            this.COM1Menu.Name = "COM1Menu";
            this.COM1Menu.Size = new System.Drawing.Size(117, 22);
            this.COM1Menu.Text = "COM 1";
            this.COM1Menu.Visible = false;
            // 
            // COM1Connect
            // 
            this.COM1Connect.Name = "COM1Connect";
            this.COM1Connect.Size = new System.Drawing.Size(156, 22);
            this.COM1Connect.Text = "Подключиться";
            this.COM1Connect.Click += new System.EventHandler(this.COM1Connect_Click);
            // 
            // COM1Settings
            // 
            this.COM1Settings.Name = "COM1Settings";
            this.COM1Settings.Size = new System.Drawing.Size(156, 22);
            this.COM1Settings.Text = "Настройки";
            this.COM1Settings.Click += new System.EventHandler(this.COM1Settings_Click);
            // 
            // OpenLog1
            // 
            this.OpenLog1.Enabled = false;
            this.OpenLog1.Name = "OpenLog1";
            this.OpenLog1.Size = new System.Drawing.Size(156, 22);
            this.OpenLog1.Text = "Открыть лог";
            this.OpenLog1.Click += new System.EventHandler(this.OpenLog1_Click);
            // 
            // COM2Menu
            // 
            this.COM2Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM2Connect,
            this.COM2Settings,
            this.OpenLog2});
            this.COM2Menu.Name = "COM2Menu";
            this.COM2Menu.Size = new System.Drawing.Size(117, 22);
            this.COM2Menu.Text = "COM 2";
            this.COM2Menu.Visible = false;
            // 
            // COM2Connect
            // 
            this.COM2Connect.Name = "COM2Connect";
            this.COM2Connect.Size = new System.Drawing.Size(156, 22);
            this.COM2Connect.Text = "Подключиться";
            this.COM2Connect.Click += new System.EventHandler(this.COM2Connect_Click);
            // 
            // COM2Settings
            // 
            this.COM2Settings.Name = "COM2Settings";
            this.COM2Settings.Size = new System.Drawing.Size(156, 22);
            this.COM2Settings.Text = "Настройки";
            this.COM2Settings.Click += new System.EventHandler(this.COM2Settings_Click);
            // 
            // OpenLog2
            // 
            this.OpenLog2.Enabled = false;
            this.OpenLog2.Name = "OpenLog2";
            this.OpenLog2.Size = new System.Drawing.Size(156, 22);
            this.OpenLog2.Text = "Открыть лог";
            this.OpenLog2.Click += new System.EventHandler(this.OpenLog2_Click);
            // 
            // COM3Menu
            // 
            this.COM3Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM3Connect,
            this.COM3Settings,
            this.OpenLog3});
            this.COM3Menu.Name = "COM3Menu";
            this.COM3Menu.Size = new System.Drawing.Size(117, 22);
            this.COM3Menu.Text = "COM 3";
            this.COM3Menu.Visible = false;
            // 
            // COM3Connect
            // 
            this.COM3Connect.Name = "COM3Connect";
            this.COM3Connect.Size = new System.Drawing.Size(156, 22);
            this.COM3Connect.Text = "Подключиться";
            this.COM3Connect.Click += new System.EventHandler(this.COM3Connect_Click);
            // 
            // COM3Settings
            // 
            this.COM3Settings.Name = "COM3Settings";
            this.COM3Settings.Size = new System.Drawing.Size(156, 22);
            this.COM3Settings.Text = "Настройки";
            this.COM3Settings.Click += new System.EventHandler(this.COM3Settings_Click);
            // 
            // OpenLog3
            // 
            this.OpenLog3.Enabled = false;
            this.OpenLog3.Name = "OpenLog3";
            this.OpenLog3.Size = new System.Drawing.Size(156, 22);
            this.OpenLog3.Text = "Открыть лог";
            this.OpenLog3.Click += new System.EventHandler(this.OpenLog3_Click);
            // 
            // COM4Menu
            // 
            this.COM4Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM4Connect,
            this.COM4Settings,
            this.OpenLog4});
            this.COM4Menu.Name = "COM4Menu";
            this.COM4Menu.Size = new System.Drawing.Size(117, 22);
            this.COM4Menu.Text = "COM 4";
            this.COM4Menu.Visible = false;
            // 
            // COM4Connect
            // 
            this.COM4Connect.Name = "COM4Connect";
            this.COM4Connect.Size = new System.Drawing.Size(156, 22);
            this.COM4Connect.Text = "Подключиться";
            this.COM4Connect.Click += new System.EventHandler(this.COM4Connect_Click);
            // 
            // COM4Settings
            // 
            this.COM4Settings.Name = "COM4Settings";
            this.COM4Settings.Size = new System.Drawing.Size(156, 22);
            this.COM4Settings.Text = "Настройки";
            this.COM4Settings.Click += new System.EventHandler(this.COM4Settings_Click);
            // 
            // OpenLog4
            // 
            this.OpenLog4.Enabled = false;
            this.OpenLog4.Name = "OpenLog4";
            this.OpenLog4.Size = new System.Drawing.Size(156, 22);
            this.OpenLog4.Text = "Открыть лог";
            this.OpenLog4.Click += new System.EventHandler(this.OpenLog4_Click);
            // 
            // COM5Menu
            // 
            this.COM5Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM5Connect,
            this.COM5Settings,
            this.OpenLog5});
            this.COM5Menu.Name = "COM5Menu";
            this.COM5Menu.Size = new System.Drawing.Size(117, 22);
            this.COM5Menu.Text = "COM 5";
            this.COM5Menu.Visible = false;
            // 
            // COM5Connect
            // 
            this.COM5Connect.Name = "COM5Connect";
            this.COM5Connect.Size = new System.Drawing.Size(156, 22);
            this.COM5Connect.Text = "Подключиться";
            this.COM5Connect.Click += new System.EventHandler(this.COM5Connect_Click);
            // 
            // COM5Settings
            // 
            this.COM5Settings.Name = "COM5Settings";
            this.COM5Settings.Size = new System.Drawing.Size(156, 22);
            this.COM5Settings.Text = "Настройки";
            this.COM5Settings.Click += new System.EventHandler(this.COM5Settings_Click);
            // 
            // OpenLog5
            // 
            this.OpenLog5.Enabled = false;
            this.OpenLog5.Name = "OpenLog5";
            this.OpenLog5.Size = new System.Drawing.Size(156, 22);
            this.OpenLog5.Text = "Открыть лог";
            this.OpenLog5.Click += new System.EventHandler(this.OpenLog5_Click);
            // 
            // COM6Menu
            // 
            this.COM6Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM6Connect,
            this.COM6Settings,
            this.OpenLog6});
            this.COM6Menu.Name = "COM6Menu";
            this.COM6Menu.Size = new System.Drawing.Size(117, 22);
            this.COM6Menu.Text = "COM 6";
            this.COM6Menu.Visible = false;
            // 
            // COM6Connect
            // 
            this.COM6Connect.Name = "COM6Connect";
            this.COM6Connect.Size = new System.Drawing.Size(156, 22);
            this.COM6Connect.Text = "Подключиться";
            this.COM6Connect.Click += new System.EventHandler(this.COM6Connect_Click);
            // 
            // COM6Settings
            // 
            this.COM6Settings.Name = "COM6Settings";
            this.COM6Settings.Size = new System.Drawing.Size(156, 22);
            this.COM6Settings.Text = "Настройки";
            this.COM6Settings.Click += new System.EventHandler(this.COM6Settings_Click);
            // 
            // OpenLog6
            // 
            this.OpenLog6.Enabled = false;
            this.OpenLog6.Name = "OpenLog6";
            this.OpenLog6.Size = new System.Drawing.Size(156, 22);
            this.OpenLog6.Text = "Открыть лог";
            this.OpenLog6.Click += new System.EventHandler(this.OpenLog6_Click);
            // 
            // COM7Menu
            // 
            this.COM7Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM7Connect,
            this.COM7Settings,
            this.OpenLog7});
            this.COM7Menu.Name = "COM7Menu";
            this.COM7Menu.Size = new System.Drawing.Size(117, 22);
            this.COM7Menu.Text = "COM 7";
            this.COM7Menu.Visible = false;
            // 
            // COM7Connect
            // 
            this.COM7Connect.Name = "COM7Connect";
            this.COM7Connect.Size = new System.Drawing.Size(156, 22);
            this.COM7Connect.Text = "Подключиться";
            this.COM7Connect.Click += new System.EventHandler(this.COM7Connect_Click);
            // 
            // COM7Settings
            // 
            this.COM7Settings.Name = "COM7Settings";
            this.COM7Settings.Size = new System.Drawing.Size(156, 22);
            this.COM7Settings.Text = "Настройки";
            this.COM7Settings.Click += new System.EventHandler(this.COM7Settings_Click);
            // 
            // OpenLog7
            // 
            this.OpenLog7.Enabled = false;
            this.OpenLog7.Name = "OpenLog7";
            this.OpenLog7.Size = new System.Drawing.Size(156, 22);
            this.OpenLog7.Text = "Открыть лог";
            this.OpenLog7.Click += new System.EventHandler(this.OpenLog7_Click);
            // 
            // COM8Menu
            // 
            this.COM8Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM8Connect,
            this.COM8Settings,
            this.OpenLog8});
            this.COM8Menu.Name = "COM8Menu";
            this.COM8Menu.Size = new System.Drawing.Size(117, 22);
            this.COM8Menu.Text = "COM 8";
            this.COM8Menu.Visible = false;
            // 
            // COM8Connect
            // 
            this.COM8Connect.Name = "COM8Connect";
            this.COM8Connect.Size = new System.Drawing.Size(156, 22);
            this.COM8Connect.Text = "Подключиться";
            this.COM8Connect.Click += new System.EventHandler(this.COM8Connect_Click);
            // 
            // COM8Settings
            // 
            this.COM8Settings.Name = "COM8Settings";
            this.COM8Settings.Size = new System.Drawing.Size(156, 22);
            this.COM8Settings.Text = "Настройки";
            this.COM8Settings.Click += new System.EventHandler(this.COM8Settings_Click);
            // 
            // OpenLog8
            // 
            this.OpenLog8.Enabled = false;
            this.OpenLog8.Name = "OpenLog8";
            this.OpenLog8.Size = new System.Drawing.Size(156, 22);
            this.OpenLog8.Text = "Открыть лог";
            this.OpenLog8.Click += new System.EventHandler(this.OpenLog8_Click);
            // 
            // COM9Menu
            // 
            this.COM9Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM9Connect,
            this.COM9Settings,
            this.OpenLog9});
            this.COM9Menu.Name = "COM9Menu";
            this.COM9Menu.Size = new System.Drawing.Size(117, 22);
            this.COM9Menu.Text = "COM 9";
            this.COM9Menu.Visible = false;
            // 
            // COM9Connect
            // 
            this.COM9Connect.Name = "COM9Connect";
            this.COM9Connect.Size = new System.Drawing.Size(156, 22);
            this.COM9Connect.Text = "Подключиться";
            this.COM9Connect.Click += new System.EventHandler(this.COM9Connect_Click);
            // 
            // COM9Settings
            // 
            this.COM9Settings.Name = "COM9Settings";
            this.COM9Settings.Size = new System.Drawing.Size(156, 22);
            this.COM9Settings.Text = "Настройки";
            this.COM9Settings.Click += new System.EventHandler(this.COM9Settings_Click);
            // 
            // OpenLog9
            // 
            this.OpenLog9.Enabled = false;
            this.OpenLog9.Name = "OpenLog9";
            this.OpenLog9.Size = new System.Drawing.Size(156, 22);
            this.OpenLog9.Text = "Открыть лог";
            this.OpenLog9.Click += new System.EventHandler(this.OpenLog9_Click);
            // 
            // COM10Menu
            // 
            this.COM10Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COM10Connect,
            this.COM10Settings,
            this.OpenLog10});
            this.COM10Menu.Name = "COM10Menu";
            this.COM10Menu.Size = new System.Drawing.Size(117, 22);
            this.COM10Menu.Text = "COM 10";
            this.COM10Menu.Visible = false;
            // 
            // COM10Connect
            // 
            this.COM10Connect.Name = "COM10Connect";
            this.COM10Connect.Size = new System.Drawing.Size(156, 22);
            this.COM10Connect.Text = "Подключиться";
            this.COM10Connect.Click += new System.EventHandler(this.COM10Connect_Click);
            // 
            // COM10Settings
            // 
            this.COM10Settings.Name = "COM10Settings";
            this.COM10Settings.Size = new System.Drawing.Size(156, 22);
            this.COM10Settings.Text = "Настройки";
            this.COM10Settings.Click += new System.EventHandler(this.COM10Settings_Click);
            // 
            // OpenLog10
            // 
            this.OpenLog10.Enabled = false;
            this.OpenLog10.Name = "OpenLog10";
            this.OpenLog10.Size = new System.Drawing.Size(156, 22);
            this.OpenLog10.Text = "Открыть лог";
            this.OpenLog10.Click += new System.EventHandler(this.OpenLog10_Click);
            // 
            // ControlMode
            // 
            this.ControlMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedMode,
            this.WayMode,
            this.AngleMode});
            this.ControlMode.Name = "ControlMode";
            this.ControlMode.Size = new System.Drawing.Size(125, 20);
            this.ControlMode.Text = "Режим управления";
            this.ControlMode.Click += new System.EventHandler(this.ControlMode_Click);
            // 
            // SpeedMode
            // 
            this.SpeedMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JoyStickControl,
            this.ButtonsControl});
            this.SpeedMode.Name = "SpeedMode";
            this.SpeedMode.Size = new System.Drawing.Size(144, 22);
            this.SpeedMode.Text = "По скорости";
            this.SpeedMode.Click += new System.EventHandler(this.SpeedMode_Click);
            // 
            // JoyStickControl
            // 
            this.JoyStickControl.Checked = true;
            this.JoyStickControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JoyStickControl.Name = "JoyStickControl";
            this.JoyStickControl.Size = new System.Drawing.Size(129, 22);
            this.JoyStickControl.Text = "Джойстик";
            this.JoyStickControl.Click += new System.EventHandler(this.JoyStickControl_Click);
            // 
            // ButtonsControl
            // 
            this.ButtonsControl.Name = "ButtonsControl";
            this.ButtonsControl.Size = new System.Drawing.Size(129, 22);
            this.ButtonsControl.Text = "Кнопки";
            this.ButtonsControl.Click += new System.EventHandler(this.ButtonsControl_Click);
            // 
            // WayMode
            // 
            this.WayMode.Name = "WayMode";
            this.WayMode.Size = new System.Drawing.Size(144, 22);
            this.WayMode.Text = "По пути";
            this.WayMode.Click += new System.EventHandler(this.WayMode_Click);
            // 
            // AngleMode
            // 
            this.AngleMode.Name = "AngleMode";
            this.AngleMode.Size = new System.Drawing.Size(144, 22);
            this.AngleMode.Text = "По углу";
            this.AngleMode.Click += new System.EventHandler(this.AngleMode_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 38);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(85, 29);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SpeedModeBox
            // 
            this.SpeedModeBox.Controls.Add(this.JoyStick);
            this.SpeedModeBox.Controls.Add(this.LeftTurnBut);
            this.SpeedModeBox.Controls.Add(this.RightTurnBut);
            this.SpeedModeBox.Controls.Add(this.BackwardBut);
            this.SpeedModeBox.Controls.Add(this.ForwardBut);
            this.SpeedModeBox.Location = new System.Drawing.Point(12, 87);
            this.SpeedModeBox.Name = "SpeedModeBox";
            this.SpeedModeBox.Size = new System.Drawing.Size(259, 366);
            this.SpeedModeBox.TabIndex = 2;
            this.SpeedModeBox.TabStop = false;
            this.SpeedModeBox.Text = "Управление по скорости";
            // 
            // JoyStick
            // 
            this.JoyStick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JoyStick.BackgroundImage")));
            this.JoyStick.InitialImage = null;
            this.JoyStick.Location = new System.Drawing.Point(39, 19);
            this.JoyStick.Name = "JoyStick";
            this.JoyStick.Size = new System.Drawing.Size(180, 180);
            this.JoyStick.TabIndex = 4;
            this.JoyStick.TabStop = false;
            this.JoyStick.Paint += new System.Windows.Forms.PaintEventHandler(this.JoyStick_Paint);
            this.JoyStick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JoyStick_MouseDown);
            this.JoyStick.MouseLeave += new System.EventHandler(this.JoyStick_MouseLeave);
            this.JoyStick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JoyStick_MouseMove);
            this.JoyStick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JoyStick_MouseUp);
            // 
            // LeftTurnBut
            // 
            this.LeftTurnBut.Enabled = false;
            this.LeftTurnBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LeftTurnBut.Location = new System.Drawing.Point(49, 256);
            this.LeftTurnBut.Name = "LeftTurnBut";
            this.LeftTurnBut.Size = new System.Drawing.Size(50, 50);
            this.LeftTurnBut.TabIndex = 3;
            this.LeftTurnBut.UseVisualStyleBackColor = true;
            this.LeftTurnBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTurnBut_MouseDown);
            this.LeftTurnBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTurnBut_MouseUp);
            // 
            // RightTurnBut
            // 
            this.RightTurnBut.Enabled = false;
            this.RightTurnBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.RightTurnBut.Location = new System.Drawing.Point(161, 256);
            this.RightTurnBut.Name = "RightTurnBut";
            this.RightTurnBut.Size = new System.Drawing.Size(50, 50);
            this.RightTurnBut.TabIndex = 2;
            this.RightTurnBut.UseVisualStyleBackColor = true;
            this.RightTurnBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTurnBut_MouseDown);
            this.RightTurnBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTurnBut_MouseUp);
            // 
            // BackwardBut
            // 
            this.BackwardBut.Enabled = false;
            this.BackwardBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BackwardBut.Location = new System.Drawing.Point(105, 312);
            this.BackwardBut.Name = "BackwardBut";
            this.BackwardBut.Size = new System.Drawing.Size(50, 50);
            this.BackwardBut.TabIndex = 1;
            this.BackwardBut.UseVisualStyleBackColor = true;
            this.BackwardBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackwardBut_MouseDown);
            this.BackwardBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackwardBut_MouseUp);
            // 
            // ForwardBut
            // 
            this.ForwardBut.Enabled = false;
            this.ForwardBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ForwardBut.Location = new System.Drawing.Point(105, 200);
            this.ForwardBut.Name = "ForwardBut";
            this.ForwardBut.Size = new System.Drawing.Size(50, 50);
            this.ForwardBut.TabIndex = 0;
            this.ForwardBut.UseVisualStyleBackColor = true;
            this.ForwardBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ForwardBut_MouseDown);
            this.ForwardBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ForwardBut_MouseUp);
            // 
            // WayModeBox
            // 
            this.WayModeBox.Enabled = false;
            this.WayModeBox.Location = new System.Drawing.Point(292, 87);
            this.WayModeBox.Name = "WayModeBox";
            this.WayModeBox.Size = new System.Drawing.Size(259, 366);
            this.WayModeBox.TabIndex = 3;
            this.WayModeBox.TabStop = false;
            this.WayModeBox.Text = "Управление по пути";
            // 
            // AngleModeBox
            // 
            this.AngleModeBox.Enabled = false;
            this.AngleModeBox.Location = new System.Drawing.Point(566, 87);
            this.AngleModeBox.Name = "AngleModeBox";
            this.AngleModeBox.Size = new System.Drawing.Size(259, 366);
            this.AngleModeBox.TabIndex = 3;
            this.AngleModeBox.TabStop = false;
            this.AngleModeBox.Text = "Управление по углу поворота";
            // 
            // Accelerometer
            // 
            this.Accelerometer.Location = new System.Drawing.Point(292, 36);
            this.Accelerometer.Maximum = 127;
            this.Accelerometer.Name = "Accelerometer";
            this.Accelerometer.Size = new System.Drawing.Size(259, 45);
            this.Accelerometer.TabIndex = 0;
            this.Accelerometer.TickFrequency = 10;
            this.Accelerometer.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скорость";
            // 
            // TurnRadius
            // 
            this.TurnRadius.Enabled = false;
            this.TurnRadius.Location = new System.Drawing.Point(566, 36);
            this.TurnRadius.Minimum = 1;
            this.TurnRadius.Name = "TurnRadius";
            this.TurnRadius.Size = new System.Drawing.Size(259, 45);
            this.TurnRadius.TabIndex = 5;
            this.TurnRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TurnRadius.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Радиус поворота";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 463);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TurnRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accelerometer);
            this.Controls.Add(this.AngleModeBox);
            this.Controls.Add(this.WayModeBox);
            this.Controls.Add(this.SpeedModeBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SpeedModeBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JoyStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accelerometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Connection;
        private System.Windows.Forms.ToolStripMenuItem COM1Menu;
        private System.Windows.Forms.ToolStripMenuItem COM1Connect;
        private System.Windows.Forms.ToolStripMenuItem COM1Settings;
        private System.Windows.Forms.ToolStripMenuItem COM2Menu;
        private System.Windows.Forms.ToolStripMenuItem COM2Connect;
        private System.Windows.Forms.ToolStripMenuItem COM2Settings;
        private System.Windows.Forms.ToolStripMenuItem COM3Menu;
        private System.Windows.Forms.ToolStripMenuItem COM3Connect;
        private System.Windows.Forms.ToolStripMenuItem COM3Settings;
        private System.Windows.Forms.ToolStripMenuItem COM4Menu;
        private System.Windows.Forms.ToolStripMenuItem COM4Connect;
        private System.Windows.Forms.ToolStripMenuItem COM4Settings;
        private System.Windows.Forms.ToolStripMenuItem COM5Menu;
        private System.Windows.Forms.ToolStripMenuItem COM5Connect;
        private System.Windows.Forms.ToolStripMenuItem COM5Settings;
        private System.Windows.Forms.ToolStripMenuItem COM6Menu;
        private System.Windows.Forms.ToolStripMenuItem COM6Connect;
        private System.Windows.Forms.ToolStripMenuItem COM6Settings;
        private System.Windows.Forms.ToolStripMenuItem COM7Menu;
        private System.Windows.Forms.ToolStripMenuItem COM7Connect;
        private System.Windows.Forms.ToolStripMenuItem COM8Menu;
        private System.Windows.Forms.ToolStripMenuItem COM8Connect;
        private System.Windows.Forms.ToolStripMenuItem COM8Settings;
        private System.Windows.Forms.ToolStripMenuItem COM9Menu;
        private System.Windows.Forms.ToolStripMenuItem COM9Connect;
        private System.Windows.Forms.ToolStripMenuItem COM9Settings;
        private System.Windows.Forms.ToolStripMenuItem COM10Menu;
        private System.Windows.Forms.ToolStripMenuItem COM10Connect;
        private System.Windows.Forms.ToolStripMenuItem COM10Settings;
        private System.Windows.Forms.ToolStripMenuItem ControlMode;
        private System.Windows.Forms.ToolStripMenuItem COM7Settings;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ToolStripMenuItem OpenLog1;
        private System.Windows.Forms.ToolStripMenuItem OpenLog2;
        private System.Windows.Forms.ToolStripMenuItem OpenLog3;
        private System.Windows.Forms.ToolStripMenuItem OpenLog4;
        private System.Windows.Forms.ToolStripMenuItem OpenLog5;
        private System.Windows.Forms.ToolStripMenuItem OpenLog6;
        private System.Windows.Forms.ToolStripMenuItem OpenLog7;
        private System.Windows.Forms.ToolStripMenuItem OpenLog8;
        private System.Windows.Forms.ToolStripMenuItem OpenLog9;
        private System.Windows.Forms.ToolStripMenuItem OpenLog10;
        private System.Windows.Forms.ToolStripMenuItem SpeedMode;
        private System.Windows.Forms.ToolStripMenuItem WayMode;
        private System.Windows.Forms.ToolStripMenuItem AngleMode;
        private System.Windows.Forms.GroupBox SpeedModeBox;
        private System.Windows.Forms.GroupBox WayModeBox;
        private System.Windows.Forms.GroupBox AngleModeBox;
        private System.Windows.Forms.TrackBar Accelerometer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LeftTurnBut;
        private System.Windows.Forms.Button RightTurnBut;
        private System.Windows.Forms.Button BackwardBut;
        private System.Windows.Forms.Button ForwardBut;
        private System.Windows.Forms.TrackBar TurnRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox JoyStick;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem JoyStickControl;
        private System.Windows.Forms.ToolStripMenuItem ButtonsControl;
    }
}

