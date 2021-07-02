using System;
using CV_Generator.Domain.Correos;
using CV_Generator.Domain.Model;
using CV_Generator.Domain.CV;


namespace CV_Generator.Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoDTO info = new InfoDTO("Florentina", "Ghergan", "Nuestro Amor", "florentina.ghergan2078@gmail.com");
            CvGenerator.GenerarCurriculum(info);
            //Correo.EnviarCorreo(info);
            //CvGenerator.EliminaArchivo(info);
            
            
                       
        }
    }
}
