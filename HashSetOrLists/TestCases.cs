using BenchmarkDotNet.Attributes;

public class TestCases
{

    private const int N = 1_000_000;

    [Benchmark]
    public void HashSet()
    {
        var hashSet = new HashSet<int>();
        for(int i= 0; i < N; i++)
        {
            hashSet.Add(i);
        }

        var foundItem = hashSet.Contains(N - 1);
    }

    [Benchmark]
    public void List()
    {
        var list = new List<int>();
        for(int i= 0; i < N; i++)
        {
            list.Add(i);
        }
        var foundItem = list.Contains(N - 1);
    }
}