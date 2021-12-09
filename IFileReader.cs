using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsideConsole
{
    public interface IFileReader
    {
        string GetFileText(string fileLocation);
    }
}
