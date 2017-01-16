using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortStoryConsoleGame
{
    class ChapterThree
    {
        public string baseCharacter;
        public string username;

        public ChapterThree(string mainCharacter)


        {
            ///
            ///this is the start of my process
            ///
            baseCharacter = mainCharacter;

            Console.WriteLine(" We find " + baseCharacter + "in Dubai partaking in a Jet Surfing Competition");
            Console.WriteLine(" You are an old friend of " + baseCharacter + " competing in Dubai's own Jet surfing competition as well and are known for partaking in unique sports while you, unknowingly to others, carry out secret missions as an agent. ");
            Console.WriteLine("WHAT WOULD YOU LIKE TO BE CALLED SECRET AGENT?");
            string username = Console.ReadLine();
            Console.WriteLine("You are scoping out the competition while waiting for the race to start and performing tricks in the water with your jet surf board when " + baseCharacter + " approaches you.");
            Console.WriteLine(baseCharacter + " looks from a distance and recognizes your talent which prompts him to draw closer to you");
            Console.WriteLine("\"Well if it isn't my relentless friend " + username + "!\"" + " he yells");
            ///
            ///added backward slash to embed a quotation
            ///
            Console.WriteLine("You smirk and slowly ride to shore towards him");
            Console.WriteLine("Both of you engage in small talk when he suddenly starts lowering his voice and says");
            Console.WriteLine("You must know why im here " + username + " , its time I brief you on our mission");
            Console.WriteLine("We have intel that a terrorist group will be test driving here a small discreet device they have been working on designed to turbocharge any vehicle that may also result in spontaneous combustion.... ");
            Console.WriteLine(" With that in mind remote attacks on many and any typ of transportation could be imminent, and Dubai having many exotic vehicles lying around I wouldn't doubt their appearance here");
            Console.WriteLine("Now that you see the dangers the public could be facing how about we split and scope out the place while we wait to race?");
            Console.WriteLine("You then make your way down the shoreline not straying away from the other competitors. ");
            Console.WriteLine("You spend a couple hours conversing with the other competitors serveyin the shoreline when suddenly you hear an announcment through the shoreline speakers mention the race is about to start");
            Console.WriteLine("YOU NOTICED YOU VENTUREED OFF A LITTLE FURTHER THAN EXPECTED BUT SEE AN OPENING");
            Console.WriteLine("THROUGH THE CROWD OF PEOPLE BACK TO THE RACE, YOU ALSO NOTICE YOU CAN SURF NEAR THE SHORELINE BACK TO THE RACE");
            Console.WriteLine("CHOOSE " + "'surf'" + " TO SURF THROUGH SHORELINE OR" + " 'crowd' " + "TO FIGHT YOUR WAY THROUGH THE CROWD");
            string choiceOne = Console.ReadLine();
            choiceOne.ToLower();
            Console.ReadKey();
            /// if then statements Choices #1
            if (choiceOne == "surf")
            {
                page42();
            }
            else if (choiceOne == "crowd")
            {
                page43();
            }
            else
            {
                Console.WriteLine("Please type either 'SURF' or 'CROWD'");
            }
            /// <summary>
            /// end of intro
            /// </summary>
        }
        /// <summary>
        /// start of page 42
        /// </summary>
        public void page42()
        {
            //// page 42 context
            Console.WriteLine("You have arrived in time with a few minutes to spare to the start of the race");
            Console.WriteLine("you notice other competitiors with unknown high tech boards and point it out to" + baseCharacter);
            Console.WriteLine("Quickly you take account of everything that has happened and decide on taking action");
            Console.WriteLine("YOUR SPY INSTINCTS THEN SUGGEST YOU TO GO ASK PEOPLE ABOUT THE BOARD BUT YOUR COMPETITIVE ATTITUDE SUGGESTS YOU GATHER INFO ON WHERE TO GET ONE FOR THE RACE BUT YOU WOULD ALSO LIKE TO CONVINCE " + baseCharacter + " TO HOLD OFF ON MISSION SO YOU BOTH CAN RACE AND CONCENTRATE ON COMPETING AGAINST ONE ANOTHER");
            Console.WriteLine("TYPE 'SPY' TO ASK COMPETITORS ABOUT THE HIGHTECH BOARD, OBTAIN' TO ASK AROUND TO OBTAIN THE HIGHTECH BOARD, or 'CONVINCE' to convince" + baseCharacter + " to disregard everything and compete against you in the race  ");
            string choiceTwo = Console.ReadLine();
            choiceTwo.ToLower();
            if (choiceTwo == "spy")
            {
                page44();
            }
            else if (choiceTwo == "obtain")
            {
                page45();
            }
            else if (choiceTwo == "compete")
            {
                page46();
            }
            else
            {
                Console.WriteLine("Please use type either 'SPY' 'OBTAIN' or ' COMPETE ");
            }



        }
        ///Start of page 44
        public void page44()
        {
            Console.WriteLine("You ask around and talk with various competitors about the HighTech board and all were acquired by a merchant stranger");
            Console.WriteLine("Eventually you are led to the stranger who you find out is distributing modded boards with the terrorist device installed.");
            Console.WriteLine("You see a surfer with the board doing tricks in the water you a surfer as his board throttled automatically and eventually combusted");
            Console.WriteLine("Meanwhile" + baseCharacter + " sneaks up behind the strange merchant and convinces him to keep quiet and follow him where you then suspect he'll be taken back to HQ for interrogation. ");
            Console.WriteLine("!!!!!!Mission Accomplished!!!!!!");
            Console.ReadKey();
            //// END you win

        }
        public void page45()
        {
            Console.WriteLine("You ask around until you eventually stumble upon stranger selling the HighTech boards");
            Console.WriteLine("He seemed a bit shady but you were just happy you have a board to unleash your full potential in the race");
            Console.WriteLine("You lined up ready for the race along with everyone else and take off on the gunshot");
            Console.WriteLine(" Your in the lead and seconds before the finish line yor board throtttles to its maximum speed and moments before you see " + baseCharacter + " look at you from the crowd with a horrific look in is face");
            Console.WriteLine(" CONGRATS YOU JUST PLAYED YOURSELF-----YOUR BOARD COMBUSTED AND TURNED YOU INTO PIECES");
            Console.WriteLine(" ---YOU HAVE FAILED THE MISSION ---");
            Console.ReadKey();
        }

        public void page46()
        {
            Console.WriteLine("" + baseCharacter + " and you line up and shoot out full speed at the sound of the starting pistol");
            Console.WriteLine("You both push each other competitively through out the race each one keeping the lead simaltaneously fighting for first place while making sure you both are giving all that y'all can.");
            Console.WriteLine(" As you both are relentlessly keeping the lead nearing the finsih line you end up gaining a couple feet ahead of" + baseCharacter + " right before that victorious moment you both hear explosions behind and start seeing limbs raining down on you both as you cross the finishline");
            Console.WriteLine(" Your stomach suddenly sinks as you win the race and you feel shame and disgust drown you as you hit the shore and fall to your knees........");
            Console.WriteLine(" YOU HAVE COST THE LIFES OF MANY TO FUEL YOUR PRIDE, THE TECHBOARDS CONTAINED THE TERRORIST DEVICE AND COMBUSTED");
            Console.WriteLine(" ---YOU HAVE FAILED THE MISSION ---");
            Console.ReadKey();
        }
        public void page43()
        {
            Console.WriteLine(" You scurry and make your way through the crowd when you bump into a merchant stranger");
            Console.WriteLine(" You both fall dropping each others boards");
            Console.WriteLine("As you quickly get up and see the stranger a bit disoriented from the fall you get a glimpse of an unknown new high end board that board being his");
            Console.WriteLine("YOU CAN EITHER 'APOLOGIZE' AND RUN BACK TO RACE, BRING 'ATTENTION' TO HIS HIGHTECH BOARD AND ASK ABOUT IT, OR USE SLEIGHT OF HAND TO SECRETLY 'SNEAK' AND TAKE HIS BOARD AS IT LOOKS POWERFUL ");
            Console.WriteLine("CHOOSE AND TYPE 'APOLOGIZE', 'ATTENTION', OR 'SNEAK'");
            string choiceThree = Console.ReadLine();
            choiceThree.ToLower();
            if (choiceThree == "apologize")
            {
                page46();
            }
            else if (choiceThree == "attention")
            {
                page47();
            }
            else if (choiceThree == "sneak")
            {
                page48();
            }
            else
            {
                Console.WriteLine(" Please choose either 'apoligize' 'attention' or 'sneak'");
            }
        }

        public void page47()
        {
            Console.WriteLine(" You ask the Stranger about the board as you help him up, he smirks and mentions its only the best board about to hit the market and hands you the board to take on a test drive in the race");
            Console.WriteLine("You take his offer and head to the start in time");
            Console.WriteLine("At the start you get ready and take off at full speed at the sound of the gunshot.");
            Console.WriteLine("You notice youv'e never gone this fast before and are about to near the finish line when you hear" + baseCharacter + " yell from behind 'GET OFF THE BOARD'" + username + "!'");
            Console.WriteLine(" THAT MOMENT REPLAYED AND FLASHED THROUGH YOUR MIND AS YOUR FINAL THOUGHTS FROM HAVING YOUR BODY EXPLODE INTO BITS FROM THE BOARD COMBUSTING");
            Console.WriteLine(" ---YOU HAVE DIED,MISSION FAILED ---");
            Console.ReadKey();
        }
        public void page48()
        {
            Console.WriteLine("Once you head back to the race you notice a few others with the same board as you which makes you suspicious of the stranger");
            Console.WriteLine("You question the other competitiors and it turns out they have met the same stranger whom you took the board from");
            Console.WriteLine("suddenly " + baseCharacter + "Shows up and you ask him to RUN SOME diagnostics on your new board");
            Console.WriteLine("It appeared the board contained the terrrorist device," + baseCharacter + " then discreetly throws a device in the air that shot out electric pulses that seeked out the boards similar to yours and deactivated them");
            Console.WriteLine("You both then spot out the stranger which" + baseCharacter + " gives a signal where the stranger is targeted and hit with a knockout tranquilizer and snuck out by other stationed agents without being noticed");
            Console.WriteLine("!!!You SuccesFully Completed The Mission!!!");
            Console.ReadKey();
        }
    }
}