using ExtensionsLibrary;
using System.Runtime.CompilerServices;


var taskCount = 5;

var allTasks = new List<Task>();

var startSignal = new TaskCompletionSource<bool>();

for (var i = 0; i < taskCount; i++)
{
    int taskId = i;
    var task = Task.Run(async () =>
    {
        
        var rnd = new Random();
        await startSignal.Task;
        $"Task {taskId} started".Dump(ConsoleColor.Cyan);
        await Task.Delay(100);
        //await Task.Delay(rnd.Next(200, 2000));
        $"Task {taskId} finished".Dump(ConsoleColor.Blue);

    });

    allTasks.Add(task);
}

"Press Enter to start".Dump(ConsoleColor.Yellow);
Console.ReadKey();
startSignal.SetResult(true);

await Task.WhenAll(allTasks);
"Done..".Dump(ConsoleColor.Yellow);

"Press Enter to start the threads".Dump(ConsoleColor.Yellow);
Console.ReadKey();

for (int i=0;i< taskCount;i++)
{
    ThreadPool.QueueUserWorkItem(_ => {
        var rnd = new Random();
        $"Thread {System.Threading.Thread.CurrentThread.ManagedThreadId} started".Dump(ConsoleColor.Cyan);
        Thread.Sleep(100);
        $"Thread {System.Threading.Thread.CurrentThread.ManagedThreadId} ended".Dump(ConsoleColor.Blue);
    });
}



var list = new List<Func<Task>>();
for(int i = 0; i < 100; i++)
{
    list.Add(DoSomething);
}
Task.WaitAll(list.ToArray(), 1000);

"Press Enter to end the program".Dump(ConsoleColor.Yellow);
Console.ReadKey();

return;

async Task DoSomething()
{
    await Task.Delay(100);
}