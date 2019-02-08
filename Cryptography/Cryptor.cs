using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public abstract class Cryptor
    {
        public string Name { get; set; }
        public string Key()
        {
            return "Cryptor Key";
        }

        public abstract void Mix(string content);
        public abstract double ComplexityRate(string parameter);
        public abstract string Description { get; }

        public abstract string[] CryptorMethod(string parameter);
    }
}
