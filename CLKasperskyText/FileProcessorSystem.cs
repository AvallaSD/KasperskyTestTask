using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CLKasperskyText
{
    /// <summary>
    /// Класс для работы с файлами. 
    /// Для внесения новых типов необходимо:
    /// - внести в проект класс для обработки данного типа. Класс должен наследовать FileProcessor
    /// - добавить тип данных и класс для его обработки в словарь типов
    /// </summary>
    public class FileProcessorSystem
    {
        /// <summary>
        /// Экземпляр обработчика файлов
        /// </summary>
        private FileProcessor processor;

        /// <summary>
        /// Результат обработки
        /// </summary>
        public string ProcessResult { get; private set; }

        /// <summary>
        /// Словарь типов. Ключ - имя типа. Значение - объект типа Type
        /// </summary>
        private Dictionary<string, Type> extentionTypesTable = new Dictionary<string, Type>
        {
            { "txt" , typeof(FileProcessorText) },
            { "json" , typeof(FileProcessorJson) },
            { "html" , typeof(FileProcessorHtml) }
        };

        /// <summary>
        /// Обработка файла. Результат зависит от разрешения
        /// </summary>
        /// <param name="filename">Имя файла</param>
        public void ProcessFile(string filename)
        {
            processor = new FileProcessor();
            string extention = filename.Substring(filename.LastIndexOf(".") + 1);

            if (extentionTypesTable.Keys.Contains(extention))
            {
                processor = Activator.CreateInstance(extentionTypesTable[extention]) as FileProcessor;
            }

            processor.ProcessFile(filename);
            ProcessResult = processor.processResult;
        }
    }
}
