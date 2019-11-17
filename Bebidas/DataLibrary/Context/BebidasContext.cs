using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Context
{
    public class BebidasContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public BebidasContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=P:\Backup ProWay\C#\Curso-Proway-CSharp\Bebidas\DataLibrary\Database\Database.mdf;Integrated Security=True")
        {

        }
    }
}
