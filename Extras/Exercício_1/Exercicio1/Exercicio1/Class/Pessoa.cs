using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio1.Class
{
    class Pessoa
    {
        #region Propriedades

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Idade { get; set; }
        public string CPF { get; set; }

        #endregion
        #region Metodos

        public override string ToString()
        {
            return $"{Nome};{SobreNome};{Idade};{CPF}";
        }

        #endregion

    }
}
