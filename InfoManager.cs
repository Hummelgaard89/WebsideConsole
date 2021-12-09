using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsideConsole
{
    public class InfoManager
    {
        public string GetWebInfo(string userinput)
        {
            DalManager dm = new DalManager();
            return (dm.GetWebRequest(userinput));
        }
        public string GetFileInfo(string userinput)
        {
            DalManager dm = new DalManager();
            return dm.GetFileText(userinput);
        }
    }
}
