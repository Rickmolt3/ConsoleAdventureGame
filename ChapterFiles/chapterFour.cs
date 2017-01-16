using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortStoryConsoleGame
{
    class ChapterFour
    {
        private int pageNumber2;
        string sidekickName="";

        public ChapterFour(int pageNo1)
        {
            pageNumber2 = pageNo1;

            switch (pageNumber2)
            {
                case 61:
                    PageSixtyOne();
                    break;
                case 62:
                   PageSixtyTwo();
                    break;
                case 63:
                    PageSixtyThree();
                    break;
                case 64:
                    PageSixtyFour();
                    break;
                case 65:
                    PageSixtyFive();
                    break;
                case 66:
                    PageSixtySix();
                    break;
                case 67:
                    PageSixtySeven();
                    break;
                case 68:
                    PageSixtyEight();
                    break;
                case 69:
                    PageSixtyNine();
                    break;
                case 70:
                    PageSeventy();
                    break;
                case 71:
                    PageSeventyOne();
                    break;
                case 72:
                    PageSeventyTwo();
                    break;
                case 73:
                    PageSeventyThree();
                    break;
                default:
                    PageSixtyOne();
                    break;
            }
         } 
        public void PageSixtyOne()
        {
            String answer = "";
            Console.WriteLine("You are a fellow agent and football teammate to Goalfinger. You will be meeting him at the British consulate in NY.");
            Console.WriteLine("What's your Name");
            sidekickName = Console.ReadLine();
            
            Console.WriteLine(sidekickName + " and Goalfinger, are told that the prime minister is in danger.");
            Console.WriteLine("The contract killer goes by the nickname Green-Eyed Bandit.");
            Console.WriteLine("The prime Minister will be leaving a United Nations covention to attend the NY Giants Annual Meet and Greet Gala for the entire weekend");
            Console.WriteLine(sidekickName + " and GoalFinger will be scoping out the various locations to find the killer.");
            Console.WriteLine("Choose which location you and Goalfinger will be like to search first.Type 'A' if you choose to go to the United Nations convention or 'B' if you would like to go to Meadowland's Stadium");
            answer = Console.ReadLine().ToUpper();

            if (answer == "A")
            {
                PageSixtyTwo();
            }
            else if (answer == "B")
            {
                PageSixtyThree();
            }
        }
        public void PageSixtyTwo()
        {
            Console.WriteLine("Great Choice "+ sidekickName);
            Console.WriteLine("You will need to scope the convention for any suspicious people and probably best to follow the prime minister up to Meadowland Stadium.");
           // Console.WriteLine("Press Enter to go to the convention");

            PageSixtyFour(); 
        }
        public void PageSixtyThree()
        {
            Console.WriteLine(@"Well "+ sidekickName +"looks like your mission with Goalfinger has come to an end. Since you didn't go to the convention first the prime minister was shot and the killer escaped. Better luck on your next mission!");
        }
        public void PageSixtyFour()
        {
            String answerOne= "";
            Console.WriteLine(@" You and Goalfinger, reach the convention at the Ritz Carlton Hotel and you find the prime minister shaking hands with fellow world leaders and other attendees. You and GoalFinger, decide to split up and take opposite sides of the hotel to search for the Green-Eyed Bandit");
            Console.WriteLine("As you come off the elevator of the 3rd floor of the hotel, you see a door that was left slightly open, but you also hear some commotion from behind you that sounds like running footsteps.");
            Console.WriteLine("Type 'C' if you choose to go inside the hotel room or 'D' to go after the running footsteps.");
            answerOne = Console.ReadLine().ToUpper();

            if (answerOne == "D")
            {
                PageSixtyFive();
            }
            else if (answerOne == "C")
            {
                PageSixtySix();
            }
        }
        public void PageSixtyFive()
        {
            Console.WriteLine("Great choice " + sidekickName +"!");
            Console.WriteLine("You decide to run after the footsteps behind you to find none other than Green-Eyed Bandit.");
            Console.WriteLine("He was alerted that you and Goalfinger were in tlhe hotel, and he decided to escape.");
            Console.WriteLine(@"He goes up the exit stairs up to the roof of the building, you exchange gunfire before reaching the roof, but you both miss. You reach the roof and you see that the Green-Eyed Bandit jumped the roof to the next building but he is too far away and you don't have a cleans shot so you let him escape and head back downstairs to the convention to find Goalfinger.");
            // Console.WriteLine("Press Enter to go to the next page");
            PageSixtySeven();

        }
        public void PageSixtySix()
        {
            Console.WriteLine(@"Well " + sidekickName +", it looks like your mission with Goalfinger has come to an end. Because you choose to go into the hotel room you didn't find anything but a maid cleaning the room. The running footsteps were the killer getting away when he was alerted that you and Goalfinger were spotted in the hotel. He killed the prime minister at Meadowland's Stadium. Better luck on your next mission");

        }
        public void PageSixtySeven()
        {
            String answerTwo = "";
            Console.WriteLine("You find Goalfinger in the lobby with the prime Minister and explain your encounter with the Green-Eyed Bandit.");
            Console.WriteLine("You safely get the prime Minister into his vehicle and you and Goalfinger follow his towncar to Meadowland Stadium");
            Console.WriteLine("Up ahead on the turnpike, Goalfinger sees some commotion ahead, people are getting out of their cars and running towards your direction.");
            Console.WriteLine("Type 'E' if you find an exit strategy for you, Goalfinger and the prime minister or 'F' if you exit the vehicle to access where the commotion came from.");
            answerTwo = Console.ReadLine().ToUpper();

            if (answerTwo == "E")
            {
                PageSixtyEight();
            }
            else if (answerTwo == "F")
            {
                PageSixtyNine();
            }
                
        }
        public void PageSixtyEight()
        {
            Console.WriteLine("Great choice " + sidekickName+"!");
            Console.WriteLine("Goalfinger honked at the towncar and motioned for them to take the nearby exit that you saw a few feet away, and you found an alternate route to MeadowLand Stadium.");
            // Console.WriteLine("Press Enter to go to the next page");
            PageSeventy();
        }
        public void PageSixtyNine()
        { 
            Console.WriteLine(@"Well " + sidekickName+", it looks like your mission with Goalfinger, has come to an end. Since you choose to exit the vehicle and access the commotion on the turnpike. Green-Eyed Bandit was hiding behind a vehicle and shot you in the head, killing you instantly. A bomb was placed under the Minister's towncar when back at the convention, which Green-Eyed bandit blew up. Although Goalfinger was able to get away before the blast. Better luck on your next mission!");
        }
        public void PageSeventy()
        {
            Console.WriteLine("Before arriving at the stadium you make a pit stop at a nearby hotel so that everyone can get changed and ready for the cocktail party they are having this evening.");
            Console.WriteLine("While getting ready you and Goalfinger try to devise a plan that you will use at the party to not alert other guests, as well as call back up agents to assist.");

            PageSeventyOne();
            }
        public void PageSeventyOne()
        {
            String answerThree = "";
            Console.WriteLine("You enter the cocktail party with Goalfinger and the prime minister. You and Goalfinger walk off to allow the Minister to mingle with everyone to see if he lures any suspicious guest.");
            Console.WriteLine(@"You see a waiter walking around to see if anyone would like drinks, you see the waiter headed over to the Minister and he takes a drink. He doesn't take a drink instantly because he was in the middle of the conversation.");
            Console.WriteLine(@"You notice that something is floating in his glass. Type 'G'if you alert the minister that he has something in his glass or 'H' if you accidentally bump into him making him spill his drink.");
            answerThree = Console.ReadLine().ToUpper();

            if (answerThree == "H")
            {
                PageSeventyTwo();
            }
            else if (answerThree == "G")
            {
                PageSeventyThree();
            }
        }
        public void PageSeventyTwo()
        {
            Console.WriteLine("Great choice " + sidekickName+"!");
            Console.WriteLine(@"While you were apologizing to the minister for accidentally bumping into him, Goalfinger was one step ahead of you and followed the waiter's direction where he met him in the kitchen. The waiter was the Green-Eyed Bandit in disguise. He was hand-cuffed and taken into custody.");
            Console.WriteLine("Good job " + sidekickName + "!You and Goalfinger have successfully completed your mission. You may now continue on to your next mission!");

        }
        public void PageSeventyThree()
        {
            Console.WriteLine(@"Well " + sidekickName + ", it looks like your mission with Goalfinger, has come to an end. Because you choose to alert the minister that he had something in his glass, while you poorly executed your attempt, Green-Eyed Bandit shot through the glass killing the prime minister and causing havoc throughout the party. Better luck on your next mission!");
        }

    }  
    }


