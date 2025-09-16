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
            Console.WriteLine("1 and 2.feladat");
            Console.WriteLine("Mi a neved?");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Hali {name}");
        }
        static void feladat3(string[] args)
        {
            Console.WriteLine("3.feladat");
            Console.WriteLine("Minek kell a 2 szerese?");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"A számod 2 szerese {number * 2}");
        }
        static void feladat4(string[] args)
        {
            Console.WriteLine("4.feladat");
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
            Console.WriteLine("5.feladat");
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
            Console.WriteLine("6.feladat");
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
            Console.WriteLine("7.feladat");
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
            Console.WriteLine("8.feladat");
            Console.WriteLine("Adj meg ketto számot!");
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"A ket szam szamtani es mertani kozepe: {(number + number2) % 2}");
        }
        static void feladat9(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);
            int number2 = int.Parse(Console.ReadLine()!);
            int number3 = int.Parse(Console.ReadLine()!);
            int number4 = 0;
            number4 = number2 * number2 - 4 * number * number3;
        }
        static void feladat10(string[] args) {
            Console.Write("Add meg az a együtthatót: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a b együtthatót: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a c együtthatót: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Ez nem másodfokú egyenlet.");
                return;
            }
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Az egyenletnek nincs valós megoldása.");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Az egyenletnek egy valós megoldása van: x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Az egyenletnek két valós megoldása van:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
        static void feladat11(string[] args)
        {
            Console.Write("Add meg az első befogót: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a második befogót: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Az átfogó hossza: ", c);
        }
        static void feldat12(string[] args)
        {
            Console.Write("Add meg az 'a' él hosszát: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a 'b' él hosszát: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a 'c' él hosszát: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double felszin = 2 * (a * b + a * c + b * c);
            double terfogat = a * b * c;
            Console.WriteLine("A téglatest felszíne: " + felszin);
            Console.WriteLine("A téglatest térfogata: " + terfogat);
        }
        static void feladat13(string[] args)
        {
            Console.Write("Add meg a kör átmérőjét: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double r = d / 2;
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;
            Console.WriteLine("A kör kerülete: {0:F2}", kerulet);
            Console.WriteLine("A kör területe: {0:F2}", terulet);
        }
        static void feladat14(string[] args)
        {
            Console.Write("Add meg a kör sugarát: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;
            Console.WriteLine("A kör kerülete: {0:F2}", kerulet);
            Console.WriteLine("A kör területe: {0:F2}", terulet);
        }
    }
}