using System.Diagnostics;
using ExtensionsLibrary;

#region Setup

// Create a datablock
const int blockSize = 1_000_000;
var dataBlock = new string[blockSize];

for (var i = 0; i < blockSize; i++) dataBlock[i] = $"String: {i:00000000}";

#endregion



#region Synchronous

// Create a file
var sw = Stopwatch.StartNew();

var fileName = "DataBlock.txt";
using (var writer = new StreamWriter(fileName))
{
    for (var i = 0; i < blockSize; i++) writer.Write(dataBlock[i]);
    writer.Flush();
    writer.Close();
}

sw.Stop();
var measureTime = sw.ElapsedMilliseconds;
$"Synchronous write took {measureTime} milliseconds.".Dump();

#endregion

#region Asynchronous


sw.Restart();

var fileName2 = "DataBlock2.txt";
using (var writer = new StreamWriter(fileName2))
{
    for (var i = 0; i < blockSize; i++) await writer.WriteAsync(dataBlock[i]);

    await writer.FlushAsync();
    writer.Close();
}

sw.Stop();
measureTime = sw.ElapsedMilliseconds;
$"Asynchronous write took {measureTime} milliseconds.".Dump();

#endregion