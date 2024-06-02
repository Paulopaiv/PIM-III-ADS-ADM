using Dapper;
using Npgsql;
using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace PIM_III_ADS_ADM.Service
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;
        private readonly EnviaEmail enviaEmail;
        private NpgsqlConnection conexao;

        public PessoaServico(Dbconexao conexao, EnviaEmail enviaEmail)
        {
            this.dbconexao = conexao;
            this.enviaEmail = enviaEmail;

            // Abra a conexão do banco de dados assim que o serviço for instanciado
            this.conexao = dbconexao.GetConnection() as NpgsqlConnection;
            if (this.conexao.State == ConnectionState.Closed)
                this.conexao.Open();
        }

        public void Inserir(PessoaController pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Codigo))
            {
                pessoa.Codigo = pessoa.GerarCodigo(pessoa.Nome);
            }
            // Use a conexão já aberta
            conexao.Execute(@"INSERT INTO tbl_visitante (NOME, IDADE, EMAIL, CEP, DATA, Codigo) 
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

            // enviaEmail.EnviarEmail(pessoa.Email, pessoa.Codigo);
        }

        public void Atualizar(PessoaController pessoa)
        {
            // Use a conexão já aberta
            conexao.Execute(@"UPDATE tbl_visitante SET nome = @Nome, idade = @Idade, email = @Email, cep = @Cep, data = @Data WHERE codigo = @Codigo",
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

        public void Deletar(PessoaController pessoa)
        {
            // Use a conexão já aberta para iniciar uma transação
            using (var transaction = conexao.BeginTransaction())
            {
                try
                {
                    // Primeiro, exclua os registros dependentes na tabela tbl_vendas
                    conexao.Execute(
                        "DELETE FROM tbl_vendas WHERE codigo = @Codigo",
                        new { pessoa.Codigo },
                        transaction: transaction
                    );

                    // Em seguida, exclua os registros dependentes na tabela tbl_votos
                    conexao.Execute(
                        "DELETE FROM tbl_votos WHERE codigo = @Codigo",
                        new { pessoa.Codigo },
                        transaction: transaction
                    );

                    // Finalmente, exclua o registro na tabela tbl_visitante
                    conexao.Execute(
                        "DELETE FROM tbl_visitante WHERE Codigo = @Codigo",
                        new { pessoa.Codigo },
                        transaction: transaction
                    );

                    // Se tudo estiver bem, commit a transação
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Em caso de erro, rollback a transação
                    transaction.Rollback();
                    // Re-lançar a exceção para ser tratada pelo chamador
                    throw;
                }
            }
        }



        public IEnumerable<PessoaController> BuscarTodasPessoas()
        {
            // Use a conexão já aberta
            return conexao.Query<PessoaController>("SELECT codigo as Codigo, nome as Nome, idade as Idade, email as Email, cep as Cep, data as Data FROM tbl_visitante");
        }

        public PessoaController BuscarPessoaPorEmail(string email)
        {
            // Use a conexão já aberta
            return conexao.QueryFirstOrDefault<PessoaController>("SELECT * FROM tbl_visitante WHERE email = @Email", new { Email = email });
        }

        public PessoaController BuscarPessoaPorNomeEEmail(PessoaController pessoa)
        {
            // Use a conexão já aberta
            var resultado = conexao.QueryFirstOrDefault(
                 "SELECT nome, idade, email, cep, codigo FROM public.tbl_visitante WHERE nome = @Nome AND email = @Email",
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
