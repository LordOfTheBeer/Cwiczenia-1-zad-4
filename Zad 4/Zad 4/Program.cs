namespace Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Podaj a");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");

            c = int.Parse(Console.ReadLine());

            if (a > b && b > c)

                Console.WriteLine(" Najwieksze jest " + a);

            else if (b > a && a > c)
                Console.WriteLine("Najwieksze jest " + b);

            else
                Console.WriteLine("Najwieksze jest " + c);

            Console.ReadKey();
        
        }
    }
}