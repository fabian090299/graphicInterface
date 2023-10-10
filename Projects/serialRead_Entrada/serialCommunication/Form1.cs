using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace serialCommunication
{
    public partial class FormSerial : Form
    {
        public FormSerial()
        {
            InitializeComponent();
        }

        private void FormSerial_Load(object sender, EventArgs e)
        {
            try
            {
                buttonON.Enabled = true;        //se habilita el boton de Conectar
                buttonOFF.Enabled = false;      //se deshabilita el boton de Desconectar

                //Parametros de comunicacion serial

                //Combobox puerto
                string[] ports = SerialPort.GetPortNames();
                comboBoxPuerto.Items.AddRange(ports);

                //Combobox baud rate
                string[] rates = { "9600", "115200" };
                comboBoxBaud.Items.AddRange(rates);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            try
            {
                // Asigna los elementos de los combo box para los para los parametros serial
                serialPort1.PortName = comboBoxPuerto.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);

                serialPort1.Open();

                buttonON.Enabled = false;        //se deshabilita el boton de Conectar
                buttonOFF.Enabled = true;      //se habilita el boton de Desconectar
                comboBoxBaud.Enabled = false;   //deshabilita los combobox para que no hayan cambios
                comboBoxPuerto.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    buttonON.Enabled = true;        //se deshabilita el boton de Conectar
                    buttonOFF.Enabled = false;      //se habilita el boton de Desconectar
                    comboBoxBaud.Enabled = true;   //deshabilita los combobox para que no hayan cambios
                    comboBoxPuerto.Enabled = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void FormSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead >0)
            {
                try
                {
                    string datos = serialPort1.ReadLine();      //lee el mensaje disponible

                    labelValor.Invoke((MethodInvoker) ( () => { labelValor.Text = datos; }) );
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
