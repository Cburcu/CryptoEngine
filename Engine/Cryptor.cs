using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Cryptor
    {
        public string[] CryptorMethod(string methodName, string text, Assembly asm)
        {
            Object methodInstance = asm.CreateInstance("MyEncryptors." + methodName);
            if (methodInstance != null)
            {
                MethodInfo cryptorMethod = methodInstance.GetType().GetMethod("CryptorMethod");
                Object[] textObjects = { text };

                var method = cryptorMethod.Invoke(methodInstance, textObjects);
                return (string[])method;
            }

            return null;

        }
    }
}
