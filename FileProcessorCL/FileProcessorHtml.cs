using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKasperskyText
{
    /// <summary>
    /// Класс для обработки HTML файлов. Наследует класс FileProcessor
    /// </summary>
    public class FileProcessorHtml : FileProcessor
    {
        /// <summary>
        /// Результат выполнения обработки
        /// </summary>
        override public string processResult { get; set; }

        /// <summary>
        /// Обработка файла
        /// </summary>
        /// <param name="fileName">Имя HTML файла</param>
        override public void ProcessFile(string fileName)
        {
            processResult = $"Html File processed: {fileName}";
        }
    }
}
