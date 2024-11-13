using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVSeriesTracker.Application.Common.Interfaces;

namespace TVSeriesTracker.Infrastructure.FileStore
{
    public class FileWrapper : IFileWrapper
    {
        public void WriteAllBytes(string outputFile, byte[] content)
        {
            File.WriteAllBytes(outputFile, content);
        }
    }
}