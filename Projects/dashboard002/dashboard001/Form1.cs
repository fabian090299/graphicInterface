using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panelNav.Height = buttonTools.Height;
            panelNav.Top = buttonTools.Top;
            panelNav.Left = buttonTools.Left;
            buttonTools.BackColor = Color.FromArgb(46, 51, 73);
            ShowSubmenu(panelSubmenu);

            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelSubmenu.Visible == true)
            {
                panelSubmenu.Visible = false;
            }
        }
        private void ShowSubmenu(Panel subMenu)
        {
            if (panelSubmenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonTools.Height;
            panelNav.Top = buttonTools.Top;
            panelNav.Left = buttonTools.Left;
            buttonTools.BackColor = Color.FromArgb(46,51, 73);
            buttonConnect.BackColor = Color.FromArgb(24, 30, 54);
            buttonDisconnect.BackColor = Color.FromArgb(24, 30, 54);
            ShowSubmenu(panelSubmenu);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            panelNav.Height = buttonConnect.Height;
            panelNav.Top = buttonConnect.Top;
            panelNav.Left = buttonConnect.Left;
            buttonConnect.BackColor = Color.FromArgb(46, 51, 73);
            buttonDisconnect.BackColor = Color.FromArgb(24, 30, 54);
            buttonTools.BackColor = Color.FromArgb(24, 30, 54);

            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);

                serialPort1.Open();

                if (serialPort1.IsOpen)
                {
                    MessageBox.Show("El puerto serie se abrió correctamente",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonTools.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            panelNav.Height = buttonDisconnect.Height;
            panelNav.Top = buttonDisconnect.Top;
            panelNav.Left = buttonDisconnect.Left;
            buttonDisconnect.BackColor = Color.FromArgb(46, 51, 73);
            buttonConnect.BackColor = Color.FromArgb(24, 30, 54);
            buttonTools.BackColor = Color.FromArgb(24, 30, 54);

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    if (!serialPort1.IsOpen)
                    {
                        MessageBox.Show("El puerto serie se cerró correctamente",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    buttonConnect.Enabled = true;
                    buttonDisconnect.Enabled = false;
                    buttonTools.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (MessageBox.Show("La comunicación serial se encuentra activa, se cerrará antes de salir del programa",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    try
                    {
                        serialPort1.Close();
                        if ((!serialPort1.IsOpen) && MessageBox.Show("El puerto serial se cerró correctamente",
                               "Información",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                try
                {
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;

                string[] ports = SerialPort.GetPortNames();
                comboBoxPort.Items.AddRange(ports);

                string[] rates = {"9600", "115200"};
                comboBoxBaud.Items.AddRange(rates);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (MessageBox.Show("La comunicación serial se encuentra activa, se cerrará antes de salir del programa",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    try
                    {
                        serialPort1.Close();
                        if ((!serialPort1.IsOpen) && MessageBox.Show("El puerto serial se cerró correctamente",
                               "Información",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                comboBoxPort.Items.AddRange(ports);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0) 
            {
                string serialData = serialPort1.ReadLine();
                int value = 0;

                //value = Convert.ToInt32(serialData);

                try
                {
                    int.TryParse(serialData, out value);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                if (value >= circularProgressBar.Minimum && value <= circularProgressBar.Maximum)
                {
                    circularProgressBar.Invoke((MethodInvoker)(() => {
                        circularProgressBar.Text = serialData;
                        circularProgressBar.Value = value;
                    }));
                }

                //chartTemp.Series["Temp (°C)"].Points.AddY(value);
                chartTemp.Invoke((MethodInvoker)(() => {
                    chartTemp.Series["Temp (°C)"].Points.AddY(value);
                }));

                labelAnalogValue.Invoke((MethodInvoker)(() => {
                    labelAnalogValue.Text = serialData;
                }));

                labelTemp.Invoke((MethodInvoker)(() => {
                    labelTemp.Text = serialData;
                }));
            }
        }

        private void buttonState_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (buttonState.Text == "HIGH")
                {
                    try
                    {
                        serialPort1.WriteLine("C:ON");
                        buttonState.Text = "LOW";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }

                else if (buttonState.Text == "LOW")
                {
                    try
                    {
                        serialPort1.WriteLine("C:OFF");
                        buttonState.Text = "HIGH";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }
    }
}
