using System;
using System.Collections.Generic;
using System.Text;

namespace CSVParser
{
    class concelhos
    {
        public string cod_distrito { get; set; }
        public string cod_concelho { get; set; }
        public string nome_concelho { get; set; }

        public concelhos(string cod1, string cod2, string nome)
        {
            cod_distrito = cod1;
            cod_concelho = cod2;
            nome_concelho = nome;
        }
    }
}
