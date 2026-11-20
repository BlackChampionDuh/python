namespace cykly_ukoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ukol 1

            Console.Write("Zadej celé číslo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Generování násobilky pro číslo " + num);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + i * num );
            }
            Console.WriteLine("Generování bylo dokončeno");
            Console.WriteLine("----------------");
            //ukol 2

            Console.Write("Zadej celé číslo: ");
            long num1 = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;

            Console.WriteLine("Výpočet faktoriálu čísla " + num1);
            for (long j = 1; j <= num1; j++)
            {
               factorial *= j;
            }
            Console.WriteLine("Faktoriál: " + factorial);
            Console.WriteLine("Výpočet byl úspěšně dokončen.");
            Console.WriteLine("-----------------");
            //ukol 3


        }
    }
}
