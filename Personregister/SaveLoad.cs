using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Personregister
{
    class SaveLoad
    {
        string path = "C:\\C# Filer\\person.kooltreg";

        public void SaveToFile(Register register)
        {
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, register);
            }
        }

        public Register LoadFromFile()
        {
            Register register;

            try
            {
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    register = (Register)bf.Deserialize(stream);
                }
            }
            catch(IOException e) { register = new Register(); }

            return register;
        }
    }
}
