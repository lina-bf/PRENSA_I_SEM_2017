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

namespace ProyectoPrensa
{
    public partial class Eje : Form
    {
        private SerialPort newport;
        public Eje ()
        {
            InitializeComponent();
            Code();
        
        }
        private void Code()
        {
            newport = new SerialPort();
            newport.BaudRate = 9600;
            newport.PortName = "COM4";
            newport.Open();
            Inicio.Enabled = true;

        }
    }
}
