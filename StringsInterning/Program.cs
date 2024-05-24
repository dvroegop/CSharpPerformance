// Number of strings to create

using ExtensionsLibrary;

const int numberOfStrings = 1000000;

// Array to hold non-interned strings
string[] nonInternedStrings = new string[numberOfStrings];

// Create a large number of identical strings
for (int i = 0; i < numberOfStrings; i++)
{
    nonInternedStrings[i] = new string(new char[]
        {'H', 'e', 'l', 'l', 'o', ' ', 'd', 'o', 't', 'N', 'e', 'd', 'S', 'a', 't', 'u', 'r', 'd', 'a', 'y', '!'});
}

// Check memory usage before interning
long memoryBeforeInterning = GC.GetTotalMemory(true);

// Array to hold interned strings
string[] internedStrings = new string[numberOfStrings];

// Intern all strings
for (int i = 0; i < numberOfStrings; i++)
{
    internedStrings[i] = String.Intern(nonInternedStrings[i]);
}

// Check memory usage after interning
long memoryAfterInterning = GC.GetTotalMemory(true);


$"Memory before interning:\t {memoryBeforeInterning:###,###,###} bytes".Dump();
$"Memory after interning:\t\t {memoryAfterInterning:###,###,###} bytes".Dump();
