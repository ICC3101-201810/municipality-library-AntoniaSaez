using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    class Program
    {
        [DllImport("ClassLibraryBueno")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        static void Main(string[] args)
        {
        }
    }
}
