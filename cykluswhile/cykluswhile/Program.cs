namespace cykluswhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cyklus while()
            /*          
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("----");
            //cyklus do while()
            i = 0;
            do
            {
                Console.WriteLine();
                i++;
            }
            while (i < 10);
            */

            Random rand = new Random();

            int tip = rand.Next(1, 37);

            int tipUzivatele = 0;
            int pocetPokusu = 0;

            while (tipUzivatele != tip)
            {
                Console.WriteLine("Zadej svůj tip: ");
                int vstup = Convert.ToInt32(Console.ReadLine());

                if (vstup == tip)
                {
                    Console.WriteLine("Uhodl jsi číslo!");
                }
                else if (vstup > tip)
                {
                    Console.WriteLine("Hádané číslo je menší jak tvůj tip");
                }
                else if (vstup < tip)
                {
                    Console.WriteLine("Hádané číslo je větší jak tvůj tip");
                }
            }
        }
    }
}
