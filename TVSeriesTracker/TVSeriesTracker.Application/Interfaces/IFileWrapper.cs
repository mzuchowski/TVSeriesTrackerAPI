using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSeriesTracker.Application.Interfaces
{
    public interface IFileWrapper
    {
        void WriteAllBytes(string path, byte[] bytes);
    }
}