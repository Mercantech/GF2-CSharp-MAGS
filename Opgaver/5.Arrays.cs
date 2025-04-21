using System;

namespace Opgaver
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Arrays, List og Dictionary!");

            // Opgaverne herunder går igennem ting vi skal kunne med arrays, list og dictionary
            // Da I ikke har lært omkring loops og metoder endnu, er det ikke nødvendigt at bruge dem her
            // I må dog gerne bruge loops og metoder i opgaverne herunder

            Array1();
            Array2();
            List1();
            MiniProjektKlasseliste();
            MiniProjektIndkøbsliste();
        }
        public static void List1()
        {
            Console.WriteLine("Lav et program som gemmer 5 fornavne som brugeren indtaster i en liste");

            List<string> navne = new List<string>();
        }
        public static void Array1()
        {
            Console.WriteLine("Lav et program som gemmer 5 fornavne som brugeren indtaster i et array");

            string[] navne = new string[5];

        }

        public static void Array2()
        {
            Console.WriteLine("");

            string[] navne = new string[5];
        }

        public static void MiniProjektKlasseliste()
        {
            Console.WriteLine("\nMini-projekt: Klasseliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster navnene på alle elever i en klasse (fx 5 navne).");
            Console.WriteLine("Gem navnene i en liste og udskriv hele klasselisten i konsollen.");
            // Lav opgaven herunder!
        }

        public static void MiniProjektIndkøbsliste()
        {
            Console.WriteLine("\nMini-projekt: Indkøbsliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster navnet på tre ting, de skal købe i supermarkedet.");
            Console.WriteLine("Gem tingene i en liste og udskriv en indkøbsliste til brugeren.");
            // Lav opgaven herunder!
        }
    }
}