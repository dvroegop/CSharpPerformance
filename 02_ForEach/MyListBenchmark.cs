using _02_ForEach;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class MyListBenchmark
{
    private MyList myList;

    [GlobalSetup]
    public void Setup()
    {
        myList = new MyList();
    }

    [Benchmark]
    public void ForLoop()
    {
        for (int i = 0; i < myList.Items.Length; i++)
        {
            DoSomething(myList.Items[i]);
        }
    }

    [Benchmark]
    public void ForeachLoop()
    {
        foreach (var item in myList)
        {
            DoSomething(item);
        }
    }

    private void DoSomething(string theString)
    {
        if (theString == "This will never happen")
            throw new ApplicationException("No idea what is going on here...");
    }
}

