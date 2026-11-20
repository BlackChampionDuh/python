namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            switch(x)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 10:
                    Console.WriteLine("Case 10");
                    break;
                default:
                    Console.WriteLine("Neočekávaný vstup!");
                    break;
            }

            char key = 'b';

            switch (key)
            {
                case 'a':
                    int vysledek = 2 * 4;
                    Console.WriteLine("Výsledek je: " + vysledek);
                    break;
                case 'b':
                    int vysledek1 = 2 * 75;
                    Console.WriteLine("Výsledek je: " + vysledek1);
                    break;

            }

        }
    }
}
