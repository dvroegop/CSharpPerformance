namespace ExtensionsLibrary
{
    public static class StringExtensions
    {
        public static void Dump(this string message, 
            ConsoleColor foreground = ConsoleColor.Cyan,
            ConsoleColor background = ConsoleColor.Black)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.WriteLine($"{DateTime.Now:h:mm:ss.fff}\tThread ID: {System.Threading.Thread.CurrentThread.ManagedThreadId}\t{message}");
            Console.ResetColor();
        }
    }
}
