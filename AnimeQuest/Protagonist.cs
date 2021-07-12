using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeQuest
{
    public class Protagonist
    {
        public Protagonist()
        {
            Console.WriteLine("You awaken in a cozy bed. Your memory is hazy, but there is a word on the tip of your tongue...");
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
    
}
