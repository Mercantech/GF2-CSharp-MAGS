
namespace Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, GF2!");

            //Kør Variabler Opgaverne!
            Variabler.Run();
            Indputs.Run();
            ControlFlow.Run();
            Arrays.Run();
            Methods.Run();
            Classes.Run();
            Loops.Run();

            // Kør Sten, Saks, Papir projektet!
            RockPaperScissors.Run();
        }


    }
}
