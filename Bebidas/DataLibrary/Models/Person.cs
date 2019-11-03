using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Person
    {
        #region Properties

        public string Name { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{Name};{LastName};{CPF}";
        }

        #endregion

    }
}
