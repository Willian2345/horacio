using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoracioMusic
{
    public partial class Form8 : Form
    {
       
        public Form8()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=bell\sqlexpress;Initial Catalog=Registro; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "select*from user_tb where usuário='" + textBox1.Text + "','" + textBox2.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
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
