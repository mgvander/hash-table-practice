using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cis237_extra_hash_table_demo
{
    internal class GenericHashTables<TypeKey, TypeValue>
    {
        private const int PRIMEVALUE = 97;

        TypeValue[] theValues;

        TypeKey[] theKeys;

        public GenericHashTables()
        {
            theValues = new TypeValue[PRIMEVALUE];

            theKeys = new TypeKey[PRIMEVALUE];

        }

        public TypeValue Get(TypeKey key)
        {
            int indexForValue = hashFunction(key);

            return theValues[indexForValue];

        }

        public void Put(TypeKey key, TypeValue value)
        {
            int indexForValue = hashFunction(key);

            theValues[indexForValue] = value;

            theKeys[indexForValue] = key;

        }

        private int hashFunction(TypeKey key)
        {
            return Math.Abs(key.GetHashCode()) % PRIMEVALUE;

        }

        public override string ToString()
        {
            string returnString = "Key   => Value\n";

            returnString += "------------------------\n";

            for (int i = 0; i < theValues.Length; ++i)
            {
                if (theValues[i] != null)
                {
                    returnString += theKeys[i] + " => " + theValues[i] + "\n";

                }

            }

            return returnString;

        }

        public string ShowArray()
        {
            string returnString = "Key   => Value\n";

            returnString += "------------------------\n";

            for (int i = 0; i < theValues.Length; ++i)
            {
                returnString += "[" + i + "] => " + theValues[i] + "\n";                

            }

            return returnString;

        }

    }

}
