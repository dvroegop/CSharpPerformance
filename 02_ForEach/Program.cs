// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics;
using _02_ForEach;
using BenchmarkDotNet.Running;
using ExtensionsLibrary;
using static BenchmarkDotNet.Running.BenchmarkRunner;

//var numbers = new int[100000000];
//var rnd = new Random();
//for (int i = 0;i < numbers.Length;i++)
//{
//    numbers[i] = rnd.Next(0, 1000);
//}


//LoopTester.Data = numbers;
////var summary = Run<LoopTester>();
//var lt = new LoopTester();
//var sw = Stopwatch.StartNew();
//lt.TestFor();

//sw.Stop();
//$"Run 1: {sw.ElapsedMilliseconds}".Dump();

//sw.Restart();
//lt.TestForEach();
//sw.Stop();
//$"Run 2: {sw.ElapsedMilliseconds}".Dump();

//MyList list = new MyList();
//var sw = Stopwatch.StartNew();
//foreach (var item in list)
//{
//   item.Dump();
//}
//sw.Stop();

//var elapsedMillisecondsForEach = sw.ElapsedMilliseconds;

//sw.Restart();
//var length = list.Items.Length;
//for (int i = 0; i < length; i++)
//{
//    list.Items[i].Dump();
//}
//sw.Stop();

//var elapsedMillisecondsFor = sw.ElapsedMilliseconds;

//$"For: {elapsedMillisecondsFor}".Dump();
//$"Foreach: {elapsedMillisecondsForEach}".Dump();

//var ml = new MyList();

//for (var i = 0; i < 5; i++)
//{
//    foreach (var x in ml)
//    {
//        string c = x;
//    }
//}


var summary = BenchmarkRunner.Run<MyListBenchmark>();