using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HoracioMusic
{
    class DAOCadastro
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;
        public DAOCadastro()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=BdLogin;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar ao BD
                MessageBox.Show("Conectado");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);//Enviando a mesagem de erro aos usuários
                conexao.Close();//fechando a conexão com o banco de dados
            }
        }//fim do DAOPessoa

        public void Inserir(string nomeCompleto, string usuario, string senha)
        {
            try
            {
                //Preparar os dados para inserir no banco
                dados = "('','" + nomeCompleto + "','" + usuario + "','" + senha + "')";
                comando = "Insert into Cadastro(codigo, nomeCompleto, usuario , senha) values " + dados;

                //Executar o comando na base de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + " linha afetada!");
                MessageBox.Show("Passou");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método inserir
    }//fim da classe
}//fim do projeto
