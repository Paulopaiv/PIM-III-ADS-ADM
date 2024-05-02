using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Service;
using PIM_III_ADS_ADM.Utils;
using PPIM_III_ADS_ADM.Service;

namespace PIM_III_ADS_ADM.Model
{
    public class PessoaModel
    {
        Validacao validacao = new Validacao();
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao(), new EnviaEmail());
        PessoaController pessoaController;
        private string mensagem = "";

        public PessoaModel()
        {

        }

        public PessoaModel(PessoaController pessoaController)
        {
            this.SalvaPessoa(pessoaController);
            this.AtualizarPessoa(pessoaController);
            this.DeletarPessoa(pessoaController);
            this.BuscarPessoa(pessoaController);
            this.BuscarTodasPessoas();
        }

        internal void SalvaPessoa(PessoaController pessoaController)
        {
            validacao.ValidarPessoa(pessoaController);

            if (validacao.Mensagem.Equals(""))
            {
                pessoaServico.Inserir(pessoaController);
                this.mensagem = "Cadastro realizado com sucesso.";
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        internal void AtualizarPessoa(PessoaController pessoaController)
        {
            validacao.ValidarPessoa(pessoaController);

            if (pessoaController != null)
            {
                pessoaServico.Atualizar(pessoaController);
                this.mensagem = "Pessoa atualizada com sucesso!";
            }
            else
            {
                this.mensagem = "Erro ao atualizar pessoa: pessoa não encontrada";
            }
        }

        internal void DeletarPessoa(PessoaController pessoaController)
        {
            if (pessoaController.Codigo.Equals(""))
            {
                this.mensagem = "Erro ao Remover pessoa: pessoa não encontrada";
            }
            else
            {
                pessoaServico.Deletar(pessoaController);
                this.mensagem = "Pessoa excluída com sucesso!";
            }
        }

        //internal void BuscarPessoa(PessoaController pessoaController)
        //{
        //    pessoaController = pessoaServico.BuscarPessoaNomeECodigo(pessoaController);

        //    if (pessoaController != null && pessoaController.Nome != null && pessoaController.Codigo != null)
        //    {
        //        this.mensagem = "Pessoa encontrada com sucesso!";
        //    }
        //    else
        //    {
        //        this.mensagem = "Pessoa não encontrada.";
        //    }
        //}

        internal void BuscarPessoa(PessoaController pessoaController)
        {
            pessoaController = pessoaServico.BuscarPessoaPorNomeEEmail(pessoaController);

            if (pessoaController != null && pessoaController.Nome != null && pessoaController.Email != null)
            {
                this.mensagem = "Pessoa encontrada com sucesso!";
            }
            else
            {
                this.mensagem = "Login inválido. Verifique suas credenciais.";
            }
        }

        internal List<PessoaController> BuscarTodasPessoas()
        {
            IEnumerable<PessoaController> todasPessoas = pessoaServico.BuscarTodasPessoas();
            return todasPessoas.ToList();
        }

        public string Mensagem
        {
            get { return mensagem; }
        }
        public PessoaServico PessoaServico
        {
            get { return pessoaServico; }
            set { pessoaServico = value; }
        }

    }
}

