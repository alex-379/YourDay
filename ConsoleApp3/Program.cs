namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var b = new List<int> { 3, 4, };

            a = a.Except(b).ToList();

            Console.WriteLine();
        }
    }
}
