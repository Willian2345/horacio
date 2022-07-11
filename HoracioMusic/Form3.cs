using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoracioMusic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();

        }// fim botao 4

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            if (label2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar a URL do vídeo!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            //Exibir o vídeo
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<center><iframe id='video' src='https://www.youtube.com/embed/{0}?autoplay={1}' width='{2}' height='{3}' frameborder='0' allowfullscreen='true'></iframe></center>";
            html += "</body></html>";

      
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }// fim class

}// fim projeto
