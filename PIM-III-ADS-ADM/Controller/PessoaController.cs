

using PIM_III_ADS_ADM.Model;

namespace PIM_III_ADS_ADM.Controller
{
    public class PessoaController
    {
        private int idadeDb;
        private string nome;
        private string idade;
        private string email;
        private string cep;
        private string codigo;
        public DateTime data;
        private PessoaModel pessoaModel;

        public PessoaController()
        {
            pessoaModel = new PessoaModel();
        }


        public PessoaController(string nome, string idade, string email, string cep, string codigo, int idadeDb = 0)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.cep = cep;
            this.codigo = string.IsNullOrEmpty(codigo) ? GerarCodigo(nome) : codigo;
            this.idadeDb = idadeDb;
        }

        //public PessoaControle(string nome, string codigo)
        //{
        //    Nome = nome;
        //    Codigo = codigo;
        //}
        public PessoaController(string codigo)
        {
            this.codigo = codigo;
            // Inicializa os outros campos com valores padrão ou nulos
            this.nome = "";
            this.idade = "";
            this.email = "";
            this.cep = "";
            this.idadeDb = 0;
        }




        private string GerarCodigo(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return "Não é possível gerar código para um nome em branco.";
            }

            // Obtém as iniciais do nome
            string iniciais = string.Join("", nome.Split(' ').Select(s => s[0]));

            // Gera um número aleatório entre 10 e 99
            Random rnd = new Random();
            int numero = rnd.Next(10, 100);

            // Gera uma letra aleatória
            char letra = (char)rnd.Next('A', 'Z');

            // Concatena as partes para formar o código
            string codigo = $"{iniciais}{numero}{letra}{numero}";

            if (codigo.Length > 5)
            {
                codigo = codigo.Substring(0, 5);
            }
            return codigo;
        }

        public List<PessoaController> BuscarTodasPessoas()
        {
            return pessoaModel.BuscarTodasPessoas();
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
            dataGridView.Columns["Mensagem"].Visible = false;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int IdadeDb
        {
            get { return idadeDb; }
            set { idadeDb = value; }
        }
        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Codigo
        {
            get{ return codigo;}
            set{ codigo = value;}
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Mensagem
        {
            get;
            private set;
        }
    }
}
