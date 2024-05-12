
using PIM_III_ADS_ADM.Controller;

using PIM_III_ADS_ADM.Model;



namespace PIM_III_ADS_ADM.View
{

    public partial class Vendas : Form
    {
        private VendasController vendasController;
        private Pagamento pagamento;
        private PessoaController pessoaController;
        private VendasModel vendasModel;
        private PagamentoController pagamentoController;

        public Vendas(PessoaController pessoaController)
        {
            InitializeComponent();

            vendasController = new VendasController();
            pagamentoController = new PagamentoController();
            this.pessoaController = pessoaController; // Recebe o objeto PessoaController
            this.WindowState = FormWindowState.Maximized;
            pagamento = new Pagamento(vendasController, pessoaController); // Passa o objeto PessoaController
            vendasModel = new VendasModel(vendasController, pagamentoController, pessoaController);

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
            //this.Close();
        }

        private void AtualizarTipoIngresso(bool inteiro, bool meia, bool isento)
        {
            vendasController.Inteiro = inteiro;
            vendasController.Meia = meia;
            vendasController.Isento = isento;
            pagamento.Show();


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}