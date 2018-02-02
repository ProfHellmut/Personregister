using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public long Pnr { get; set; }
        public string Profession { get; set; }

        public Person(string name, long pnr, string profession)
        {
            Name = name;
            Pnr = pnr;
            Profession = profession;
        }
    }
}
