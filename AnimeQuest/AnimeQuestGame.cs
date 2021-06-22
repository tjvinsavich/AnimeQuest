using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows;

namespace AnimeQuest
{
    public class AnimeQuestGame
    {
        public AnimeQuestGame()
        {

        }

        public void runAQGame()
        {
            bool play = true;

            do
            {
                var protag = new Protagonist();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"Hello, {protag.Name}.");
                Thread.Sleep(2000);
                Console.WriteLine("You've been asleep for some time. But now, it seems you have returned to save this realm.");
                Thread.Sleep(3000);
                Console.WriteLine("You are our protagonist, our hero.");
                Thread.Sleep(2000);
                Console.WriteLine("Yes, it is time for your...");
                
                TitleScreen();

                play = false;

            } while (play);
        }

        public void TitleScreen()
        {
            var soundPlayer = new SoundPlayer(@"C:\Users\tjvin\Desktop\repos\AnimeQuest\themesong.wav");
            soundPlayer.Play();

            Thread.Sleep(3000);
            Console.Clear();
            //TODO REFACTOR ALL THIS CODE
            Console.WriteLine(@"            ) (      *                          (            
   (     ( /( )\ ) (  `           (             )\ )  *   )  
   )\    )\()|()/( )\))(  (     ( )\     (  (  (()/(` )  /(  
((((_)( ((_)\ /(_)|(_)()\ )\    )((_)    )\ )\  /(_))( )(_)) 
 )\ _ )\ _((_|_)) (_()((_|(_)  ((_)_  _ ((_|(_)(_)) (_(_())  
 (_)_\(_) \| |_ _||  \/  | __|  / _ \| | | | __/ __||_   _|  
  / _ \ | .` || | | |\/| | _|  | (_) | |_| | _|\__ \  | |    
 /_/ \_\|_|\_|___||_|  |_|___|  \__\_\\___/|___|___/  |_|    ", Console.ForegroundColor = ConsoleColor.Red);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(@"            ) (      *                          (            
   (     ( /( )\ ) (  `           (             )\ )  *   )  
   )\    )\()|()/( )\))(  (     ( )\     (  (  (()/(` )  /(  
((((_)( ((_)\ /(_)|(_)()\ )\    )((_)    )\ )\  /(_))( )(_)) 
 )\ _ )\ _((_|_)) (_()((_|(_)  ((_)_  _ ((_|(_)(_)) (_(_())  
 (_)_\(_) \| |_ _||  \/  | __|  / _ \| | | | __/ __||_   _|  
  / _ \ | .` || | | |\/| | _|  | (_) | |_| | _|\__ \  | |    
 /_/ \_\|_|\_|___||_|  |_|___|  \__\_\\___/|___|___/  |_|    ", Console.ForegroundColor = ConsoleColor.DarkRed);
            Thread.Sleep(1400);
            Console.Clear();
            Console.WriteLine(@"            ) (      *                          (            
   (     ( /( )\ ) (  `           (             )\ )  *   )  
   )\    )\()|()/( )\))(  (     ( )\     (  (  (()/(` )  /(  
((((_)( ((_)\ /(_)|(_)()\ )\    )((_)    )\ )\  /(_))( )(_)) 
 )\ _ )\ _((_|_)) (_()((_|(_)  ((_)_  _ ((_|(_)(_)) (_(_())  
 (_)_\(_) \| |_ _||  \/  | __|  / _ \| | | | __/ __||_   _|  
  / _ \ | .` || | | |\/| | _|  | (_) | |_| | _|\__ \  | |    
 /_/ \_\|_|\_|___||_|  |_|___|  \__\_\\___/|___|___/  |_|    ", Console.ForegroundColor = ConsoleColor.Red);
            Thread.Sleep(1100);
            Console.Clear();
            Console.WriteLine(@"            ) (      *                          (            
   (     ( /( )\ ) (  `           (             )\ )  *   )  
   )\    )\()|()/( )\))(  (     ( )\     (  (  (()/(` )  /(  
((((_)( ((_)\ /(_)|(_)()\ )\    )((_)    )\ )\  /(_))( )(_)) 
 )\ _ )\ _((_|_)) (_()((_|(_)  ((_)_  _ ((_|(_)(_)) (_(_())  
 (_)_\(_) \| |_ _||  \/  | __|  / _ \| | | | __/ __||_   _|  
  / _ \ | .` || | | |\/| | _|  | (_) | |_| | _|\__ \  | |    
 /_/ \_\|_|\_|___||_|  |_|___|  \__\_\\___/|___|___/  |_|    ", Console.ForegroundColor = ConsoleColor.DarkRed);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(@"            ) (      *                          (            
   (     ( /( )\ ) (  `           (             )\ )  *   )  
   )\    )\()|()/( )\))(  (     ( )\     (  (  (()/(` )  /(  
((((_)( ((_)\ /(_)|(_)()\ )\    )((_)    )\ )\  /(_))( )(_)) 
 )\ _ )\ _((_|_)) (_()((_|(_)  ((_)_  _ ((_|(_)(_)) (_(_())  
 (_)_\(_) \| |_ _||  \/  | __|  / _ \| | | | __/ __||_   _|  
  / _ \ | .` || | | |\/| | _|  | (_) | |_| | _|\__ \  | |    
 /_/ \_\|_|\_|___||_|  |_|___|  \__\_\\___/|___|___/  |_|    ", Console.ForegroundColor = ConsoleColor.Red);
            
            Thread.Sleep(1100);
            Console.WriteLine(".", Console.ForegroundColor = ConsoleColor.White);

            Thread.Sleep(1000);
            Console.WriteLine("..");

            Thread.Sleep(1000);

            Console.WriteLine("...");
            Thread.Sleep(250);
            Console.WriteLine("..");
            Thread.Sleep(250);
            Console.WriteLine(".");
            Thread.Sleep(250);
            Console.WriteLine("..");
            Thread.Sleep(250);
            Console.WriteLine("...");
            Thread.Sleep(100);
            Console.WriteLine("..");
            Thread.Sleep(100);
            Console.WriteLine(".");
            Thread.Sleep(100);
            Console.WriteLine("..");
            Thread.Sleep(100);
            Console.WriteLine("...");
            Thread.Sleep(100);
            Console.WriteLine("..");
            Thread.Sleep(100);
            Console.WriteLine(".");
            Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Your adventure begins now!!!");
            Thread.Sleep(3000);

            Console.WriteLine("Don't let us down!");
            Thread.Sleep(3000);

            Console.WriteLine("If you do, we'll never forgive you!");
            Thread.Sleep(3000);

            Console.Clear();

            Console.WriteLine("*THIS IS WHERE THE GAME WILL GO*");
            soundPlayer.Stop();

        }
    }

        
}
