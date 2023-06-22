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

namespace ConexionDePuertos
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 115200); // Configura el puerto COM y la velocidad de baudios
            serialPort.DataReceived += SerialPort_DataReceived; // Asigna el evento DataReceived

            try
            {
                serialPort.Open(); // Abre el puerto serial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el puerto serial: " + ex.Message);
            }
            LoadAvailablePorts();
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Se ejecuta cuando se recibe un dato en el puerto serial
            string data = serialPort.ReadExisting(); // Lee los datos recibidos

            // Realiza el procesamiento de los datos recibidos como desees
            // Puedes actualizar los controles de la interfaz de usuario, guardar los datos, etc.

            // Ejemplo: Mostrar los datos en un TextBox llamado "textBoxData"
            txtData1.Invoke((MethodInvoker)(() => txtData1.AppendText(data)));
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close(); // Cierra el puerto serial antes de salir de la aplicación
            }
        }

        private void LoadAvailablePorts()
        {
            string[] portNames = SerialPort.GetPortNames();
            cmbxPuertos.DataSource = portNames;
        }
    }
}
