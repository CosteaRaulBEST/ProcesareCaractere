using System;
using System.IO;

namespace procesare_caractere
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var ct = new Continut();
            string filePath = Console.ReadLine();
            ct.FindFileAndWork(filePath);
        }        
            

            
        
    }
}
