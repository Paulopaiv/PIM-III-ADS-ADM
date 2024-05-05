using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using PIM_III_ADS_ADM.Service;

namespace PIM_III_ADS_ADM.Utils
{
    public class EnviaEmail
    {
        public void EnviarEmail(string nome, string destinatario, string codigo, string formaDePagamento, string valorIngresso)
        {
            MailMessage message = new MailMessage();
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Timeout = 60 * 1000;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pim3ads@gmail.com", "q n a m n b c j e r x fa h r r");

                message.From = new MailAddress("pim3ads@gmail.com");

                message.Body = message.Body = "<html>" +
               "<head>" +
               "<style>" +
               "body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background-color: #000048; color: #fff; }" +
               ".container { max-width: 600px; margin: 0 auto; padding: 20px; background-color: #f8f8f8; border-radius: 10px; }" +
               ".header { background-color: #22128e; color: #fff; text-align: center; padding: 10px; border-top-left-radius: 10px; border-top-right-radius: 10px; }" +
               ".content { padding: 20px; }" +
               ".footer { background-color: #22128e; color: #fff; text-align: center; padding: 10px; border-bottom-left-radius: 10px; border-bottom-right-radius: 10px; }" +
               ".content p { font-size: 18px; }" +
               "</style>" +
               "</head>" +
               "<body>" +
               "<div class='container'>" +
               "<div class='header'>" +
               "<h1>Experiência Única!</h1>" +
               "</div>" +
               "<div class='content'>" +
               $"<p>Olá, {nome}!</p>" +
               "<p>Embarque em uma viagem incrível pela história da conquista da Lua no Museu da Viagem do Homem à Lua!</p>" +
               $"<p>Seu código de visitante é: {codigo}</p>" +
               $"<p>Forma de pagamento: {formaDePagamento}</p>" +
               $"<p>Valor do ingresso: R${valorIngresso}</p>" +
               "</div>" +
               "<div class='footer'>" +
               "<h2>Não perca esta oportunidade!</h2>" +
               "</div>" +
               "</div>" +
               "</body>" +
               "</html>";
                message.Subject = "Seu Código de Visitante";
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                message.To.Add(new MailAddress(destinatario));

                smtp.Send(message);
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro ao enviar e-mail!");
            }
        }
    }
}
