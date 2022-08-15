namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(4, 7));
            Console.WriteLine(Methods.Add(4.6m, 6.7m));
            Console.WriteLine(Methods.Add(5, 9, true));
            Console.WriteLine(Methods.Add(0, 1, true));
            Console.WriteLine(Methods.Add(0,1, false));
        }
    }
}