using ExtensionsLibrary;

namespace StringsInterning;

internal class StringSample
{
    public void UseNonInterned()
    {
        const int numberOfStrings = 10000;

        // Array to hold non-interned strings
        var nonInternedStrings = new string[numberOfStrings];

        // Create a large number of identical strings
        for (var i = 0; i < numberOfStrings; i++) nonInternedStrings[i] = new string(new[] { 'H', 'e', 'l', 'l', 'o' });
        var memoryInUse = GC.GetTotalMemory(true);
        $"Memory in use is {memoryInUse:###,###}".Dump();
    }

    public void UseInterned()
    {
        const int numberOfStrings = 10000;

        // Array to hold non-interned strings
        var internedStrings = new string[numberOfStrings];

        internedStrings[0] = new string(new[] { 'H', 'e', 'l', 'l', 'o' });

        // Create a large number of identical strings
        for (var i = 1; i < numberOfStrings; i++) internedStrings[i] = string.Intern(internedStrings[0]);

        var memoryInUse = GC.GetTotalMemory(true);
        $"Memory in use is {memoryInUse:###,###}".Dump();
    }
}