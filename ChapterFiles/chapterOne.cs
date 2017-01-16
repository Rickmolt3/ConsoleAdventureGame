using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortStoryConsoleGame
{
    class Chapter1Class
    {
        private int pageNo;
        public string username;
        public Chapter1Class(int pageNo)//the argument uses the datatype and var name
        {
            
            switch (pageNo)
            {
                case 1:
                    one();
                    break;
                case 2:
                    two();
                    break;
                case 3:
                    three();
                    break;
                case 4:
                    four();
                    break;
                case 5:
                    five();
                    break;
                case 6:
                    six();
                    break;
                case 7:
                    seven();
                    break;

            }



        }
       
        public void one()
        {
            Console.WriteLine("Goalfinger looks at you, The Football Manager and calls you over");
            Console.WriteLine("What name have you chosen today");
            string username = Console.ReadLine();
            Console.WriteLine("My name is " + username + " Manager of Tottenham");
            Console.WriteLine("The British Embassy in Washington, D.C. has been infiltrated by KGB");
            Console.WriteLine("Posing as The Redskins Kicker, Goalfinger flies to D.C.");
            Console.WriteLine(username + "Tells Goalfinger the KGB are at Monday Night Football game");
            Console.WriteLine("And at a High Stakes Pokergame in Georgetown");
            Console.WriteLine("Go to Football or Poker?");
            Console.WriteLine("Type 'football' or 'poker");
            string choiceOne = Console.ReadLine();
            choiceOne.ToLower();
            Console.ReadKey();
            ///if then statements Choices #1

            if (choiceOne == "football")
            {
                two();
            }
            else if (choiceOne == "poker")
            {
                three();
            }
            else
            {
                Console.WriteLine("Please choose 'football' or 'poker'");
            }
        }

        public void two()
        {

            Console.WriteLine(username + "Heads to FedEx Field Suite with Goalfinger's pet Toucan");
            Console.WriteLine("Goalfinger heads to the field with his PPK Walther under his Jersey");
            Console.WriteLine(username + "calls to Goalfinger via an earpiece in his helmet to warn him");
            Console.WriteLine("KGB is posing as a Linebacker on the other team");
            Console.WriteLine("Do you want to KILL the KGB agent or SPARE him");
            string userInput = Console.ReadLine();
            
            if (userInput == "kill")
            {
                four();
            }
            else if (userInput=="spare")
            {
                five();
            }
            else
            {
                Console.WriteLine("That is not an option");
            }
        }
        public void three()
        {
            Console.WriteLine(username + "Drives Goalfinger and his Toucan to the High Stakes Poker Game");
            Console.WriteLine("Goalfinger heads to the table while" + username + "heads to the bar");
            Console.WriteLine(username + "Signals to Goalfinger. 'The Dealer is the KGB Agent'");
            Console.WriteLine("The KGB Agent reaches for his Gun");
            Console.WriteLine(username + "Releases Goalfinger's pet Toucan to attack the KGB Agent");
            Console.WriteLine("Do you want to Kill the KGB Agent or Spare him");

            string userInput = Console.ReadLine();

            if (userInput=="kill")
            {
                six();

            }
            else
            {
                seven();
                Console.WriteLine("That is not an option");
                Console.ReadKey();
            }

        }
        public void four()
        {
            Console.WriteLine("Goalfinger pulls his PPK Walther from his Jersey");
            Console.WriteLine("Goalfinger kills the KGB Agent posing as a Linebacker");
            Console.WriteLine("The End");
            Console.ReadKey();
        }
        public void five()
        {
            Console.WriteLine("The KGB Agent Linebacker pulls his 9mm from his Jersey");
            Console.WriteLine("The KGB Agent kills Goalfinger");
            Console.WriteLine("Goalfinger dies");
            Console.WriteLine("The End");
            Console.ReadKey();
        }
        public void six()
        {
            Console.WriteLine("Agent Goalfinger's pet Toucan swoops down from his perch at the Bar");
            Console.WriteLine("The Toucan attacks the KGB Agent");
            Console.WriteLine("The KGB Agent dies");
            Console.WriteLine("The End");
            Console.ReadKey();
        }
        public void seven()


            {

            Console.WriteLine("The KGB Agent pulls out his 9mm");
            Console.WriteLine("The KGB Agent shoots Goalfinger");
            Console.WriteLine("Goalfinger dies");
            Console.WriteLine("The End");
            Console.ReadKey();
            }


            



            
            ///choose to go to Monday Night Football or Poker Game
            
            ///choose to Kill KGB or Goalfinger dies
            ///poker game choice
            
            ///choose to kill KGB Agent or Goldfinger dies

                
      

                
           
        
          

     }

}
