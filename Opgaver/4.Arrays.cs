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


    }
}