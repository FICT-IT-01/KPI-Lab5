using System;
using System.IO;

namespace Producer
{
    public class Report
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Stream LogFile { get; set; }

        public Report()
        {
            Id = Guid.NewGuid();
            Description = string.Empty;
        }

        public Report(string logFilePath) : this(string.Empty, logFilePath)
        { }

        public Report(string description, string logFilePath)
        {
            Id = Guid.NewGuid();
            Description = description;
            LogFile = ReadLogFileAsStream(logFilePath);
        }
        
        /// <remarks> Require file encoding UTF-8 without BOM </remarks>>
        private Stream ReadLogFileAsStream(string filePath)
        {
            return File.OpenText(filePath).BaseStream;
        }
    }
}