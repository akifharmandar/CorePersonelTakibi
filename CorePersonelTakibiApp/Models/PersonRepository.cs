using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePersonelTakibiApp.Models
{
    public static class PersonRepository
    {
        private static List<Person> _people;

        static PersonRepository()
        {
            _people = new List<Person>();
        }

        public static List<Person> People
        {
            get { return _people; }
        }

        public static void Create(Person person)
        {
            person.PersonID = _people.Count + 1;
            _people.Add(person);
        }

        public static void Delete(Person person)
        {
            _people.Remove(person);
        }

        public static Person GetById(int id)
        {
            return _people.FirstOrDefault(x=>x.PersonID==id);
        }
    }
}
