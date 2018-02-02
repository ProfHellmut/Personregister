using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    [Serializable]
    public class Register
    {
        List<Person> personList;

        public Register()
        {
            personList = new List<Person>();
        }

        public bool AddPerson(string name, long pnr, string prof)
        {
            if (FindPerson(pnr) != null)
                return false;

            personList.Add(new Person(name, pnr, prof));
            return true;
        }

        public bool EditPerson(string name, long pnr, string prof)
        {
            Person person = FindPerson(pnr);

            if (person != null)
            {
                person.Name = name;
                person.Profession = prof;
                return true;
            }

            return false;
        }

        public bool RemovePerson(long pnr)
        {
            Person person = FindPerson(pnr);

            return person != null ? personList.Remove(person) : false;
        }

        public Person FindPerson(long pnr)
        {
            foreach (Person person in personList)
            {
                if (person.Pnr == pnr)
                    return person;
            }

            return null;
        }

        public List<Person> GetRegister()
        {
            return personList;
        }
    }
}
