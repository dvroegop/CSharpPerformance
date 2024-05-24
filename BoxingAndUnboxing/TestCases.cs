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


        #region Passing an object

        private void DoSomethingElse(object i)
        {
            $"i is {i}".Dump();
        }
        #endregion

        #region Using a generic method

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
            var a = 42;


            #region The interfaces
            IComparable i = 42; 
            IEquatable<int> j = 42;
            #endregion

        }
        #endregion

        #region Comparison
        public void Comparison()
        {
            object s= "My string";
            var stuff  = true ? 42 : s; 
        }

        #endregion

    }
}
