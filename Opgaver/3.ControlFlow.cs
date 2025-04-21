using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Control Flow med if, else if og else, Switch og Ternary operator!");
            If1();
            If2();
            BankeBøf();
            MiniProjektQuiz();
            MiniProjektLommeregner();
        }

        public static void If1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er højere eller lavere end 18");
            // Lav opgaven herunder!
        }
        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
        }
        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
        }

        public static void BankeBøf()
        {
            Console.WriteLine("Lav et program som udskriver 'Banke' hvis tallet er deleligt med 3");
            Console.WriteLine("'Bøf' hvis tallet er deleligt med 5");
            Console.WriteLine("og 'BankeBøf' hvis tallet er deleligt med 3 og 5");
            // Lav opgaven herunder!
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar).");
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine("Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik.");
            Console.WriteLine("Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene.");
            // Lav opgaven herunder!
        }

        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
        }
    }
}