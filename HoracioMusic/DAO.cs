using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;


namespace HoracioMusic
{
    class DAO
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string resultado;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=horaciomusic;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar ao BD
                MessageBox.Show("Conectado com Sucesso!");
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
                comando = "Insert into cadastro(CodigoCadastro, nomeCompleto, usuario, senha) values " + dados;

                //Executar o comando na base de dados
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                resultado = "" + sql.ExecuteNonQuery();
               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }


        }
    }
    }
