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
        //SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            //SerialPort serialPort = new SerialPort("COM1", 9600); // Reemplaza "COMX" con el nombre del puerto COM correcto
            //serialPort.DataReceived += SerialPort_DataReceived;
            //serialPort.Open();
            LoadAvailablePorts();
        }
        //private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    string data = serialPort.ReadLine(); // Lee una línea de datos desde el puerto COM
        //    // Realiza el procesamiento necesario con los datos recibidos
        //    // Aquí, simplemente actualizaremos el cuadro de texto con los datos recibidos
        //    Invoke(new Action(() =>
        //    {
        //        txtData1.AppendText(data + Environment.NewLine);
        //    }));
        //}

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (serialPort.IsOpen)
        //        serialPort.Close();
        //}

        private void LoadAvailablePorts()
        {
            string[] portNames = SerialPort.GetPortNames();
            cmbxPuertos.DataSource = portNames;
        }
    }
}
