using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptography;

namespace MyEncryptors
{
    public class MW7Cryptor
        : Cryptor
    {
        public MW7Cryptor()
        {
            
        }
        public MW7Cryptor(string name)
        {
            base.Name = name;
            base.Key();
        }
        public override double ComplexityRate(string parameter)
        {
            if (parameter.Length < 15)
            {
                double rate = (Convert.ToDouble(parameter.Length) / 15) * 100;
                return rate;
            }
            else
            {
                return 100;
            }
        }
        public override string Description => "MW7 şifrelemesi";
        public override string[] CryptorMethod(string parameter)
        {
            string[] crypText = parameter.Split('a');
            return crypText;
        }

        public override void Mix(string content)
        {
            Console.WriteLine("Mixing");
        }
    }
}
