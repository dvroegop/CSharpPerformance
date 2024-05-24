using BenchmarkDotNet.Attributes;

namespace ForeachVersusFor;

public class TestCases
{
    private readonly MyList _myList  = new MyList();

    [Benchmark]
    public void ForLoop()
    {
        for (var i = 0; i < _myList.Items.Length; i++)
        {
            DoSomething(_myList.Items[i]);
        }
    }

    [Benchmark]
    public void ForeachLoop()
    {
        foreach (var item in _myList)
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