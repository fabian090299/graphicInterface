using System.Drawing;
using System.Windows.Forms;

namespace dashboard001
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panelSubmenu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonTools = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTituloWS = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonState = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelAnalogValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnReVa = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelSubmenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.panelNav);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.panelSubmenu);
            this.panel1.Controls.Add(this.buttonTools);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 577);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonQuit.Location = new System.Drawing.Point(0, 532);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(217, 45);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNav.Location = new System.Drawing.Point(0, 200);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(5, 200);
            this.panelNav.TabIndex = 1;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonDisconnect.Location = new System.Drawing.Point(0, 355);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(217, 45);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disable Communication";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonConnect.Location = new System.Drawing.Point(0, 310);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(217, 45);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Enable Communication";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panelSubmenu
            // 
            this.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelSubmenu.Controls.Add(this.panel10);
            this.panelSubmenu.Controls.Add(this.panel5);
            this.panelSubmenu.Controls.Add(this.panel4);
            this.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu.Location = new System.Drawing.Point(0, 175);
            this.panelSubmenu.Name = "panelSubmenu";
            this.panelSubmenu.Size = new System.Drawing.Size(217, 135);
            this.panelSubmenu.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBoxBaud);
            this.panel5.Controls.Add(this.labelBaud);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 45);
            this.panel5.TabIndex = 0;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBaud.ForeColor = System.Drawing.Color.White;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(103, 10);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(86, 21);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelBaud.Location = new System.Drawing.Point(14, 15);
            this.labelBaud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(70, 16);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baudrate";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxPort);
            this.panel4.Controls.Add(this.labelPort);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 45);
            this.panel4.TabIndex = 0;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPort.ForeColor = System.Drawing.Color.White;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(103, 11);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxPort.Size = new System.Drawing.Size(86, 21);
            this.comboBoxPort.TabIndex = 2;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelPort.Location = new System.Drawing.Point(12, 16);
            this.labelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 16);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Port";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTools
            // 
            this.buttonTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTools.FlatAppearance.BorderSize = 0;
            this.buttonTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTools.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonTools.Location = new System.Drawing.Point(0, 130);
            this.buttonTools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(217, 45);
            this.buttonTools.TabIndex = 2;
            this.buttonTools.Text = "Connection Tools";
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 130);
            this.panel2.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelTitle.Location = new System.Drawing.Point(80, 105);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(66, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Arduino HMI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dashboard001.Properties.Resources.IEEE_Computer;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTituloWS
            // 
            this.labelTituloWS.AutoSize = true;
            this.labelTituloWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloWS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelTituloWS.Location = new System.Drawing.Point(20, 17);
            this.labelTituloWS.Name = "labelTituloWS";
            this.labelTituloWS.Size = new System.Drawing.Size(170, 33);
            this.labelTituloWS.TabIndex = 1;
            this.labelTituloWS.Text = "Workspace";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel8);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel9);
            this.panelMain.Controls.Add(this.panel7);
            this.panelMain.Controls.Add(this.panel6);
            this.panelMain.Controls.Add(this.labelTituloWS);
            this.panelMain.Location = new System.Drawing.Point(217, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(893, 577);
            this.panelMain.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.chartTemp);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(26, 310);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(560, 255);
            this.panel8.TabIndex = 4;
            // 
            // chartTemp
            // 
            this.chartTemp.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.Sienna;
            this.chartTemp.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            legend4.Name = "Legend1";
            this.chartTemp.Legends.Add(legend4);
            this.chartTemp.Location = new System.Drawing.Point(31, 58);
            this.chartTemp.Name = "chartTemp";
            series4.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            series4.Legend = "Legend1";
            series4.Name = "Temp (°C)";
            this.chartTemp.Series.Add(series4);
            this.chartTemp.Size = new System.Drawing.Size(486, 170);
            this.chartTemp.TabIndex = 3;
            this.chartTemp.Text = "Visual Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visual Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.buttonState);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(604, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 190);
            this.panel3.TabIndex = 2;
            // 
            // buttonState
            // 
            this.buttonState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.buttonState.Location = new System.Drawing.Point(50, 86);
            this.buttonState.Name = "buttonState";
            this.buttonState.Size = new System.Drawing.Size(135, 24);
            this.buttonState.TabIndex = 1;
            this.buttonState.Text = "HIGH";
            this.buttonState.UseVisualStyleBackColor = true;
            this.buttonState.Click += new System.EventHandler(this.buttonState_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digital State Writing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Digital Output";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.circularProgressBar);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(604, 310);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 255);
            this.panel9.TabIndex = 2;
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(49, 58);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Maximum = 1023;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 5;
            this.circularProgressBar.Text = "0";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 450;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            this.label7.Location = new System.Drawing.Point(18, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Analog Value ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Visual Data";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.labelTemp);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(301, 105);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 190);
            this.panel7.TabIndex = 2;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.labelTemp.Location = new System.Drawing.Point(15, 83);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(32, 33);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperature Value (°C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Temperature";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.labelAnalogValue);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.labelAnReVa);
            this.panel6.Location = new System.Drawing.Point(26, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 190);
            this.panel6.TabIndex = 2;
            // 
            // labelAnalogValue
            // 
            this.labelAnalogValue.AutoSize = true;
            this.labelAnalogValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnalogValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.labelAnalogValue.Location = new System.Drawing.Point(15, 83);
            this.labelAnalogValue.Name = "labelAnalogValue";
            this.labelAnalogValue.Size = new System.Drawing.Size(32, 33);
            this.labelAnalogValue.TabIndex = 1;
            this.labelAnalogValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(161)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analog Input Value";
            // 
            // labelAnReVa
            // 
            this.labelAnReVa.AutoSize = true;
            this.labelAnReVa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnReVa.ForeColor = System.Drawing.Color.White;
            this.labelAnReVa.Location = new System.Drawing.Point(15, 12);
            this.labelAnReVa.Name = "labelAnReVa";
            this.labelAnReVa.Size = new System.Drawing.Size(206, 31);
            this.labelAnReVa.TabIndex = 0;
            this.labelAnReVa.Text = "Analog Reading";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.buttonRefresh);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 90);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(217, 45);
            this.panel10.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonRefresh.Location = new System.Drawing.Point(0, 0);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(217, 45);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1110, 577);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelSubmenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSubmenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private Button buttonDisconnect;
        private Button buttonConnect;
        private Panel panelNav;
        private Label labelTituloWS;
        private Panel panelMain;
        private Panel panel6;
        private Label labelAnReVa;
        private Label labelAnalogValue;
        private Label label1;
        private Panel panel7;
        private Label labelTemp;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Button buttonState;
        private Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private Panel panel9;
        private Label label7;
        private Label label8;
        private Label label2;
        private Button buttonQuit;
        private System.IO.Ports.SerialPort serialPort1;
        private Panel panel10;
        private Button buttonRefresh;
    }
}

