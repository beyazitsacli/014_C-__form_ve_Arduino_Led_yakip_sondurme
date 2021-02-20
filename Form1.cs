using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;        // System IO Ports Kutuphanesini ilave ediyoruz

namespace _014_C__form_ve_Arduino_Led_yakip_sondurme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "LED ON";
            button1.Enabled = false;
            button2.Enabled = true;
;
        }

        /* Arduino nun bigisayara baglı olması gerekir yoksa  kodu port baglantı 
         * hatasi  veriri*/

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM6"; //Arduino nun baglı oldugu port adını yazıyoruz
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            button2.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label1.Text = "LED OFF";
            button1.Enabled = true;
            button2.Enabled = false;
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen==true)
            {
                serialPort1.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
