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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Hello, {protag.Name}.");
            Thread.Sleep(2000);
            Console.WriteLine("You've been asleep for some time. But now, it seems you have returned to save this realm.");
            Thread.Sleep(3000);
            Console.WriteLine("You are our protagonist, our hero.");
            Thread.Sleep(2000);
            Console.WriteLine("Yes, it is time for your...");

            TitleScreen();

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

                Console.Clear();

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

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You walk along the road outside the cottage for some time. Suddenly, you hear a dog barking in the distance. Soon after, you come upon " +
                    "a feisty dog barking up at a helpless cat in a tree.\n");
                Console.WriteLine("1. With the power of musical theatre, anything is possible! Teach the unlikely duo a song and dance routine.");
                Console.WriteLine("2. \"Tail\" as old as time. Hahaha! ... Wait, there's no time for this! Continue down the road!");
                Console.WriteLine("3. Who likes animals anyway? Boo both the cat and the dog.");

                input = int.Parse(Console.ReadLine());

                Console.Clear();

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
                    Console.WriteLine("You pay no heed to the imminent danger the cat may be in. You avert your gaze, and increase your pace as you hurriedly speedwalk " +
                        "down the path.");
                    //protag.Score unchanged
                }
                else if (input == 3)
                {
                    Console.WriteLine("With a wicked smile, you cup your hands around the sides of your face and begin to boo the cat and dog from afar. \"BOOOOOOO!\" you shout " +
                        "over and over. The dog and cat look at you in absolute horror and embarrassment. Never before had they both felt such shame. They both run off into different " +
                        "directions in the woods, crying the whole way. \nThat was really mean. But I guess you just don't care do you? You continue down the path.");
                    protag.Score -= 25;
                }

                //SEQUENCE 3

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("You now find yourself deep in the woods. The woods are not scary, but the pretty kind with light dancing down through the leaves. You see a young boy " +
                    "training with his sword in a clearing. He's not very good. He waves it around more like a feather duster than a warrior would a blade. He seems distraught.\n");

                Console.WriteLine("1. We were all there once. Offer him support and motivation. Never give up!");
                Console.WriteLine("2. Children are a waste of time, and are certainly NOT the future. Continue on, we must!");
                Console.WriteLine("3. Ridicule him and tell him to give up. There's no sense trying at something you're not a natural at!");

                input = int.Parse(Console.ReadLine());

                Console.Clear();

                if (input == 1)
                {
                    Console.WriteLine("The kid collapses in exhaustion and his sword falls down beside him in the dirt. You approach and place your hand on his shoulder. The child looks up at you. " +
                        "\"You know, practice is important, but so is rest. You've clearly been at this all day. You'll get there soon, but not if you accidentally injure yourself while you're exhausted.\" " +
                        "He begins to cry and tells you inbetween sobs: \"But my brother's gone and I have to be strong for the rest of us.\" " +
                        "\"One day you will be a great swordsman, I see it in you. But that greatness comes from your own character, not your reckless resolve. Time takes time.\"" +
                        "The child bounces back to his feet, fists clenched. \"Yeah! I can do it!\" -- he hurriedly picks up his sword and runs off into the woods. With a smile, you turn and continue down the path.");

                    protag.Score += 25;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You roll your eyes at the mediocre kid, but don't let him distract you for too long! We journey on!");
                    //protag.Score unchanged
                }
                else if (input == 3)
                {
                    Console.WriteLine("You rush up and sweep the child's legs. He goes airborne and his swords goes flying. You catch it expertly with a flip and land on a stump. The child lands on the ground " +
                        "with a hard thump. He rubs his head and looks up at you. You point the sword at him: \"So it's not just your attacks that are pathetic, but your defenses and reflexes too!\" You " +
                        "laugh heartily to yourself. Tears form in the child's eyes and he softly begins to plead: \"That sword...please, it was my bro-\" Before you let him finish, you chuck it full force into " +
                        "the woods. \"Go and get it! Maybe you're better at running!\" The child dashes off into the woods in the direction you sent his sword. Seriously? That was unbelievably cruel. Why are you " +
                        "picking these options? Is this funny to you? Is this- *sigh* whatever. You continue down the path.");
                    protag.Score -= 25;
                }

                //SEQUENCE 4

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Finally, this long path leads you into a village, but this village is under attack! Villagers run around helplessly using makeshift weapons to defend themselves. The onslaught of " +
                    "armored men go through the village burning down huts and antagonizing the villagers. The smell of war looms thickly. Now that you're here, you see there's no more path to follow. One way or another, " +
                    "it seems your quest will end here.\n");

                Console.WriteLine("1. Defend the village from the merciless siege!");
                Console.WriteLine("2. No time for this! Ignore the violence and continue the journey!");
                Console.WriteLine("3. Join in the mayhem! Who doesn't love a good excuse for horrid behavior that can't be tracked back to you?");

                input = int.Parse(Console.ReadLine());

                Console.Clear();

                if (input == 1)
                {
                    Console.WriteLine("You rush around the village putting out fires with water buckets, saving villagers stuck under wreckage, and drawing the invaders' attention to yourself to allow any straggling villagers " +
                        "to flee.");
                    protag.Score += 25;
                }
                else if (input == 2)
                {
                    Console.WriteLine("Look, I just told you there's nowhere else to go, no more path to follow. The quest ends here!");
                    //protag.Score unchanged
                }
                else if (input == 3)
                {
                    Console.WriteLine("No. That's enough. I'm not narrating that for you. You can fill in the blanks yourself. You are truly wicked.");
                    protag.Score -= 25;
                }

                //FINAL SEQUENCE

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("The sky darkens and turns blood red, the shrieks of demons echo about the remains of the village, and the air around you feels colder than death. A knight in purple armor " +
                    "emerges from a portal of shadows directly in front of you, but this one is different from the rest. They are double the size of a normal person and possess an aura that immediately makes you " +
                    "feel weak and helpless. \n They remove their helmet and reveal themselves to you. Their face is familiar to you, because... it's you. \nA voice echoes out to you:");

                Console.ReadLine();

                //GOOD ENDING -- LIFE IS BUT A DREAM
                if (protag.Score == 100)
                {
                    Console.WriteLine("\"What does being kind for kindness sake afford you? Is it some sort of self-satisfaction? Are you patting yourself on the back? Well, enough. I will end you.\"");
                    Console.ReadLine();
                    Console.WriteLine("The purple knight, who is actually you, but is also the evil villain of this world or something, lunges at you! You backstep out of the attack and get into a battle-ready stance, when you " +
                        "realize: you never got any cool gear or items for combat! Some RPG this is!");
                    Console.ReadLine();
                    Console.WriteLine("The purple knight pulls its sword back for another attack, and just as you think all hope might be lost, a quick " +
                        "form flashes past you, colliding with the purple knight, staggering it. The form flips off the knight and lands off to your side, very stylishly: \"Hey there, whipper-snapper! I had a feeling " +
                        "a good kid like you might get into some trouble, and sure enough, the sky got all scary so I rushed here as soon as I could! My back's feeling better than it has in years thanks to you!\" " +
                        "With his last sentence, the old man from before roundhouse kicks the purple knight sending it prone.");
                    Console.ReadLine();
                    Console.WriteLine("You begin to hear the sound of light tapping, like rain on a window, but NO! It's the cat " +
                        "and dog from earlier, performing an even better tap dance than before ontop of the purple knight. A tear forms in your eye. They've been practicing!");
                    Console.ReadLine();
                    Console.WriteLine("The purple knight knocks them off, and charges you again, with its most " +
                        "powerful sword slash attack! Suddenly, a legendary swordsman materializes between you and shouts something like \"DANCE OF 1001 SWORDS: METALBREAKING!!!\" and in a really colorful and beautifully " +
                        "animated flurry, rips through the armor of the purple knight, and leaves them defenseless and back on the ground. This swordsman doesn't look all that familiar to you, but you hear a familiar voice " +
                        "yell up: \"You did it!\" and you see the little boy from the clearing beaming up proudly. The swordsman turns to you: \"My little brother told me about you. I went off without warning awhile ago to go " +
                        "train in the mountains, but when I saw my village was under attack, I quickly raced down to help. Thanks for being there for him when I couldn't.\"");
                    Console.ReadLine();
                    Console.WriteLine("You're completely overwhelmed at this point, and right " +
                        "as you're taking this all in, the purple knight (or purple armorless knight) grapples you from behind. \"If I'm going down, then we're going down together!\" The evil you combusts into a brilliant purple " +
                        "flame. Your allies, try as they might, can't seem to break through its otherworldly energy. This looks like the end. Suddenly, a random villager throws a bucket of water on you both and the evil you is reduced " +
                        "to ash that dissipates into the wind. \"Remember 5 minutes ago when you put out fires around the village and helped us and stuff and yeah so this one is for that yeah.\" The random villager wanders off, and as " +
                        "you look around the village after them, you realize that the villagers had taken care of the rest of the battalion. The village is safe, and it seems like peace in the realm has finally been restored.");
                    Console.ReadLine();
                    Console.WriteLine("Your material form begins to fade. All your new friends stare at you fondly with a touch of sadness. \"Does this mean you have to go?\"");

                    play = false;
                }
                else if (protag.Score < 100 && protag.Score > 0)
                {
                    Console.WriteLine("\"You're a bit of an anomaly aren't you? A curious case. I didn't expect someone to be so wishy-washy with their benevolence. Or maybe you're just trying to game the system " +
                        "and figure out how things work here. I will save you the effort. This realm works in extremes. It rewards the virtuous and condemns the vicious. Now, you can be whatever you choose to be, but " +
                        "here is a true binary reality. Next time: Venture towards 1 or 0. You may not learn much, but you'll get a more satisfying result, to be sure.\"");
                }
                else if (protag.Score == 0)
                {
                    Console.WriteLine("\"You were in such a rush to begin your adventure that you didn't realize the real one was right in front of you. Remaining neutral may be the path of least resistance, " +
                        "but there is no fate worse than those who become bystanders to their own lives. Next time: Take a stand, make a decision. For better, or worse.\"");
                }
                else if (protag.Score < 0 && protag.Score > -100)
                {
                    Console.WriteLine("\"Your mercilessness is so very close, but not quite there. I can afford you another chance. I shall rewind through the strands of time, and bring you back to your beginning. " +
                        "Be sure to exact your cruelty in this iteration.\"");
                }
                //BAD ENDING -- UNENDING NIGHTMARE
                else if (protag.Score == -100)
                {
                    Console.WriteLine("\"You have been chosen. It is your destiny to be the doombringer of this realm. Your autonomy will be stripped, and I will control what remains of you. Thank you for " +
                        "preparing this vessel so expertly for me. Goodbye.\"");

                    play = false;
                }

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.Clear();


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
