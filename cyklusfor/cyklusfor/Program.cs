namespace cyklusfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Aktuální číslo: " + i);
            }

            Console.WriteLine("----------------------");
            // pomoci cyklu for vypsat cislo od 10 do 0

            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine("Aktuální číslo: " + i);
            }

            Console.WriteLine("----------------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
