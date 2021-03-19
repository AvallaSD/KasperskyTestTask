using System;
using Xunit;
using CLKasperskyText;

namespace KasperskyText
{
    public class FileProcessorTests
    {
        [Fact]
        public void FileProcessorCommonTest()
        {
            FileProcessor processor = new FileProcessor();
            processor.ProcessFile("file1");
            Assert.Equal("Common File processed: file1", processor.processResult);
        }

        [Fact]
        public void FileProcessorHtmlTest()
        {
            FileProcessor processor = new FileProcessorHtml();
            processor.ProcessFile("file2");
            Assert.Equal("Html File processed: file2", processor.processResult);
        }

        [Fact]
        public void FileProcessorJsonTest()
        {
            FileProcessor processor = new FileProcessorJson();
            processor.ProcessFile("file3");
            Assert.Equal("Json File processed: file3", processor.processResult);
        }

        [Fact]
        public void FileProcessorTextTest()
        {
            FileProcessor processor = new FileProcessorText();
            processor.ProcessFile("file4");
            Assert.Equal("Text File processed: file4", processor.processResult);
        }

    }
}