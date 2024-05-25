// Number of strings to create

using ExtensionsLibrary;

// Number of strings to create
const int numberOfStrings = 10000;

// Array to hold non-interned strings
string[]? nonInternedStrings = new string[numberOfStrings];

// Create a large number of identical strings
for (int i = 0; i < numberOfStrings; i++)
{
    nonInternedStrings[i] = new string(new char[] {'H', 'e', 'l', 'l', 'o'});
}

// Check memory usage before interning
GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
GC.WaitForPendingFinalizers();
GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
long memoryBeforeInterning = GC.GetTotalMemory(true);

// Array to hold interned strings
string[] internedStrings = new string[numberOfStrings];

// Intern all strings
for (int i = 0; i < numberOfStrings; i++)
{
    internedStrings[i] = String.Intern(nonInternedStrings[i]);
}

nonInternedStrings = null;
// Check memory usage after interning
GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
GC.WaitForPendingFinalizers();
GC.Collect();
long memoryAfterInterning = GC.GetTotalMemory(true);

// Collect garbage and get final memory usage
GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive);
GC.WaitForPendingFinalizers();
GC.Collect();
long memoryAfterGC = GC.GetTotalMemory(true);


$"Memory before interning:\t {memoryBeforeInterning:###,###,###} bytes".Dump();
$"Memory after interning:\t\t {memoryAfterInterning:###,###,###} bytes".Dump();
$"Memory after GC: {memoryAfterGC} bytes".Dump();
