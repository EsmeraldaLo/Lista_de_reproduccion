using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MP3
{
    public partial class Form1 : Form
    {
        private string ruta = "";  // acceso privado inicializando como cadena vacia

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName; //   colocar la ruta seleccionada y luego la etiqueta tiene ese valor de ruta
                lblRuta.Text = ruta;
            }


             }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "youtube.com";
            linkLabel1.Links.Add(0, 0, "www.youtube.com");


        }

        private void button2_Click(object sender, EventArgs e) // boton de reproducir
        {
            axWindowsMediaPlayer1.URL = ruta;    //  
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Add(can)
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
           
        //}

        private void lblRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
