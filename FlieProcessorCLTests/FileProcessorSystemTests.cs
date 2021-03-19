using Xunit;
using CLKasperskyText;

namespace KasperskyText
{
    public class FileProcessorSystemTests
    {
        [Fact]
        public void FileProcessorSystemCommonTest()
        {
            FileProcessorSystem system = new FileProcessorSystem();
            system.ProcessFile("commonfile.lol");
            Assert.Equal("Common File processed: commonfile.lol", system.ProcessResult);
        }

        [Fact]
        public void FileProcessorSystemTextTest()
        {
            FileProcessorSystem system = new FileProcessorSystem();
            system.ProcessFile("txtfile.txt");
            Assert.Equal("Text File processed: txtfile.txt", system.ProcessResult);
        }

        [Fact]
        public void FileProcessorSystemHtmlTest()
        {
            FileProcessorSystem system = new FileProcessorSystem();
            system.ProcessFile("htmlfile.html");
            Assert.Equal("Html File processed: htmlfile.html", system.ProcessResult);
        }

        [Fact]
        public void FileProcessorSystemJsonTest()
        {
            FileProcessorSystem system = new FileProcessorSystem();
            system.ProcessFile("jsonfile.json");
            Assert.Equal("Json File processed: jsonfile.json", system.ProcessResult);
        }
    }
}
