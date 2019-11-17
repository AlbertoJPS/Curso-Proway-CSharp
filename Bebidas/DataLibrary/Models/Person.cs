using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Person
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Last Name")]
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
