

using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Model;



namespace PIM_III_ADS_ADM.View
{
    public partial class Adm : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoaController;

        public Adm()
        {
            InitializeComponent();
            pessoaModel = new PessoaModel();
            pessoaController = new PessoaController();
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
            MessageBox.Show(pessoaController.Mensagem);
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
            string reportPath = @"F:\Relatorios\PIM-III-ADS.pbix";

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

            List<PessoaController> todasPessoas = pessoaController.BuscarTodasPessoas();

            pessoaController.ConfigurarColunas(dgvPessoa, todasPessoas);

            // Configuração para ajustar o tamanho da tabela ao DataGridView
            dgvPessoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPessoa.AutoResizeColumns();
        }

        private void RecarregarDadosDataGridView()
        {
            PessoaController pessoa = new PessoaController();
            List<PessoaController> todasPessoas = pessoaController.BuscarTodasPessoas();

            dgvPessoa.DataSource = todasPessoas;
        }
    }
}
