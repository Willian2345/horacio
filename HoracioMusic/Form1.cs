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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            customizaçãoDesing();

        }// Fim form 1

        private void customizaçãoDesing()
        {

            painelMídiaSubmenu.Visible = false;
            painelFerramentasSubmenu.Visible = false;

        }// Fim CUstomização desing

        private void ocultarSubMenu()
        {

            if (painelMídiaSubmenu.Visible == true)
                painelMídiaSubmenu.Visible = false;

            if (painelFerramentasSubmenu.Visible == true)
                painelFerramentasSubmenu.Visible = false;

        }// Fim ocultar submenu

        private void mostrarSubMenu(Panel subMenu)
        {

            if(subMenu.Visible == false)
            {

                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {

                subMenu.Visible = false;

            }

        }// Fim mostrar SubMenu

        private void button5_Click(object sender, EventArgs e)
        {

            abrirChildForm(new Form6());

            ocultarSubMenu();

        }// fim botao 5

        private void button4_Click(object sender, EventArgs e)
        {

            abrirChildForm(new Form5());

            ocultarSubMenu();

        }// fim botao 4

        private void btnMídias_Click(object sender, EventArgs e)
        {

            mostrarSubMenu(painelMídiaSubmenu);

        }// Fim botao midias

        private void button2_Click(object sender, EventArgs e)
        {

            abrirChildForm(new Form2());

            ocultarSubMenu();

        }// fim botao 2

        private void button3_Click(object sender, EventArgs e)
        {

            abrirChildForm(new Form4());

            ocultarSubMenu();

        }// fim botao 3

        private void btnPlayList_Click(object sender, EventArgs e)
        {



        }// fim botao Pesquisar

        private void button10_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 10

        private void button9_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 9

        private void button8_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 8

        private void button7_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 7

        private void btnEqualizer_Click(object sender, EventArgs e)
        {

            abrirChildForm(new Form3());

            ocultarSubMenu();

        }// fim botao equalizador

        private void btnFerramentas_Click(object sender, EventArgs e)
        {

            mostrarSubMenu(painelFerramentasSubmenu);

        }// fim botao ferramentas

        private void button16_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 16

        private void button15_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 15

        private void button14_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 14

        private void button13_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }// fim botao 13

        private void btnAjuda_Click(object sender, EventArgs e)
        {

            ocultarSubMenu();

        }

        private Form activeForm = null;
        private void abrirChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painelChildForm.Controls.Add(childForm);
            painelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }// fim abrirchildform

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void painelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }// Fim class

}// Fim projeto 
