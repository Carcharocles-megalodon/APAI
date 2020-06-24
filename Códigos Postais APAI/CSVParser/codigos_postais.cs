using System;
using System.Collections.Generic;
using System.Text;

namespace CSVParser
{
    class codigos_postais
    {
        public int cod_distrito { get; set; }
        public int cod_concelho { get; set; }
        public int cod_localidade { get; set; }
        public string nome_localidade { get; set; }
        public int cod_arteria { get; set; }
        public string tipo_arteria { get; set; }
        public string prep1 { get; set; }
        public string titulo_arteria { get; set; }
        public string prep2 { get; set; }
        public string nome_arteria { get; set; }
        public string local_arteria { get; set; }
        public string troco { get; set; }
        public string porta { get; set; }
        public string cliente { get; set; }
        public int num_cod_postal { get; set; }
        public int ext_cod_postal { get; set; }
        public string desig_postal { get; set; }
    }
}
