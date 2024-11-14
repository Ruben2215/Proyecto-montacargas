using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

namespace Interfaz_Montacargas
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            iconPictureBox5.Visible = false;
            Min2.Visible = true;
            //centrar ventana
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox5.Visible = true;
            iconPictureBox1.Visible = false;
        }

        private void iconPictureBox5_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = true;
            iconPictureBox5.Visible = false;
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min2_MouseHover(object sender, EventArgs e)
        {
            Min2.Visible = false;
            Min.Visible = true;
        }

        private void Min_MouseLeave(object sender, EventArgs e)
        {
            Min2.Visible = true;
            Min.Visible = false;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron puertos");
            }
            serialPort = new SerialPort()
            {
                BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };


            // Configura el evento para leer los datos
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Asigna el puerto seleccionado en el comboBox al SerialPort
                serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                // Abre el puerto serial
                serialPort.Open();
                MessageBox.Show("Conexión establecida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el puerto: " + ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            /*
            // Lee la línea recibida desde el puerto serial
            SerialPort sp = (SerialPort)sender;
            string message = sp.ReadLine();

            // Actualiza el TextBox en el hilo principal (UI Thread)
            Invoke(new Action(() =>
            {
//                txbxOut.AppendText( message);
            }));*/
            SerialPort sp = (SerialPort)sender;
            string message = sp.ReadLine();

            // Verifica si el Arduino envía "OK" como confirmación para restablecer el estado
            if (message.Trim() == "OK")
            {
                isCommandSent = false; // Permite que el siguiente comando se envíe
            }

            // Actualiza el TextBox en el hilo principal (UI Thread)
            Invoke(new Action(() =>
            {
                estado.AppendText(message + "\n");
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra el puerto serial al cerrar la aplicación
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        private string lastCommand = "";
        private bool isCommandSent = false;


        private void iconSubir_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen)
            {
                // Solo envía el comando si el último comando no es "SUBIR" y aún no se ha enviado
                if (lastCommand != "SUBIR" && !isCommandSent)
                {
                    serialPort.WriteLine("SUBIR");
                    estado.AppendText("SUBIR\n");
                    lastCommand = "SUBIR"; // Actualiza el último comando
                    isCommandSent = true; // Marca que el comando se ha enviado
                }
            }
            else
            {
                MessageBox.Show("El puerto serial no está abierto.");
            }
        }

        private void iconBajar_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen)
            {
                // Solo envía el comando si el último comando no es "BAJAR" y aún no se ha enviado
                if (lastCommand != "BAJAR" && !isCommandSent)
                {
                    serialPort.WriteLine("BAJAR");
                    estado.AppendText("BAJAR\n");
                    lastCommand = "BAJAR"; // Actualiza el último comando
                    isCommandSent = true; // Marca que el comando se ha enviado
                }
            }
            else
            {
                MessageBox.Show("El puerto serial no está abierto.");
            }

        }

        private void AltoTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            isCommandSent = false;
        }
    }
}

