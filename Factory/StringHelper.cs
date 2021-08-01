using System;
using System.Text.RegularExpressions;

namespace FactoryStandard
{
    public static class StringHelper
    {
        /// <summary>
        /// El patrón de expresión regular [^\w\.@-] coincide con cualquier carácter que no sea un carácter de palabra,
        /// un punto, un símbolo @ o un guion. Un carácter de palabra es cualquier letra, dígito decimal o conector de 
        /// puntuación, como un guion bajo. Cualquier carácter que coincida con este patrón se sustituye por 
        /// String.Empty, que es la cadena definida por el modelo de reemplazo.  
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Funcion booleana para validar que el string de contenido no contenga caracteres 
        /// especiales (@, ', ",:, [, })
        /// </summary>
        /// <param name="strToCheck"></param>
        /// <returns>
        /// True: Si no posee caracteres especiales
        /// False: Si posee caracteres especiales 
        /// </returns>
        public static bool IsAlphaNumeric(string strToCheck)
        {
            try
            {
                Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
                return !objAlphaNumericPattern.IsMatch(strToCheck);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Remueve caracteres especiales de una cadena.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(string str)
        {
            try
            {
                //return Regex.Replace(str, "[^a-zA-Z0-9_.- ]+", "", RegexOptions.Compiled);
                return Regex.Replace(str, "[^0-9a-zA-Z ]+", "", RegexOptions.Compiled, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}
