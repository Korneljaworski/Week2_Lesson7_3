using System.Net;

public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            Dane testowe : 14 
            Rezultat w terminalu : 14 jest liczbą dodatnią
        */

        Console.WriteLine("Podaj liczbę:");
        
        int chosenNumber = Int32.Parse(Console.ReadLine());

        if (chosenNumber > 0)
        {
            Console.WriteLine($"{chosenNumber} jest liczbą dodatnią");
        }
        else if (chosenNumber == 0)
        {
            Console.WriteLine($"{chosenNumber} nie jest ani dodatnie ani ujemne");
        }
        else
        {
            Console.WriteLine($"{chosenNumber} jest liczbą ujemną");
        }
    }

}
