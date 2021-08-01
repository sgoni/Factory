using System;
using System.Threading.Tasks;

namespace FactoryStandard
{
    public static class UtilHelper
    {
        public static void Delay(int milisegundos)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(milisegundos);
                return 0;
            });

            t.Wait();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SendMail(string host, int port, string to, string from, string subject, string body, string userName, string passWord)
        {
            try
            {
                // Ejemplarizar objeto cliente de correo
                //SmtpClient smtp = new MySmtpClient(host, port, userName, passWord);

                //// Ejemplarizar objeto mail
                //MyMailMessage email = new MyMailMessage(to, from, subject, body);

                //// Operaciones del correo
                //Operaciones correo = new Operaciones(email, smtp);
                //correo.SendMail();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Valida si una cadena es un número y devuelve su valor númerico correcto.
        /// </summary>
        /// <param name="_number">Recibe la representación string del número por validar</param>
        /// <returns>El número valido</returns>
        public static int IsValidInt(string _number)
        {
            Int32.TryParse(_number, out int ret);
            return ret;
        }

        /// <summary>
        /// Valida si una cadena es una fecha y devuelve su valor fecha correcto.
        /// </summary>
        /// <param name="_date">Recibe la representación string de la fecha por validar</param>
        /// <returns>La fecha valida</returns>
        public static DateTime IsValidDate(string _date)
        {
            DateTime.TryParse(_date, out DateTime ret);
            return ret;
        }
    }
}
