using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConexaoBD
{
    internal class ConexaoSimples
    {
        //Informação de conexão com o banco
        string host = "localhost";
        string banco = "08_lista_tarefas";
        string usuario = "root";
        string senha = "senac";

        //Método construtor: ele é chamado automaticamente quando a classe é criada
        public ConexaoSimples() 
        {
            //Usa os dados do banco para se conectar
            string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
            //Cria a conexão com o banco usando os dados acima
            //O banco não se conecta sozinho, ele apenas cria a conexão
            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            //Abre a conexão com o banco
            conexao.Open();

            //Linha de código do SQL
            string query = "SELECT * FROM tarefas;";
            //Envia um comando pro banco
            MySqlCommand comando = new MySqlCommand(query, conexao);
            //Salva os dados que vieram do banco dentro de "dados"
            MySqlDataReader dados = comando.ExecuteReader();

            //Roda cada dado da tabela até a ultima linha, a ultima linha vai ser false e quebrar o loop
            while (dados.Read() == true) 
            {
                Console.WriteLine("Descrição da tarefa: " + dados["descricao"]);
            }

            //Fecha o conexão com o banco para evitar que o sistema caia por sobrecarga
            conexao.Close();
        }
    }
}
