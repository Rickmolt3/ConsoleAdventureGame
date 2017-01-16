using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortStoryConsoleGame
{
    class chapterFive
    {
        public chapterFive(int startPage)
        {
            switch (startPage)
            {
                case 81:
                    page81();
                    break;
            }

        }
        //path 1
        public void page81()
        {
            Console.WriteLine("Agent Goafinger looks over to you his best friend");
            Console.WriteLine("He tosses you two weapons a HAMMER and a SHOVEL you only have time to choose one which do you take?");
            string userInput = Console.ReadLine();
            if (userInput == "hammer")
            {
                Console.WriteLine("You grab the hammer from agent goalfinger and throw it into the deathmachines ray and survive the blast");
                page85();
            }
            else if(userInput == "shovel")
            {
                Console.WriteLine("You take the shovel from agent goalfinger and block the deathray and it reflects into the door and sets you both free.");
                page82();
            }
            else
            {
                Console.WriteLine("That is not an option try again.");
                page81();
            }
            
        }
        //path 1
        public void page82()
        {
            Console.WriteLine("Agent Goalfinger looks over to you while you dash through the corridors and thanks you for picking the shovel.");
            Console.WriteLine("You then run out of the building and get into his Austin Martin and speed away.");
            Console.WriteLine("Agent Goafinger then asks if you should go LEFT or RIGHT at the intersection.");
            string userInput = Console.ReadLine();
            if (userInput == "left")
            {
                page83();
            }
            else if (userInput == "right")
            {
                page84();
            }
            else
            {
                Console.WriteLine("That is not an option try again");
                page82();
            }

        } 
        //path 1
        public void page83()
        {
            Console.WriteLine("Agent Goalfinger takes a sharp left and speeds down a highway you discover the purp that locked you both in the building. Do you pursue YES or NO");
            string userInput = Console.ReadLine();
            if (userInput == "no")
            {
                Console.WriteLine("You decide not to pursue and instead turn off the road and go home with you lives intact");
                Console.ReadKey();
            }
            else if (userInput =="yes")
            {
                Console.WriteLine("You speed up and tailgate the purp. Agent Goalfinger says take the wheel while he jumps onto his car.");
                Console.WriteLine("Goalfinger leaps the gap and lands on the roof of the bad guy, he then knocks him out and safely parks the car on the side of the road.");
                Console.WriteLine("Congratulations you and Agent Goalfinger have caught the criminal and may now turn him in for the reward.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("That is not an option try again.");
                page83();
            }
        }
        //path 1
        public void page84()
        {
            Console.WriteLine("Agent Goalfinger takes a sharp right and speeds down a highway. Do you choose to OPEN the briefcase you stole or leave it SHUT. ");
            string userInput = Console.ReadLine();
            if (userInput == "open")
            {
                Console.WriteLine("You open the case you took from the building you were held at and it contains a bomb, it explodes and you and Agent Goalfinger are killed.");
                Console.ReadKey();
            }
            else if (userInput == "shut")
            {
                Console.WriteLine("You leave the case shut but its making a strange ticking noise");
                Console.WriteLine("You and Agent Goalfinger decide to just give up and head home.");
                Console.WriteLine("Congratulations you survived");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("That is not an option try again.");
                page84();
            }
        }
        //path 2
        public void page85()
        {
            Console.WriteLine("The deathray reflects and breaks a hole in the wall large enough for you to escape.");
            Console.WriteLine("Do you want to try to leave out of the DOOR or the HOLE in the wall.");
            string userInput = Console.ReadLine();
            if (userInput == "door")
            {
                Console.WriteLine("The door is locked and deadbolted and while you were checking the wall collaspsed in on itself. There is now no escape better luck next time.");
                Console.ReadKey();
            }
            else if (userInput == "hole")
            {
                Console.WriteLine("You and Agent Goalfinger run through the door at the last second and barely make it before it collapses.");
                Console.WriteLine("You are able to get to a vehicle and escape the burning building, congratulations you survived.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("That is not an option try again.");
                page85();
            }
        }
    }
}
