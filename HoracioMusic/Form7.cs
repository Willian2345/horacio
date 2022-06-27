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
    public partial class Form7 : Form
    {
        Form8 entrar;
        Form9 cadastrar;
        public Form7()
        {
            InitializeComponent();
            entrar = new Form8();
            cadastrar = new Form9();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastrar.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            entrar.ShowDialog();
            this.Visible = true;
        }
    }
}
