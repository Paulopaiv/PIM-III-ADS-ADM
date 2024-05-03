using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Service;
using PIM_III_ADS_ADM.Utils;
using PIM_III_ADS_ADM.Service;

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

        public void ConfigurarColunas(DataGridView dataGridView, List<PessoaController> todasPessoas)
        {
            dataGridView.DataSource = todasPessoas;

            dataGridView.Columns["codigo"].HeaderText = "Código";
            dataGridView.Columns["codigo"].DisplayIndex = 0;

            dataGridView.Columns["nome"].HeaderText = "Nome";
            dataGridView.Columns["nome"].DisplayIndex = 1;

            dataGridView.Columns["idadeDb"].HeaderText = "Idade";
            dataGridView.Columns["idadeDb"].DisplayIndex = 2;

            dataGridView.Columns["email"].HeaderText = "E-mail";
            dataGridView.Columns["email"].DisplayIndex = 3;

            dataGridView.Columns["cep"].HeaderText = "CEP";
            dataGridView.Columns["cep"].DisplayIndex = 4;

            // Oculta a coluna que deseja remover
            //dataGridView.Columns["Validacao"].Visible = false;
            dataGridView.Columns["idadeDb"].Visible = false;
           
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

