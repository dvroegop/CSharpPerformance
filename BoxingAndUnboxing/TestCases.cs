using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsLibrary;

namespace BoxingAndUnboxing
{
    internal class TestCases
    {

        

        internal void DoSomething()
        {
            int i = 42;
            DoSomethingElse(i);
            DoSomethingElseAgain(i);
        }


        #region Causes Boxing

        private void DoSomethingElse(object i)
        {
            $"i is {i}".Dump();
        }
        #endregion

        #region No Boxing

        private void DoSomethingElseAgain<T>(T i)
        {
            $"i is {i}".Dump();
        }
        #endregion

        #region Lists and arrays

        private void ListAndArrays()
        {
            var list = new List<int>();
            list.Add(42); // Boxing!
            int j  = list[0]; // Unboxing!

            var array = new int[1];
            array[0] = 42; // No boxing!
            int k = array[0]; // No unboxing!

        }
        #endregion

        #region Interfaces

        public void Interfaces()
        {
            IComparable i = 42; // Boxing!
            IEquatable<int> j = 42; // Boxing!
        }
        #endregion

        #region Comparison
        public void Comparison()
        {
             object s= "My string";
            var stuff  = true?42:s; // Boxing!

        }

        #endregion





    }
}
