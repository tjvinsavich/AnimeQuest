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

            var protag = new Protagonist();
            //Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine($"Hello, {protag.Name}.");
            //Thread.Sleep(2000);
            //Console.WriteLine("You've been asleep for some time. But now, it seems you have returned to save this realm.");
            //Thread.Sleep(3000);
            //Console.WriteLine("You are our protagonist, our hero.");
            //Thread.Sleep(2000);
            //Console.WriteLine("Yes, it is time for your...");

            //TitleScreen();

            do
            {
                //SEQUENCE 1
                Console.WriteLine("You are in the same room as you were when you first awoke. It is the quintessential cozy cottage. \n" +
                    "An old man sits over on a stool staring at you with wild eyes: \n" +
                    "\"So you're finally awake, eh? How about you give this old man a back rub before you get on your way?\"\n");

                Console.WriteLine("1. It's important to respect your elders! Oblige the old gent.");
                Console.WriteLine("2. I'm pretty sure some narrator just told me I have a quest to do? Rush out the door.");
                Console.WriteLine("3. I'll teach this elder some manners. It's ME who gets the back rub today!");

                var input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("You walk over to the old man, and he beams up at you excitedly. \n" +
                        "\"Oh, thank you. Thank you! My back has been killing me ever since my grandson left. \n" +
                        "He would do all the lifting and carrying for me, but I suppose war is war and we have no control over that, hmm?\"\n" +
                        "You give the old man an expertful back rub. His posture eases up and he rises from the stool.\n" +
                        "\"Well, I wish I had something to offer you, but unfortunately, I'm just a simple hermit, you see?\"\n" +
                        "He guffaws merrily and retires into what you can only assume are his own quarters. You steel yourself, and exit the cottage.");

                    protag.Score += 25;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You rush past the old man to the door and he shouts to you as you quickly flee the cottage: \n" +
                        "\"How could you abandon this old timer in his time of need?! How could you!? How could youuuuu...\"");

                    //protag.Score unchanged
                }
                else if (input == 3)
                {
                    Console.WriteLine("You scowl at the old man and stomp over to him. You shove him off his stool, and plant yourself there. \n" +
                        "He looks up at you and frowns: \n" +
                        "\"Well, that's quite rude of you, young one. Making an old man like me take care of a spring chicken like you.\"\n" +
                        "He gives you a really bad back rub. It's probably the worst one you've ever had. Not like you've had A LOT in your life, but wow.\n" +
                        "\"Okay, that's enough freeloading, hit the road, Jack!\" He shoves you out the door."
                        );

                    protag.Score -= 25;
                }

                //SEQUENCE 2

                Console.WriteLine("\nYou walk along the road outside the cottage for some time. Suddenly, you hear a dog barking in the distance. Soon after, you come upon " +
                    "a feisty dog barking up at a helpless cat in a tree.\n");
                Console.WriteLine("1. With the power of musical theatre, anything is possible! Teach the unlikely duo a song and dance routine.");
                Console.WriteLine("2. \"Tail\" as old as time. Hahaha! ... Wait, there's no time for this! Continue down the road!");
                Console.WriteLine("3. Who likes animals anyway? Boo both the cat and the dog.");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("With a deep breath and a forced smile, you trot over to the tree. The dog and cat stare at you expectantly yet confused.\n" +
                        "You begin to sing some sort of nonsense about \"follow me, if you'd like to be, just as happy as this tree\" -- you throw in a little" +
                        " tap dance for some flare.\nThis really shouldn't be working, but it is. The dog and cat both become anthropomorphized, and together, " +
                        "you make a perfect trio of harmony and jazzy dance steps. \nAs the cat and dog prepare for the big finale, you wave goodbye and give them " +
                        "a \"my work here is done\" wink. The two wave back to you and continue twirling happily together in each other's arms (legs?) as you solo dance " +
                        "forward down the path.");
                    protag.Score += 25;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You pay no heed to the imminent danger the cat may be in. You avert your gaze, and increase your pace as you hurriedly speedwalk" +
                        "down the path.");
                    //protag.Score unchanged
                }
                else if (input == 3)
                {
                    //CONTINUE HERE
                    protag.Score -= 25;
                }



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
            Console.WriteLine(".", Console.ForegroundColor = ConsoleColor.Yellow);

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

            Console.WriteLine("Your adventure begins now!!!", Console.ForegroundColor = ConsoleColor.White);
            Thread.Sleep(3000);

            Console.WriteLine("Don't let us down!");
            Thread.Sleep(3000);

            Console.WriteLine("If you do, we'll never forgive you!");
            Thread.Sleep(3000);

            Console.Clear();

            
            soundPlayer.Stop();

        }
    }

        
}
