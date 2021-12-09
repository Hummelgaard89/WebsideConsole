using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsideConsole
{
    public class DalManager : IWebRequest, IFileReader
    {
        //Method to read a web request.
        public string GetWebRequest(string userrequest)
        {
            WebRequest request = WebRequest.Create(userrequest);
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string responsestring = sr.ReadToEnd();
            return responsestring;
        }
        //Method to read a text file.
        public string GetFileText(string fileLocation)
        {
            string text = File.ReadAllText(fileLocation);
            return text;
        }
    }
}
