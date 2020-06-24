using System;
using System.Collections.Generic;
using System.Text;

namespace CSVParser
{
    class distritos
    {
        public string cod_distrito { get; set; }
        public string nome_distrito { get; set; }

        public distritos(string cod, string name)
        {
            cod_distrito = cod;
            nome_distrito = name;
        }
    }
}
