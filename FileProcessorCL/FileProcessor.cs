using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKasperskyText
{
    /// <summary>
    /// Исходный класс для обработки обычных файлов
    /// </summary>
    public class FileProcessor
    {
        /// <summary>
        /// Результат выполнения обработки
        /// </summary>
        virtual public string processResult { get; set; }
        
        /// <summary>
        /// Обработка файла
        /// </summary>
        /// <param name="fileName">Имя обычного файла</param>
        virtual public void ProcessFile(string fileName)
        {
            processResult = $"Common File processed: {fileName}";
        }
    }
}
