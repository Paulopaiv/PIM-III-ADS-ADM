using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III_ADS_ADM.Utils
{
    public class EnviaEmail
    {
        public void EnviarEmail(string destinatario, string codigo)
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
                message.Body = $"Olá,\n\nObrigado por comprar seu ingresso para o museu!" +
                                $"\n\nSeu código de visitante é: {codigo}" +
                                $"\n\nTenha uma ótima visita!";
                message.Subject = "Seu Código de Visitante";
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                message.To.Add(new MailAddress(destinatario));

                smtp.Send(message);
            }
            catch (Exception Erro)
            {

                throw new Exception("Erro ao enviar e-mail: " + Erro.Message);
            }
        }
    }
}
