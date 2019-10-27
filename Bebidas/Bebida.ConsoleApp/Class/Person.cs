using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebida.ConsoleApp.Class
{
    class Person
    {
        #region Properties

        public string Name { get; set; }
        public string LastName { get; set; }

        #endregion
        #region Methods

        public override string ToString()
        {
            return $"{Name};{LastName}";
        }

        #endregion

    }
}
