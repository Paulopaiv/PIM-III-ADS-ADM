using Npgsql;
using PIM_III_ADS_ADM.Utils;
using System;
using System.Windows.Forms;

namespace PIM_III_ADS_ADM.Service
{
    internal class VendasService
    {
        private Dbconexao dbconexao = new Dbconexao();
        private NpgsqlConnection conexao;

        internal VendasService()
        {
            conexao = dbconexao.GetConnection() as NpgsqlConnection;
        }

        internal void RegistrarVenda(string pagamentoAtual, string codigoUsuario, string vendaAtual, string e_mail, string nome, string valorIngresso)
        {
            // Verifica se codigoUsuario não é nulo ou vazio
            if (string.IsNullOrEmpty(codigoUsuario))
            {
                MessageBox.Show("Código do usuário não pode ser nulo ou vazio.");
                return; // Sai do método para evitar a execução do código com um valor inválido
            }

            EnviaEmail enviaEmail = new EnviaEmail();

            using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.tbl_vendas(formadepagamento, data, codigo)
                                                 VALUES (@formadepagamento, @Data,@CodigoPessoa)", conexao))
            {
                command.Parameters.AddWithValue("@CodigoPessoa", NpgsqlTypes.NpgsqlDbType.Text, codigoUsuario);
                command.Parameters.AddWithValue("@vendas", vendaAtual);
                command.Parameters.AddWithValue("@formadepagamento", pagamentoAtual);
                command.Parameters.AddWithValue("@Data", DateTime.Now);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas < 0)
                {
                    MessageBox.Show("Falha ao registrar o voto.");
                }

                enviaEmail.EnviarEmail(nome, e_mail, codigoUsuario, pagamentoAtual, valorIngresso);
            }
        }

    }
}
