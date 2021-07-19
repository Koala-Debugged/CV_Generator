using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using iText.Pdfa;
using CV_Generator.Domain.Model;
using System.Configuration;
using iText.Kernel.Pdf;
using iText.Forms;

namespace CV_Generator.Domain.CV
{
    public class CvGenerator
    {

        /// <summary>
        /// Este método genera el curriculum relleno mediante la plantilla que existe en el servidor.
        /// </summary>
        /// <param name="pathOrigen"></param>
        /// <param name="pathDestino"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool GenerarCurriculum(InfoDTO info)
        {
            bool flag = false;
            string pathDestino = ConfigurationManager.AppSettings["PathDestino"];
            string pathFinal = pathDestino + "CV_JuanAntonioSánchezCarmona_" + info.Empresa + ".pdf";
            string pathOrigen = ConfigurationManager.AppSettings["PathTemplate"];

            try
            {
                PdfADocument doc = new PdfADocument(new PdfReader(pathOrigen), new PdfWriter(pathFinal));

                PdfAcroForm form = PdfAcroForm.GetAcroForm(doc, false);

                form.SetGenerateAppearance(true);

                form.GetField("Encabezado").SetValue(info.Nombre);
                form.GetField("PiePágina").SetValue(new string("Descargado por " + info.Nombre + " " + info.Apellidos + "  para la empresa " + info.Empresa));
                form.GetField("FechaYHora").SetValue(DateTime.Now.AddHours(9).ToString()); //Se añaden 9 horas porque es la diferencia horaria con el servidor. 

                form.FlattenFields();

                doc.Close();

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

            return flag;
        }

    }
}
