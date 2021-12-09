using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsideConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();
            InfoManager im = new InfoManager(); ;
            gui.PrintInfo(im.GetWebInfo("https://docs.microsoft.com"));
            Console.ReadLine();
            gui.PrintInfo(im.GetFileInfo(@"C:\Users\caspe\Documents\test.txt"));
            Console.ReadLine();
        }
    }
}
