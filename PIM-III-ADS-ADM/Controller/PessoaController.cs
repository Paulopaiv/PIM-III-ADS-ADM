
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

        }

        public PessoaController(string nome, string idade, string email, string cep, string codigo = null, int idadeDb = 0)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.cep = cep;
            this.codigo = string.IsNullOrEmpty(codigo) ? GerarCodigo(nome) : codigo;
            this.idadeDb = idadeDb;
        }


        public PessoaController(string codigo, string email)
        {
            this.codigo = codigo;
            this.email = email;
        }

        public string GerarCodigo(string nome)
        {
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



        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int IdadeDb
        {
            get { return idadeDb; }
            set { idadeDb = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }





    }
}
