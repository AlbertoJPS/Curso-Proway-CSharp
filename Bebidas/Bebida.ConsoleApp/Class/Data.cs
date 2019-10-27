using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebida.ConsoleApp.Class
{
    class Data
    {
            string path = @"P:\Backup ProWay\C#\Curso-Proway-CSharp\Bebidas\People.txt";

        #region Method
        public void ToSave(Person person)
        {
            StreamWriter archive = File.AppendText(path);
            archive.WriteLine(person);
            archive.Close();
        }

        public List<Person> ReadAll()
        {

            List<Person> list = new List<Person>();
            StreamReader archive = File.OpenText(path);

            while (archive.EndOfStream == false)
            {
                string line = archive.ReadLine();
                string[] breakLine = line.Split(';');

                Person person = new Person();
                person.Name = breakLine[0];
                person.LastName = breakLine[1];

                list.Add(person);
            }

            return list;
        }
        #endregion

    }
}
