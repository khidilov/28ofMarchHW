using _28ofMarchHW.Models;
using System;

namespace _28ofMarchHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer sn = new Singer("Alec", "Benjamin", 27);
            Song sg = new Song("Shadow of Mine", "POP", "Alec Benjamin");
            sg.AddRating(5);
            sg.AddRating(6);
            sg.AddRating(7);

            Console.WriteLine(sg.GetAverageRating()); // averege must be 6 but program returns 5



        }
    }
}
