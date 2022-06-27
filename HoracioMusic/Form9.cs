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
    
    public partial class Form9 : Form
    {
        Form1 cadastrar;
        DAO cadastro;

        public Form9()
        {
            InitializeComponent();
            cadastrar = new Form1();
            cadastro = new DAO();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastrar.ShowDialog();
            this.Visible = true;
            try
            {
             
                string nomeCompleto = textBox3.Text;//Coletando o dado do campo nome
                string usuario = textBox1.Text;//Coletando o dado do campo telefone
                string senha = textBox2.Text;//Coletando o dado do campo Endereço
                                                //Chamar o método inserir que foi criado na classe DAOPessoa
                 cadastro.Inserir(nomeCompleto,usuario,senha);//Inserir no banco os dados do formulário
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '=';
            }
        }
    }
}
