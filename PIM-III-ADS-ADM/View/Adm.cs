
using PIM_III_ADS_ADM.Controller;

using PIM_III_ADS_ADM.Model;



namespace PIM_III_ADS_ADM.View
{
    public partial class Adm : Form
    {
        private PessoaModel pessoaModel;
       // private PessoaController pessoaController;

        private VendasController vendasController;
        private Pagamento pagamento;
        private PessoaController pessoaController;
        private VendasModel vendasModel;
        private PagamentoController pagamentoController;

        public Adm(PessoaController pessoaController)
        {
            InitializeComponent();
            pessoaModel = new PessoaModel();
           // pessoaController = new PessoaController();

            vendasController = new VendasController();
            pagamentoController = new PagamentoController();
            this.pessoaController = pessoaController; // Recebe o objeto PessoaController
            
            pagamento = new Pagamento(vendasController, pessoaController); // Passa o objeto PessoaController
            vendasModel = new VendasModel(vendasController, pagamentoController, pessoaController);

            this.WindowState = FormWindowState.Maximized;
            txbData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCodigo.Text))
            {
                pessoaController.Nome = txbNome.Text;
                pessoaController.Idade = txbIdade.Text;
                pessoaController.Email = txbEmail.Text;
                pessoaController.Cep = txbCep.Text;

                pessoaModel.SalvaPessoa(pessoaController);
                MessageBox.Show(pessoaModel.Mensagem);
            }
            else
            {
                pessoaController.Nome = txbNome.Text;
                pessoaController.Idade = txbIdade.Text;
                pessoaController.Email = txbEmail.Text;
                pessoaController.Cep = txbCep.Text;
                pessoaController.Codigo = txbCodigo.Text;

                pessoaModel.AtualizarPessoa(pessoaController);
                MessageBox.Show(pessoaModel.Mensagem);
            }
                RecarregarDadosDataGridView();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            pessoaController.Codigo = txbCodigo.Text;

            pessoaModel.DeletarPessoa(pessoaController);
            MessageBox.Show(pessoaModel.Mensagem);
            RecarregarDadosDataGridView();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            pessoaController.Nome = txbNomeBuscar.Text;
            pessoaController.Email = txbEmailBuscar.Text;

            pessoaModel.BuscarPessoa(pessoaController);

            if (pessoaModel.Mensagem.Equals("Pessoa encontrada com sucesso!"))
            {
                txbCodigo.Text = pessoaController.Codigo;
                txbNome.Text = pessoaController.Nome;
                txbIdade.Text = pessoaController.IdadeDb.ToString();
                txbEmail.Text = pessoaController.Email;
                txbCep.Text = pessoaController.Cep;
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            string powerBiDesktopPath = @"C:\Program Files\Microsoft Power BI Desktop\bin\PBIDesktop.exe";
            string reportPath = @"C:\Users\Nicolas\OneDrive\Documentos\Projetos\PIM\Repositórios\PIM-III-ADS.pbix";

            try
            {
                System.Diagnostics.Process.Start(powerBiDesktopPath, $"\"{reportPath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o relatorio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Adm_Load(object sender, EventArgs e)
        {

            List<PessoaController> todasPessoas = pessoaModel.BuscarTodasPessoas();

            pessoaModel.ConfigurarColunas(dgvPessoa, todasPessoas);

            // Configuração para ajustar o tamanho da tabela ao DataGridView
            dgvPessoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPessoa.AutoResizeColumns();
        }

        private void RecarregarDadosDataGridView()
        {
            PessoaController pessoa = new PessoaController();
            List<PessoaController> todasPessoas = pessoaModel.BuscarTodasPessoas();

            dgvPessoa.DataSource = todasPessoas;
        }

        private void btnInteiro_Click(object sender, EventArgs e)
        {
            AtualizarTipoIngresso(true, false, false);
        }

        private void btnMeia_Click(object sender, EventArgs e)
        {
            AtualizarTipoIngresso(false, true, false);
        }

        private void btnIsento_Click(object sender, EventArgs e)
        {
            // Verifica se a idade é maior que 70
            if (pessoaController.IdadeDb > 70)
            {
                // Se a idade for maior que 70, define o tipo de ingresso como isento
                AtualizarTipoIngresso(false, false, true);
                vendasModel.SalvarVenda();
            }
            else
            {
                // Se a idade não for maior que 70, mostra uma mensagem de erro
                MessageBox.Show("A opção 'Isento' está disponível apenas para pessoas com mais de 70 anos.");
            }
        }

        private void AtualizarTipoIngresso(bool inteiro, bool meia, bool isento)
        {
            vendasController.Inteiro = inteiro;
            vendasController.Meia = meia;
            vendasController.Isento = isento;
            pagamento.ShowDialog();
        }
    }
}
