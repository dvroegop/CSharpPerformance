using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsLibrary;

namespace StringsInterning
{
    internal class StringSample
    {
        public void UseNonInterned()
        {
            const int numberOfStrings = 10000;

            // Array to hold non-interned strings
            string[]? nonInternedStrings = new string[numberOfStrings];

            // Create a large number of identical strings
            for (int i = 0; i < numberOfStrings; i++)
            {
                nonInternedStrings[i] = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            }
            long memoryInUse = GC.GetTotalMemory(true);
            $"Memory in use is {memoryInUse:###,###}".Dump();
        }

        public void UseInterned()
        {
            const int numberOfStrings = 10000;

            // Array to hold non-interned strings
            string[]? internedStrings = new string[numberOfStrings];

            internedStrings[0] = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });
            
            // Create a large number of identical strings
            for (int i = 1; i < numberOfStrings; i++)
            {
                internedStrings[i] = String.Intern(internedStrings[0]);
            }
            
            long memoryInUse = GC.GetTotalMemory(true);
            $"Memory in use is {memoryInUse:###,###}".Dump();
        }

    }
}
