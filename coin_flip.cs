using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("heads or tails ");
        string player = Console.ReadLine();

        string coin = rnd.Next(2) == 0 ? "heads" : "tails";

        Console.WriteLine("coin " + coin);

        if (player == coin)
            Console.WriteLine("win");
        else
            Console.WriteLine("lose");
    }
}
