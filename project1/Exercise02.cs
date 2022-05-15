// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            decimal d = 1.33m; // utilizado para cálculos financeiros (Moeda)
            double d2 = 1.33; // utilizado para cálculos científicos e medições
            float f = 1.33f; // engine de jogos como o Unity devido a performance

            // Program p = new Program();
            int[] nums = new int[]{1, 2, 3, 4};
            int res = 0;

            foreach(int num in nums) {
                res += num;
            }
            System.Console.WriteLine(res);

            Person person1 = new Person();
            person1.AskName();
            person1.SayHello();
        }
    }

    class Person 
    {
        public string name {get; set;}

        public void SayHello()
        {
            System.Console.WriteLine($"\nHello {this.name}!\n");
        }

        public void AskName() {
            Console.Write("Enter your name (not empty): ");
            do {
                this.name = Console.ReadLine();
            } while (Regex.Replace(this.name, @"\s+", "") == "");
        }
    }
}