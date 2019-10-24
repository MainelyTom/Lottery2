using System;
using static System.Console;
class Lottery
{
    static void Main()
    {   int rn1, rn2, rn3, gn1, gn2, gn3, win = 0;
        string gn1s, gn2s, gn3s;
        double winnings = 0;
        Random ranNG = new Random();
        rn1 = ranNG.Next(1, 5);  rn2 = ranNG.Next(1, 5);  rn3 = ranNG.Next(1, 5);

        Write("Input your first number:  ");  gn1 = Convert.ToInt32(ReadLine());
        Write("Input your second number: ");  gn2 = Convert.ToInt32(ReadLine());
        Write("Input your third number:  ");  gn3 = Convert.ToInt32(ReadLine());

        if (gn1 == rn1 || gn1 == rn2 || gn1 == rn3)     win++;
        if (gn2 == rn1 || gn2 == rn2 || gn2 == rn3)     win++;
        if (gn3 == rn1 || gn3 == rn2 || gn3 == rn3)     win++;
        if (gn1 == rn1 && gn2 == rn2 && gn3 == rn3)     win=4;

        WriteLine("How many guesses right? " + win);
        if (win == 0)     winnings = 0;
        if (win == 1)     winnings = 10;
        if (win == 2)     winnings = 100;
        if (win == 3)     winnings = 1000;
        if (win == 4)     winnings = 10000;
        
        if (win > 0)      WriteLine("You Won $" + winnings.ToString() + " congratulations!");
        else              WriteLine("you were not a winner");
    }
}