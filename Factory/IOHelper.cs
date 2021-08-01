using System;
using System.IO;

namespace FactoryStandard
{
    public static class IOHelper
    {
        /// <summary>
        /// Valida la existencia de un directorío físico.
        /// </summary>
        /// <param name="_path">Ruta física del directorío</param>
        /// <param name="create">Crea el directorío, si no existiera</param>
        /// <returns>Verdadero si el directorio existe</returns>
        public static bool DirectoryExists(string _path, bool create)
        {
            bool _exist = false;

            // Valida la existencia del directorio
            if (Directory.Exists(_path))
            {
                _exist = true;
            }

            // Crea el directorio si no existiera
            if ((_exist == false) && (create == true))
            {
                _exist = true;
                Directory.CreateDirectory(_path);
            }

            return _exist;
        }

        /// <summary>
        /// Indica si el archivo existe en el directorio destino.
        /// </summary>
        /// <param name="_path">Ruta donde se ubica el archivo fisico</param>
        /// <returns>True si el archivo existe, false en caso contrario.</returns>
        public static bool FileExists(string _path)
        {
            if (File.Exists(_path))
                return true;
            else
                return false;
        }

        //public static string OpenFileDialog(string initialDirectory = "c:\\")
        //{
        //    string ret = string.Empty;

        //    Stream myStream = null;
        //    OpenFileDialog openFileDialog1 = new OpenFileDialog();

        //    openFileDialog1.InitialDirectory = initialDirectory;
        //    openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
        //    openFileDialog1.FilterIndex = 1;
        //    openFileDialog1.RestoreDirectory = true;

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            if ((myStream = openFileDialog1.OpenFile()) != null)
        //            {
        //                ret = openFileDialog1.FileName;

        //                //using (myStream)
        //                //{
        //                //    // Insert code to read the stream here.
        //                //}
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception ("Error: Could not read file from disk. Original error: " + ex.Message);
        //        }
        //    }

        //    return ret;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_line">Line to write.</param>
        /// <param name="_output">Path directory output.</param>
        public static void WriteToFile(string _line, string _output)
        {
            try
            {
                string directory = _output;
                string fileName = string.Concat("Output_", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, ".txt");
                string path = string.Concat(directory, fileName);

                if (!File.Exists(path))
                {
                    Directory.CreateDirectory(directory);
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        writer.WriteLine(_line);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
        }
    }
}
