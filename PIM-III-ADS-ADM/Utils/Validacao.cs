
using Newtonsoft.Json.Linq;
using PIM_III_ADS_ADM.Controller;
using PIM_III_ADS_ADM.Service;
using PIM_III_ADS_ADM.Service;
using System.Net;
using System.Text.RegularExpressions;


namespace PIM_III_ADS_ADM.Utils
{
    public class Validacao
{
    private readonly PessoaServico pessoaServico;
    private string mensagem;

    public Validacao()
    {
        pessoaServico = new PessoaServico(new Dbconexao(), new EnviaEmail());
    }

    public Validacao(PessoaController pessoaController)
    {
        ValidarPessoa(pessoaController);
    }

    internal void ValidarPessoa(PessoaController pessoaController)
    {
        mensagem = "";
        ValidarCep(pessoaController);
        ValidarEmail(pessoaController);
        ValidarIdade(pessoaController);
        ValidarNome(pessoaController);
    }

    private void ValidarNome(PessoaController pessoaController)
    {
        if (string.IsNullOrWhiteSpace(pessoaController.Nome))
        {
            setMensagem("Por favor, insira um nome.");
        }

        if (pessoaController.Nome.Any(char.IsDigit))
        {

            setMensagem("O nome não pode conter números.");
        }

        if (!Regex.IsMatch(pessoaController.Nome, @"^[A-Z][a-zA-Z\s]*$"))
        {
            setMensagem("O nome deve começar com uma letra maiúscula e conter apenas letras e espaços.");
        }

        pessoaController.Nome = pessoaController.Nome;
    }

    private void ValidarIdade(PessoaController pessoaController)
    {
        if (string.IsNullOrWhiteSpace(pessoaController.Idade))
        {
            setMensagem("Por favor, insira uma idade válida.");
            return;
        }
        if (!int.TryParse(pessoaController.Idade, out int idade))
        {
            setMensagem("A idade deve ser um número inteiro válido.");
            return;
        }

        if (idade < 12)
        {
            setMensagem("Menores de 12 anos não podem entrar desacompanhados.");
            return;
        }

        if (idade > 120)
        {
            setMensagem("Por favor, insira uma idade válida.");
            return;
        }

        pessoaController.IdadeDb = idade;
    }

    public void ValidarEmail(PessoaController pessoaController)
    {
        if (string.IsNullOrWhiteSpace(pessoaController.Email))
        {
            setMensagem("Por favor, insira um endereço de e-mail.");
            return;
        }

        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        if (!Regex.IsMatch(pessoaController.Email, pattern))
        {
            setMensagem("Por favor, insira um endereço de e-mail válido.");
            return;
        }

        // Verificar se o email já está em uso apenas ao salvar uma nova pessoaController
        if (pessoaController.Codigo == null)
        {
            var pessoaExistente = pessoaServico.BuscarPessoaPorEmail(pessoaController.Email);
            if (pessoaExistente != null)
            {
                setMensagem("Este endereço de e-mail já está em uso. Por favor, escolha outro.");
                return;
            }
        }
    }

    private void ValidarCep(PessoaController pessoaController)
    {
        if (string.IsNullOrWhiteSpace(pessoaController.Cep) || !Regex.IsMatch(pessoaController.Cep, @"^\d{8}$"))
        {
            setMensagem("Por favor, insira um CEP válido (formato: 00000000)");
        }
        else
        {
            using (WebClient webClient = new WebClient())
            {
                string url = $"https://viacep.com.br/ws/{pessoaController.Cep}/json/";
                string response = webClient.DownloadString(url);
                dynamic jsonObject = JObject.Parse(response);

                if (jsonObject["erro"] != null)
                {
                    setMensagem("CEP não encontrado. Por favor, insira um CEP válido.");
                }
            }
        }

        pessoaController.Cep = pessoaController.Cep;
    }

    public string Mensagem
    {
        get { return mensagem; }
    }

    public void setMensagem(string mensagem)
    {
        this.mensagem = mensagem;
    }
}
}
