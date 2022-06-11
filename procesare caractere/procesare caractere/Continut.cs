using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace procesare_caractere
{
    public class Continut
    {
        static bool IsLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }
        string fileName;
        int nrlinii = 0;
        int nrvocale = 0;
        int nrtotalcaracter = 0;
        int nrconsoane = 0;
        string vocale = "aeiouAeiou";
        public void FindFileAndWork(string fileName)
        {                 
                if (File.Exists(fileName))
                {
                    StreamReader reader = new StreamReader(fileName);
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        nrlinii++;
                        nrtotalcaracter = nrtotalcaracter + line.Length;
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (IsLetter(line[i]) == true)
                            {
                                if (vocale.IndexOf(line[i]) != -1)
                                {
                                    nrvocale++;
                                }
                                else
                                {
                                    nrconsoane++;
                                }

                            }
                        }
                    }
                    Console.WriteLine(nrlinii);
                    Console.WriteLine(nrvocale);
                    Console.WriteLine(nrconsoane);
                    Console.WriteLine(nrtotalcaracter);
                  
                }
                else
                {
                    Console.WriteLine("nu exista fisieru");
                }
            
        }
       

    }
}
