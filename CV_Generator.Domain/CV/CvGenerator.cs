using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using iTextSharp.text.pdf;
using CV_Generator.Domain.Model;

namespace CV_Generator.Domain.CV
{
    class CvGenerator
    {

        /// <summary>
        /// Este método genera el curriculum relleno mediante la plantilla que existe en el servidor.
        /// </summary>
        /// <param name="pathOrigen"></param>
        /// <param name="pathDestino"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        static bool GenerarCurriculum(string pathOrigen, string pathDestino, InfoDTO info)
        {
            bool flag = false;

            string pathFinal = string.Format(pathOrigen + info.Empresa);

            try
            {

                FileStream plantilla = new FileStream(pathOrigen, FileMode.Open);

                using (var newFile = new FileStream(pathDestino, FileMode.Create))
                {
                    var pdfReader = new PdfReader(plantilla);

                    var pdfStamper = new PdfStamper(pdfReader, newFile);

                    AcroFields fields = pdfStamper.AcroFields;

                    fields.SetField("Encabezado", info.Nombre);
                    fields.SetField("PiePágina", new string("Descargado por " + info.Nombre + " " + info.Apellidos + "  para la empresa " + info.Email));
                    fields.SetField("FechaYHora", DateTime.Now.ToString());

                    pdfStamper.FormFlattening = true;

                    plantilla.Close();
                    pdfStamper.Close();
                    pdfReader.Close();
                }

                flag = true;

            }
            catch (Exception ex)
            {
                flag = false;
            }
            finally
            {

            }

            return flag;
        }

    }
}
