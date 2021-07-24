using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = args[1];
            Console.WriteLine("trying path: " + path);

            FileDetails fd = new FileDetails();
            Console.WriteLine(fd.Version(path));
            Console.WriteLine(fd.Size(path));
            Console.Read();
        }
    }
}
