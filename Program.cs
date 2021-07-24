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
            try
            { 
            string path = args[1];
            Console.WriteLine("trying path: " + path);

            FileDetails fd = new FileDetails();
            Console.WriteLine(fd.Version(path));
            Console.WriteLine(fd.Size(path));
            Console.Read();
         }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
