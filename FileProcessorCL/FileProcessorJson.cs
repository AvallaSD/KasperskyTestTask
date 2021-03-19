using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKasperskyText
{
    /// <summary>
    /// Класс для обработки JSON файлов. Наследует FileProcessor
    /// </summary>
    public class FileProcessorJson : FileProcessor
    {
        /// <summary>
        /// Результат обработки
        /// </summary>
        override public string processResult { get; set; }

        /// <summary>
        /// Обработка файла JSON
        /// </summary>
        /// <param name="fileName">Имя файла JSON</param>
        override public void ProcessFile(string fileName)
        {
            processResult = $"Json File processed: {fileName}";
        }
    }
}
