namespace alapok
{
    internal class Program
    {
        // 14. feldatig kell
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
        static void feladat1(string[] args)
        {
            Console.WriteLine("Mi a neved?");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hali {name}");
        }
        static void feladat3(string[] args)
        {
            Console.WriteLine("Minek kell a 2 szerese?");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"A számod 2 szerese {number * 2}");
        }
        static void feladat4(string[] args)
        {
            Console.WriteLine("Adj meg ketto számot!");
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"A számok összege: {number + number2}");
            Console.WriteLine($"A számok külombsegük: {number - number2}");
            Console.WriteLine($"A számok szorzatuk: {number * number2}");
            Console.WriteLine($"A számok hányadosuk: {number / number2}");
        }
        static void feladat5(string[] args)
        {
            Console.WriteLine("Adj meg ketto számot!");
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            if (number < number2)
            {
                Console.WriteLine(number2);
            }
            else if (number2 < number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("A ketto szam ugyan akkora, vagy hibas a megadott szamok valamelyike.");
            }
        }
        static void feladat6(string[] args)
        {
            Console.WriteLine("Adj meg harom számot!");
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            int number3 = int.Parse(Console.ReadLine()!);
            if (number < number2 && number < number3)
            {
                Console.WriteLine(number);
            }
            else if (number2 < number && number2 < number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                 if (number3 < number2 && number3 < number)
                {
                    Console.WriteLine(number3);
                }
            }
        }
        static void feladat7(string[] args)
        {
            // 2 oldal osszege nagyobb mint a harmadik
            Console.WriteLine("Add meg a harmszog oldalait");
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            int number3 = int.Parse(Console.ReadLine()!);
            if (number + number2 > number3)
            {
                Console.WriteLine("Szerkeszthetoek az oldalak");
            }
            else if (number2 +  number3 > number)
            {
                Console.WriteLine("Szerkeszthetoek az oldalak");
            }
            else if (number3 + number2 > number)
            {
                Console.WriteLine("Szerkeszthetoek az oldalak");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthetoek az oldala a megadott parameterekkel");
            }
        }
        static void feladat8(string[] args)
        {

        }
    }
}