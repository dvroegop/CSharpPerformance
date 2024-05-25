
using ExtensionsLibrary;
using StringsInterning;

"Press 1 for non interned, press 2 for interned".Dump(ConsoleColor.Yellow);

var choice = Console.ReadKey().KeyChar;
if (choice == '1')
{
    var stringSample = new StringSample();
    stringSample.UseNonInterned();
}
else if (choice == '2')
{
    var stringSample = new StringSample();
    stringSample.UseInterned();
}
else
{
    "Invalid choice".Dump(ConsoleColor.Red);
}
