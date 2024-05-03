using Npgsql;

using PIM_III_ADS_ADM.Utils;
using PIM_III_ADS_ADM.Service;
using static QRCoder.PayloadGenerator;

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

        internal void RegistrarVenda(string pagamentoAtual, string codigoUsuario, string vendaAtual,string e_mail, string nome, string valorIngresso)
        {
            
            EnviaEmail enviaEmail = new EnviaEmail();   

            using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.vendas(formadepagamento, ingresso, data, codigo)
                                                         VALUES (@formadepagamento, @ingresso, @Data,@CodigoPessoa)", conexao))
            {
                command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                command.Parameters.AddWithValue("@ingresso", vendaAtual);
                command.Parameters.AddWithValue("@formadepagamento", pagamentoAtual);
                command.Parameters.AddWithValue("@Data", DateTime.Now);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas < 0)
                {
                    MessageBox.Show("Falha ao registrar o voto.");
                }

                enviaEmail.EnviarEmail(nome,e_mail,codigoUsuario, pagamentoAtual, valorIngresso);
            }


        }

    }
}