using DataLibrary.Context;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Repository
{
    public class RepositoryPerson
    {
        public List<Person> ListAll()
        {
            List<Person> peopleList = new List<Person>();
            using(BebidasContext context = new BebidasContext())
            {
                peopleList = context.Person.ToList();
            }
            return peopleList;
        }

        public void ToSave(Person person)
        {
            using (BebidasContext context= new BebidasContext())
            {
                context.Person.Add(person);
                context.SaveChanges();
            }
        }

    }
    
}
