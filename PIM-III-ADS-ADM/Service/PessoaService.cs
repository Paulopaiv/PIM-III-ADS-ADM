

using Dapper;
using Npgsql;
using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Utils;
using PPIM_III_ADS_ADM.Service;

namespace PIM_III_ADS_ADM.Service
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;
        private readonly EnviaEmail enviaEmail;
        private Dbconexao dbconexao1;
        private EnviaEmail enviaEmail1;

        public PessoaServico(Dbconexao conexao, EnviaEmail enviaEmail)
        {
            this.dbconexao = conexao;
            this.enviaEmail = enviaEmail;
        }


        public void Inserir(PessoaController pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute(@"INSERT INTO visitante (NOME, IDADE, EMAIL, CEP, DATA, Codigo) 
                    VALUES (@Nome, @IdadeDb, @Email, @Cep, @Data, @Codigo)",
                    new
                    {
                        pessoa.IdadeDb,
                        pessoa.Nome,
                        pessoa.Email,
                        pessoa.Cep,
                        pessoa.Codigo,
                        Data = DateTime.Today

                    });

                enviaEmail.EnviarEmail(pessoa.Email, pessoa.Codigo);
            }
        }

        public void Atualizar(PessoaController pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute(@"UPDATE visitante SET nome = @Nome, idade = @Idade, email = @Email, cep = @Cep, data = @Data WHERE codigo = @Codigo",
                    new
                    {
                        pessoa.Nome,
                        pessoa.IdadeDb,
                        pessoa.Email,
                        pessoa.Cep,
                        Data = DateTime.Today,
                        Codigo = pessoa.Codigo
                    });
            }
        }

        public void Deletar(PessoaController pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute("DELETE FROM visitante WHERE Codigo  = @Codigo", new { pessoa.Codigo });
            }
        }

        public IEnumerable<PessoaController> BuscarTodasPessoas()
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                // Consulta SQL modificada para incluir o campo Codigo
                return conexao.Query<PessoaController>("SELECT codigo as Codigo, nome as Nome, idade as Idade, email as Email, cep as Cep, data as Data FROM visitante");
            }
        }

        public PessoaController BuscarPessoaPorEmail(string email)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                return conexao.QueryFirstOrDefault<PessoaController>("SELECT * FROM visitante WHERE email = @Email", new { Email = email });
            }
        }

        public PessoaController BuscarPorCodigo(PessoaController pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                   "SELECT * FROM visitante WHERE Codigo = @codigo ",
                    new { Codigo = pessoa.Codigo });

                if (resultado == null)
                {
                    return null;
                }
                pessoa.Codigo = resultado.codigo;
                pessoa.Nome = resultado.nome;
                return pessoa;
            }
        }
        public PessoaController BuscarPessoaNomeECodigo(PessoaController pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                    "SELECT nome, idade, email, cep, codigo FROM public.visitante WHERE nome = @nome AND codigo = @email",
                    new { pessoa.Nome, pessoa.Email });

                if (resultado != null)
                {
                   
                    pessoa.Nome = resultado.nome;
                    pessoa.IdadeDb = resultado.idade;
                    pessoa.Email = resultado.email;
                    pessoa.Cep = resultado.cep;
                    pessoa.Codigo = resultado.codigo;

                    // Retornando a própria instância de pessoa, que agora está atualizada com os dados encontrados
                    return pessoa;
                }
                return null;
            }
        }

        public PessoaController BuscarPessoaPorNomeEEmail(PessoaController pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                     "SELECT nome, idade, email, cep, codigo FROM public.visitante WHERE nome = @Nome AND email = @Email",
                    new { pessoa.Nome, pessoa.Email });

                if (resultado != null)
                {
                    pessoa.Nome = resultado.nome;
                    pessoa.IdadeDb = resultado.idade;
                    pessoa.Email = resultado.email;
                    pessoa.Cep = resultado.cep;
                    pessoa.Codigo = resultado.codigo;

                    return pessoa;
                }

                return null;
            }
        }


    }
}
