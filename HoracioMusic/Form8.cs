using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HoracioMusic
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "server=localhost;DataBase=Bdlogin;Uid=root;password=";
                var connection = new MySqlConnection(conexao);
                var comand = connection.CreateCommand();


                MySqlCommand query = new MySqlCommand("select * from Cadastro where usuario ='" + textBox1.Text + "' and senha ='" + textBox2.Text + "'", connection);

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        Form1 Cadastro1 = new Form1();
                        Cadastro1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
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
                textBox2.PasswordChar = '*';
            }
        }
    }
}
