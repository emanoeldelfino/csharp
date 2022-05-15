// See https://aka.ms/new-console-template for more information

namespace Exercise01 
{
    class Program
    {
        static int[] FilterArray(object[] arr) {
            return arr.OfType<int>().ToArray();
        }

        static void Main1(string[] args)
        {
            foreach(int num in FilterArray(new Object[]{"1", "bbbb", 2, "ab", 8})) 
            {
                Console.WriteLine(num);
            }
        }
    }
}