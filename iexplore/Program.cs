using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace iexplore
{
    class Program
    {
        static void Main(string[] args)
        {
            var AppPath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            string filePath = AppPath + "/browser_path.txt";
            //Console.WriteLine(filePath);

            Process p = new Process();
            if (args.Length == 1 && File.Exists(filePath))
            {
                string browser;
                StreamReader rdr = new StreamReader(filePath);
                browser = rdr.ReadToEnd();
                rdr.Close();
                //Console.Write(browser);                
                //Console.ReadKey();

                //Console.WriteLine(args[0]);
                //p.StartInfo.FileName = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
                p.StartInfo.FileName = browser;
                p.StartInfo.Arguments = args[0].ToString();
                p.Start();
            }
        }
    }
}
