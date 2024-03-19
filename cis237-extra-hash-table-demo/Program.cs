using System;
using System.Collections.Generic;

namespace cis237_extra_hash_table_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericHashTables<int, string> valleyNumToName = new GenericHashTables<int, string>();

            Console.WriteLine("Adding some entries to the Hashtable");

            Console.WriteLine("EX: valleyNumToName.Put(12345, \"David Barnes\")");

            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(56789, "Jonathan Archer");
            valleyNumToName.Put(67890, "Jason Isaacs");
            valleyNumToName.Put(78901, "Carol Freeman");

            Console.WriteLine("The created hash table");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine(valleyNumToName.ShowArray());
            Console.WriteLine("******************************************");

            Console.WriteLine("Get a single value out from the hash table");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));
            Console.WriteLine();

            Console.WriteLine("What if we add 2 entries that collide");
            Console.WriteLine("valleyNumToName.Put(26189, \"First Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("valleyNumToName.Put(26092, \"Second Entry\")");
            valleyNumToName.Put(26092, "Second Entry");

            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine(valleyNumToName.ShowArray());

            Console.WriteLine("Get the first entry out");
            Console.WriteLine("valleyNumToName.Get(26189)");
            Console.WriteLine(valleyNumToName.Get(26189));
            Console.WriteLine("Should get second entry instead. First was overwritten.");
            Console.WriteLine();
            Console.WriteLine();

            //***************************************************************************

            GenericHashTables<string, string> stringOne = new GenericHashTables<string, string>();

            stringOne.Put("My neat key", "Joe Smith");
            stringOne.Put("other Key", "Freddy Rico");

            Console.WriteLine("Fetch other Key out");
            Console.WriteLine(stringOne.Get("other Key"));
            Console.WriteLine();
            Console.WriteLine();

            //***************************************************************************

            Dictionary<int, string> myDict = new Dictionary<int, string>();
            Console.WriteLine("Use the built in Dictionary for the collision entries");
            myDict[26189] = "First Entry";
            myDict[26092] = "Second Entry";
            Console.WriteLine(myDict[26189]);
            Console.WriteLine(myDict[26092]);
            Console.WriteLine("They are both there.");
            Console.WriteLine();
            Console.WriteLine();

            //***************************************************************************

            Dictionary<string, string> stringDict = new Dictionary<string, string>();
            Console.WriteLine("Use built in Dictionary for a string dict");
            stringDict["foobar"] = "Joe Smith";
            stringDict["barbaz"] = "Freddy Rico";
            Console.WriteLine(stringDict["foobar"]);
            Console.WriteLine(stringDict["barbaz"]);
            Console.WriteLine("String keys work tool!");
            Console.WriteLine();
            Console.WriteLine();

        }

    }

}
