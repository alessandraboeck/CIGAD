using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace projetoUC08.Models
{
    public class MensagemRepository
    {
        private const string dadosMensagem="Database=cigad; Data Source=localhost; User Id=root;";

        public void testeConexao()
        {
            MySqlConnection dados = new MySqlConnection(dadosMensagem);
            dados.Open();
            dados.Close();
        }

        public void Insert(Usuario u)
        {
            MySqlConnection dados = new MySqlConnection(dadosMensagem);

            dados.Open();

            string query="INSERT INTO usuario (nome, email, mensagem) VALUES(@nome, @email, @mensagem)";

            MySqlCommand comando = new MySqlCommand(query, dados);

            comando.Parameters.AddWithValue("@nome", u.nome);
            comando.Parameters.AddWithValue("@email", u.email);
            comando.Parameters.AddWithValue("@mensagem", u.mensagem);
            
            comando.ExecuteNonQuery();
            dados.Close();
        }

    }
}