using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Configuration;
using CV_Generator.Domain.Model;

namespace CV_Generator.Domain.Correos
{
    public class Correo
    {
        /// <summary>
        /// Método encargado de mandar el e-mail con el curriculum adjunto y 
        /// un aviso a mi correo personal notificándome de la petición.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool EnviarCorreo(InfoDTO info)
        {
            bool flag = false;
            string userName = ConfigurationManager.AppSettings["EmailUsername"];
            string password = ConfigurationManager.AppSettings["EmailPassword"];
            string path =  ConfigurationManager.AppSettings["PathDestino"];
            string adjunto = path + "CV_JuanAntonioSánchezCarmona_" + info.Empresa + ".pdf";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(userName, password);

            try
            {
                string pathArchivo = string.Format(path + info.Empresa);

                MailMessage message = getMessage(info);

                smtp.Send(message);

                string asuntoP = string.Format("Curriculum descargado por {0}", info.Empresa);

                string contenidoP = string.Format("Buenas!\n\n {0} {1} de la empresa {2} se descargó tu curriculum a las {3}", info.Nombre, info.Apellidos, info.Empresa, DateTime.Now.AddHours(9).ToString());

                MailMessage messageP = new MailMessage(userName, ConfigurationManager.AppSettings["EmailPersonal"], asuntoP, contenidoP);

                smtp.Send(messageP);

                flag = true;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("log.txt"))
                {
                    sw.WriteLine(ex.ToString());
                }

                flag = false;
            }
            finally
            {
                smtp.Dispose();
                if (File.Exists(adjunto))
                    File.Delete(adjunto);
            }

            return flag;
        }

        private static MailMessage getMessage(InfoDTO info)
        {
            string userName = ConfigurationManager.AppSettings["EmailUsername"];
            string path = ConfigurationManager.AppSettings["PathDestino"];
            string adjunto = path + "CV_JuanAntonioSánchezCarmona_" + info.Empresa + ".pdf";


            MailMessage mail = new MailMessage();

            using (FileStream fs = File.OpenRead(adjunto))
            {
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(fs.Length);
                fs.Read(memStream.GetBuffer(), 0, (int)fs.Length);

                mail.Subject = string.Format("Curriculum descargado por {0}", info.Empresa);
                mail.To.Add(new MailAddress(info.Email));
                mail.From = new MailAddress(userName);
                mail.Body  = string.Format("Buenas {0} {1}, \n\n Mi nombre es Juan Antonio Sánchez Carmona, ha solicitado mi curriculum vitae y ha sido" +
                    " generado de manera automática a través de una API REST. \n\n No responda a este correo, mi correo personal se encuentra en el propio curriculum. " +
                    "\n\n Un saludo y muchas gracias por su interés en mi perfil.", info.Nombre, info.Apellidos);
                mail.Attachments.Add(new Attachment(memStream, "CV_JuanAntonioSánchezCarmona_" + info.Empresa + ".pdf"));

            }
            return mail;
        }

    }
}
