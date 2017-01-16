using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ShortStoryConsoleGame
{
    class Program
    {
        /// <summary>
        /// Entry Point for ShortStoryConsole Game code
        /// This will initialise and use the constructers of all the classes in Chapter Files --->
        /// Bailey,Matt,Alejandro,Erica,Fransisco, Iron Yard Backend Fall 2016
        /// First Project!!!!!
        /// 11/2-11/4 
        /// </summary>

        ///<summary>
        ///Entry point for all the code will run the methods in sequence from one to five.
        /// </summary>
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        
        static void Main(string[] args)
        {
            ///<sumamry>
            ///straight through story
            /// </sumamry>

            synth.SetOutputToDefaultAudioDevice();

            chapterOneGame();
            Console.ReadKey();

            
            chapterTwoGame();
            Console.ReadKey();

            
            chapterThreeGame();
            Console.ReadKey();

            chapterFourGame();
            Console.ReadKey();

            chapterFiveGame();

            ///<summary>
            ///chapter chooser walk through
            /// </summary>
            //bookCoverASCII();
            //speechEntry();
            //firstOffASCII();
            //chapterChooser();
            
            
        }
        /// <summary>
        /// these series of chapterOne-FiveGames take the constructors and pass values and
        /// then start the code to the corresponding chapter file.
        /// </summary>
        static void chapterChooser()
        {
            Console.WriteLine("Please choose the chapter you wish to play again(1-5) or type END to end the program.");
            string chapterChoice = Console.ReadLine();
            if (chapterChoice == "1")
            {
                chapterOneGame();
                Console.Clear();
                chapterChooser();
            }
            else if (chapterChoice == "2")
            {
                chapterTwoGame();
                Console.Clear();
                chapterChooser();
            }
            else if (chapterChoice == "3")
            {
                
                chapterThreeGame();
                Console.Clear();
                chapterChooser();
            }
            else if (chapterChoice == "4")
            {
                chapterFourGame();
                Console.Clear();
                chapterChooser();
            }
            else if (chapterChoice == "5")
            {
                chapterFiveGame();
                Console.Clear();
                chapterChooser();
            }
            else if (chapterChoice == "end")
            {
                Console.Clear();
                closingCredits();
            }

            else
            {
                Console.WriteLine("That is not a valid choice try again.");
                chapterChooser();
            }
        }
        static void chapterOneGame()
        {
            //matt
            bookCoverASCII();
            speechEntry();
            firstOffASCII();
            Console.Clear();
            chapterOneASCII();
            

            synth.Speak("Agent goalfinger and his pet toucan are taking on the forces of evil in chapter one");
            
            int pageNo = 1;
            Chapter1Class cOne = new Chapter1Class(pageNo);
        }
        static void chapterTwoGame()
        {
            //alejandro
            Console.Clear();
            chapterTwoASCII();
            synth.Speak("we find Agent goalfinger racing through hairpin turns will you take the wheel?");
            
            string artificialInt = "";
            int pageNumber = 1;
            chapterTwo cTwo = new chapterTwo(artificialInt, pageNumber);
            
            
        }
        static void chapterThreeGame()
        {
            //fransisco
            Console.Clear();
            chapterThreeASCII();
            synth.Speak("Now agent goalfinger travels to Dubai, will he survive or be defeated");
            string baseCharacter = "GoalFinger";
            ChapterThree chapter = new ChapterThree(baseCharacter);

        }
        static void chapterFourGame()
        {
            //erica
            Console.Clear();
            chapterFourASCII();
            synth.Speak("Our new enemy the green eyed bandit is trying to kill the prime minister will agent goal finger be able to stop him");

            int pageNo1 = 61;
            ChapterFour chapter = new ChapterFour(pageNo1);
        }
        static void chapterFiveGame()
        {
            //bailey
            Console.Clear();
            chapterFiveASCII();
            synth.Speak("Agent goalfinger and his sidekick are trapped in between a laser and a hard place, how will our hero navigate this sticky situation");

            int startPage = 81;
            chapterFive chapter = new chapterFive(startPage);

            Console.Clear();

            chapterChooser();

            

            
        }
        /// <summary>
        /// end chapter constructors methods
        /// </summary>
        ///<summary>
        ///this next method is the Text to speech entry.
        /// 
        /// </summary>

        static void closingCredits()
        {
            Console.Clear();
            bookCoverASCII();
            endOfBookFinaleASCII();

            synth.Speak("Hello adventurer its me jarvis again, I hope you were succesful in your efforts, my purpose is now complete I will now shut down, goodbye forever");
            Console.WriteLine("This game is the culmonation of 3 days effort by the Iron Yard backend Fall 2016 class");
            Console.WriteLine("Bailey Strum, Fransisco Duran, Matt Spezia, Alejandra Castillo, and Erica Bowen");
            Console.WriteLine("Hope you enjoyed our game and if your reading this turn around.");
            Console.WriteLine("Thank you for playing hope you enjoyed press any key to exit.");
            Console.ReadKey();

            Environment.Exit(0);
        }
        static void speechEntry()
        {
            Console.WriteLine("Press the space bar to begin...");
            Console.ReadKey();
            Console.WriteLine(@"
          ,--.    ,--.
            ((O ))--((O ))
        ,'_`--'____`--'_`.
        _:  ____________  :_
        | | ||::::::::::|| | |
        | | ||::::::::::|| | |
        | | ||::::::::::|| | |
        |_| |/__________\| |_|
        |________________|
    __..-'            `-..__
    .-| : .----------------. : |-.
,\ || | |\______________/| | || /.
/`.\:| | ||  __  __  __  || | |;/,'\
:`-._\;.| || '--''--''--' || |,:/_.-':
|    :  | || .----------. || |  :    |
|    |  | || '----007---' || |  |    |
|    |  | ||   _   _   _  || |  |    |
:,--.;  | ||  (_) (_) (_) || |  :,--.;
(`-'|)  | ||______________|| |  (|`-')
`--'   | |/______________\| |   `--'
        |____________________|
        `.________________,'
        (_______)(_______)
        (_______)(_______)
        (_______)(_______)
        (_______)(_______)
        |        ||        |
        '--------''--------'
");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Hello and welcome to the world of agent goalfinger");
            synth.Speak("I am Agent Goalfingers robot assistant jarvis and I will help you begin your journey of action and adventure.");
            synth.Speak("But first let me ask what is your name");

Console.Write("Tell Jarvis Your Name To Begin...");

            string input = Console.ReadLine();

            synth.Speak("Hello" + input);
            synth.Speak("Agent Goalfinger is a choose your own adventure story written and programmed by the Iron Yard Backend 2016 Fall class.");
            synth.Speak("Once I finish talking I will display the instructions below, it is highly suggested that you read and follow them carefully!");
            synth.Speak("Enjoy your journey with agent goalfinger, but be warned, its a dangerous world out there");
        }
        /// <summary>
        /// these next methods are used to draw the ascII pictures 
        ///</summary>
        static void firstOffASCII()
        {
            Console.WriteLine(@"
||||||||||||||||||||||||||||||||||||||||||INSTRUCTIONS|||||||||||||||||||||||||||||||||||||||||||||||||||||
Welcome player, you are now entering the world of Agent Goalfinger!
Agent Goalfinger is a text based choose your own adventure story with more twists and turns then a mountain road.
This game is layed out by 5 chapters and you will follow them 1-5.
Agent Goalfinger takes place in an alternate reality where simulations can be percieved as real life.
In each of the five simulations you will follow Agent Goalfinger through 5 seperate episodes and in each
episode you will adopt a new persona for your adventures.
You can either die or succeed in your missions with Agent Goalfinger, good luck and try your best to succeed!
Press the SPACE KEY to continue to begin your journey at Chapter 1.
                ");
            Console.ReadKey();
        }
        static void bookCoverASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                                                                                                                                              XX
XX        ▄▄▄        ▄████ ▓█████  ███▄    █ ▄▄▄█████▓     ▄████  ▒█████   ▄▄▄       ██▓      █████▒██▓ ███▄    █   ▄████ ▓█████  ██▀███        XX
XX       ▒████▄     ██▒ ▀█▒▓█   ▀  ██ ▀█   █ ▓  ██▒ ▓▒    ██▒ ▀█▒▒██▒  ██▒▒████▄    ▓██▒    ▓██   ▒▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▓██ ▒ ██▒      XX
XX       ▒██  ▀█▄  ▒██░▄▄▄░▒███   ▓██  ▀█ ██▒▒ ▓██░ ▒░   ▒██░▄▄▄░▒██░  ██▒▒██  ▀█▄  ▒██░    ▒████ ░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▓██ ░▄█ ▒      XX
XX       ░██▄▄▄▄██ ░▓█  ██▓▒▓█  ▄ ▓██▒  ▐▌██▒░ ▓██▓ ░    ░▓█  ██▓▒██   ██░░██▄▄▄▄██ ▒██░    ░▓█▒  ░░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██▀▀█▄        XX
XX        ▓█   ▓██▒░▒▓███▀▒░▒████▒▒██░   ▓██░  ▒██▒ ░    ░▒▓███▀▒░ ████▓▒░ ▓█   ▓██▒░██████▒░▒█░   ░██░▒██░   ▓██░░▒▓███▀▒░▒████▒░██▓ ▒██▒      XX
XX        ▒▒   ▓▒█░ ░▒   ▒ ░░ ▒░ ░░ ▒░   ▒ ▒   ▒ ░░       ░▒   ▒ ░ ▒░▒░▒░  ▒▒   ▓▒█░░ ▒░▓  ░ ▒ ░   ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░      XX
XX         ▒   ▒▒ ░  ░   ░  ░ ░  ░░ ░░   ░ ▒░    ░         ░   ░   ░ ▒ ▒░   ▒   ▒▒ ░░ ░ ▒  ░ ░      ▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░▒ ░ ▒░      XX
XX         ░   ▒   ░ ░   ░    ░      ░   ░ ░   ░         ░ ░   ░ ░ ░ ░ ▒    ░   ▒     ░ ░    ░ ░    ▒ ░   ░   ░ ░ ░ ░   ░    ░     ░░   ░       XX
XX             ░  ░      ░    ░  ░         ░                   ░     ░ ░        ░  ░    ░  ░        ░           ░       ░    ░  ░   ░           XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
+------------------------------------------------------------------------------------------------------------------------------------------------+
|    \__ ____/(_ _____)(_ ___  )( (    /|  |\  ___/|(_ _____)(_ _____)(  __ _\___(  ____\_(_ _____)(_ ____ \| \ ___/\(_ ____ \( ( ___/|(  __  \  |
|       ) (   | (    )|| (   ) ||  \  ( |  ( \   / )| (   ) || (    )|| (  \  )  | (   ) )| (   ) || (    \/|  \  / /| (    \/|  \  ( +| (  \  ) |
|       | |   | (____)|+ |   | ||   \ | |   \ (_) / | (___) || (____)|+ |   ) |  | (__/ / | (___) || |      |  (_/ / | (__    |   \ | || |   ) | |
|       | |   |     __)| |   | || (\ \) |    \   /  |  ___  ||     __)| |   | |  |  __ (  |  ___  || |      |   _ (  |  __)   | (\ \) || |   | | |
|       | |   | (\ (   | |   | || | \   |     ) (   | (   ) || (\ (   | |   ) |  | (  \ \ | (   ) || |      |  ( \ \ | (      | | \   || |   ) | |
|    ___) (___| ) \ \__| (___) |+ )  \  |     | |   | )   ( || ) \ \__| (__/  )  | )___) )| )   ( +| (____/\|  /  \ \| (____/\| )  \  || (__/  ) |
|    \_______/|/   \__/(_______)|/    )_)     \_/   |/     \||/   \__/(______/   |/ \___/ |/     \|(_______/|_/    \/(_______/|/    )_)(______/  |
+------------------------------------------------------------------------------------------------------------------------------------------------+

              ");
        }
        static void chapterOneASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                       ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███      ▒█████   ███▄    █ ▓█████                              XX
XX                      ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▒██▒  ██▒ ██ ▀█   █ ▓█   ▀                              XX
XX                      ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒██░  ██▒▓██  ▀█ ██▒▒███                                XX
XX                      ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ▒██   ██░▓██▒  ▐▌██▒▒▓█  ▄                              XX
XX                      ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒   ░ ████▓▒░▒██░   ▓██░░▒████▒                             XX
XX                      ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒░ ░                             XX
XX                        ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ░  ░                             XX
XX                      ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░    ░ ░ ░ ▒     ░   ░ ░    ░                                XX
XX                      ░ ░       ░  ░  ░      ░  ░                     ░  ░   ░            ░ ░           ░    ░  ░                             XX
XX                      ░                                                                                                                       XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                        ");
        }
        static void chapterTwoASCII()
        {
             Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                          ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███     ▄▄▄█████▓ █     █░ ▒█████                            XX
XX                         ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▓  ██▒ ▓▒▓█░ █ ░█░▒██▒  ██▒                          XX
XX                         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒ ▓██░ ▒░▒█░ █ ░█ ▒██░  ██▒                          XX
XX                         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ░ ▓██▓ ░ ░█░ █ ░█ ▒██   ██░                          XX
XX                         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒     ▒██▒ ░ ░░██▒██▓ ░ ████▓▒░                          XX
XX                         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░     ▒ ░░   ░ ▓░▒ ▒  ░ ▒░▒░▒░                           XX
XX                           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░       ░      ▒ ░ ░    ░ ▒ ▒░                           XX
XX                         ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░      ░        ░   ░  ░ ░ ░ ▒                            XX
XX                         ░ ░       ░  ░  ░      ░  ░                     ░  ░   ░                     ░        ░ ░                            XX
XX                         ░                                                                                                                    XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                        ");
        }
        static void chapterThreeASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                      ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███     ▄▄▄█████▓ ██░ ██  ██▀███  ▓█████ ▓█████                  XX
XX                     ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▓  ██▒ ▓▒▓██░ ██▒▓██ ▒ ██▒▓█   ▀ ▓█   ▀                  XX
XX                     ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒ ▓██░ ▒░▒██▀▀██░▓██ ░▄█ ▒▒███   ▒███                    XX
XX                     ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ░ ▓██▓ ░ ░▓█ ░██ ▒██▀▀█▄  ▒▓█  ▄ ▒▓█  ▄                  XX
XX                     ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒     ▒██▒ ░ ░▓█▒░██▓░██▓ ▒██▒░▒████▒░▒████▒                 XX
XX                     ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░     ▒ ░░    ▒ ░░▒░▒░ ▒▓ ░▒▓░░░ ▒░ ░░░ ▒░ ░                 XX
XX                       ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░       ░     ▒ ░▒░ ░  ░▒ ░ ▒░ ░ ░  ░ ░ ░  ░                 XX
XX                     ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░      ░       ░  ░░ ░  ░░   ░    ░      ░                    XX
XX                     ░ ░       ░  ░  ░      ░  ░                     ░  ░   ░                  ░  ░  ░   ░        ░  ░   ░  ░                 XX
XX                     ░                                                                                                                        XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                    ");
        }
        static void chapterFourASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                       ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███       █████▒▒█████   █    ██  ██▀███                        XX
XX                      ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▓██   ▒▒██▒  ██▒ ██  ▓██▒▓██ ▒ ██▒                      XX
XX                      ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒████ ░▒██░  ██▒▓██  ▒██░▓██ ░▄█ ▒                      XX
XX                      ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ░▓█▒  ░▒██   ██░▓▓█  ░██░▒██▀▀█▄                        XX
XX                      ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒   ░▒█░   ░ ████▓▒░▒▒█████▓ ░██▓ ▒██▒                      XX
XX                      ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░    ▒ ░   ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░                      XX
XX                        ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░    ░       ░ ▒ ▒░ ░░▒░ ░ ░   ░▒ ░ ▒░                      XX
XX                      ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░     ░ ░   ░ ░ ░ ▒   ░░░ ░ ░   ░░   ░                       XX
XX                      ░ ░       ░  ░  ░      ░  ░                     ░  ░   ░                   ░ ░     ░        ░                           XX
XX                      ░                                                                                                                       XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                    ");
        }
        static void chapterFiveASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XX                                                                                                                                              XX
XX                          ▄████▄   ██░ ██  ▄▄▄       ██▓███  ▄▄▄█████▓▓█████  ██▀███       █████▒██▓ ██▒   █▓▓█████                           XX
XX                         ▒██▀ ▀█  ▓██░ ██▒▒████▄    ▓██░  ██▒▓  ██▒ ▓▒▓█   ▀ ▓██ ▒ ██▒   ▓██   ▒▓██▒▓██░   █▒▓█   ▀                           XX
XX                         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██░ ██▓▒▒ ▓██░ ▒░▒███   ▓██ ░▄█ ▒   ▒████ ░▒██▒ ▓██  █▒░▒███                             XX
XX                         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒▓█  ▄ ▒██▀▀█▄     ░▓█▒  ░░██░  ▒██ █░░▒▓█  ▄                           XX
XX                         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██▒ ░  ░  ▒██▒ ░ ░▒████▒░██▓ ▒██▒   ░▒█░   ░██░   ▒▀█░  ░▒████▒                          XX
XX                         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░▒▓▒░ ░  ░  ▒ ░░   ░░ ▒░ ░░ ▒▓ ░▒▓░    ▒ ░   ░▓     ░ ▐░  ░░ ▒░ ░                          XX
XX                           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░▒ ░         ░     ░ ░  ░  ░▒ ░ ▒░    ░      ▒ ░   ░ ░░   ░ ░  ░                          XX
XX                         ░         ░  ░░ ░  ░   ▒   ░░         ░         ░     ░░   ░     ░ ░    ▒ ░     ░░     ░                             XX
XX                         ░ ░       ░  ░  ░      ░  ░                     ░  ░   ░                ░        ░     ░  ░                          XX
XX                         ░                                                                               ░                                    XX
XX                                                                                                                                              XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                ");
        }
        static void endOfBookFinaleASCII()
        {
            Console.WriteLine(@"
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXX_XXXXXXXXXXXXXXXXXXX_XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX_XXXXXXXXXXXXXXXXXXX_XXXXXXXXXXXXXXXXX
XX        _( )                 ( )_                                                                        _( )                 ( )_            XX
XX       (_, |      __ __      | ,_)         ▄▄▄█████▓ ██░ ██ ▓█████    ▓█████  ███▄    █ ▓█████▄         (_, |      __ __      | ,_)           XX
XX          \'\    /  ^  \    /'/            ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓█   ▀  ██ ▀█   █ ▒██▀ ██▌           \'\    /  ^  \    /'/              XX
XX           '\'\,/\      \,/'/'             ▒ ▓██░ ▒░▒██▀▀██░▒███      ▒███   ▓██  ▀█ ██▒░██   █▌            '\'\,/\      \,/'/'               XX
XX             '\| []   [] |/'               ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒▓█  ▄ ▓██▒  ▐▌██▒░▓█▄   ▌              '\| []   [] |/'                 XX
XX               (_  /^\  _)                   ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒████▒▒██░   ▓██░░▒████▓                 (_  /^\  _)                   XX
XX                 \  ~  /                     ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░░ ▒░ ░░ ▒░   ▒ ▒  ▒▒▓  ▒                   \  ~  /                     XX
XX                 /HHHHH\                       ░     ▒ ░▒░ ░ ░ ░  ░    ░ ░  ░░ ░░   ░ ▒░ ░ ▒  ▒                   /HHHHH\                     XX
XX               /'/{^^^}\'\                   ░       ░  ░░ ░   ░         ░      ░   ░ ░  ░ ░  ░                 /'/{^^^}\'\                   XX
XX           _,/'/'  ^v^  '\'\,_                       ░  ░  ░   ░  ░      ░  ░         ░    ░                _,/'/'  ^v^  '\'\,_               XX
XX          (_, |           | ,_)                                                                            (_, |           | ,_)              XX
XX            (_)           (_)                                                                                (_)           (_)                XX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            ");
            

            
        }
        ///<summary>
        ///End of the ascII pictures.
        /// ^^^^^^^^^^^^^^^^^^^^^^^
        /// </summary>

        
                

     }
}

