using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace CSVParser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<concelhos> concelhos = new List<concelhos>();
            using (StreamReader reader = new StreamReader("concelhos.csv"))
            {
                string line;
                int ignore = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    ignore++;
                    if (ignore != 1)
                    {
                        string[] tokens = line.Split(',');
                        concelhos.Add(new concelhos(tokens[0].ToString(), tokens[1].ToString(), tokens[2]));
                    }

                }

            }
            List<distritos> distritos = new List<distritos>();
            using (StreamReader reader = new StreamReader("distritos.csv"))
            {
                string line;
                int ignore = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    ignore++;
                    if (ignore != 1)
                    {
                        string[] tokens = line.Split(',');
                        distritos.Add(new distritos(tokens[0].ToString(), tokens[1]));
                        
                    }

                }
            }
        }
    }
}
