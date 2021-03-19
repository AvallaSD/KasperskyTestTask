using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKasperskyText
{
    /// <summary>
    /// Класс для обработки текстовых файлов. Наследует FileProcessor
    /// </summary>
    public class FileProcessorText : FileProcessor
    {
        /// <summary>
        /// Результат выполнения обработки
        /// </summary>
        override public string processResult { get; set; }

        /// <summary>
        /// Обработка текстового файла
        /// </summary>
        /// <param name="fileName">Имя txt файла</param>
        override public void ProcessFile(string fileName)
        {
            processResult = $"Text File processed: {fileName}";
        }
    }
}
