using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

/// <summary>
/// Alejandro Castillo
/// TIY Fall 2016
/// </summary>

namespace ShortStoryConsoleGame
{
    class chapterTwo
    {
        private String artificialInt;//global user input variable
        private int pageNumber;      // page number for further utility in switching pages/sections
        static SpeechSynthesizer synth = new SpeechSynthesizer();

        public chapterTwo(String artInt, int pageNo)//the argument uses the data type and the variable name 
        {
            pageNumber = pageNo;
            artificialInt = artInt;
            synth.SetOutputToDefaultAudioDevice();

            switch (pageNumber)
            {
                case 21:
                    twentyOne();
                    break;
                case 22:
                    twentyTwo();
                    break;
                case 23:
                    twentyThree();
                    break;
                case 24:
                    twentyFour();
                    break;
                case 25:
                    twentyFive();
                    break;
                case 26:
                    twentySix();
                    break;
                case 27:
                    twentySeven();
                    break;
                case 28:
                    twentyEighth();
                    break;
                case 29:
                    twentyNine();
                    break;
                case 30:
                    thirty();
                    break;
                case 31:
                    thirtyOne();
                    break;
                default:
                    twentyOne();
                    break;
            }
        }

        private void twentyOne() // method for introduction and ascii
        { //http://www.asciiworld.com/-Cars-.html
            Console.WriteLine(@"  
__---~~~~--__                      __--~~~~---__
 `\---~~~~~~~~\\                    //~~~~~~~~---/'  
   \/~~~~~~~~~\||                  ||/~~~~~~~~~\/ 
               `\\                //'
                 `\\            //'
                   ||          ||      
         ______--~~~~~~~~~~~~~~~~~~--______              
    ___ // _-~                        ~-_ \\ ___  
   `\__)\/~                              ~\/(__/'          
    _--`-___                            ___-'--_        
  /~     `\ ~~~~~~~~------------~~~~~~~~ /'     ~\        
 /|        `\         ________         /'        |\     
| `\   ______`\_      \------/      _/'______   /' |          
|   `\_~-_____\ ~-________________-~ /_____-~_/'   |  
`.     ~-__________________________________-~     .'       
 `.      [_______/------|~~|------\_______]      .'
  `\--___((____)(________\/________)(____))___--/'           
   |>>>>>>||                            ||<<<<<<|
");
            Console.WriteLine(@"

The sun dims, as it sets over the mountains of Spain. The European poker tour had come to an end and he'd done considerably well placing in the money. 
Taking his share with him to celebrate he'd sped off in his candy red Lamborghini Aventadore. 
Winding and twisting at every turn, Narrow and twisting, like the branches of a tree carving through the rock.. 
They called it 'Carretera de Sa Calobra'. The European poker tour had finalized for the year and 
GoalFinger was planning on enjoying himself before handling the affairs of governments across the globe. 
Besides, he thought to himself, it's not every day a man makes six figures for sitting a little and 
thinking of chance as a means of utility in expected values in decision making.");
            Console.WriteLine(@"
GoalFinger hears a muffled ringing in the glovebox. He opens it with hesitance. He didn't like ringing. 
It bothered him like the festering of flies on the carcass of a dying animal. 
He pulls out a strange phone. The design unfamiliar to him. It flashes wildly and settles on a navy blue screen. A smiley emoticon appears, beeping and flashing twice.");
            Console.WriteLine(@"In a monotonous tone the phone speaks...");
            SetVariables(); //second 'page' where user assigns input name
        }

        private void SetVariables()//method for user name
        {
            String artInt = artificialInt;


            Console.WriteLine("\nGive me a name... it requests.");
            artificialInt = Console.ReadLine(); //user input assigned to artificialInt and set to artInt globalyy
            synth.Speak("Give me a name");

            twentyTwo();
        }

        private void twentyTwo()//method for page 22
        {
            Console.WriteLine(@"
'Welcome Operative, to the lastest in technological solutions available to you. "+artificialInt+" was created to enable instantaneous communication\n with MI6 and allows creative solution methods for adverse scenarios you're facing.This device will not fail you.'");
            Console.WriteLine(@"GoalFinger chuckles lightly.'So I'm supposed to entrust my life to a machine these days. 'tch'.' 
He continues speeding faster and faster through the roads heading home. It'd be a few hours before he got home but in this vehicle it'd be a 
matter of ambition to cut the hours back. "+artificialInt+ " remains silent. GoalFinger glances at his rear view mirror by chance and\n notices a black Koenigsegg Regera trailing him and accelerating. GoldFinger tastes the tension and the hairs on his neck shoot up. They follow closely and GoalFinger notice two individuals in the two seater. The passenger peeps his head out of the window and pulls out an AR.\n Both cars hug the road grasping at the asphalt for control. Sqeeeling rubber is the only sound heard in the twilight as the red and black outlines disappear around every turn. You come to a fork in a road with bullets flying over your shoulder, what do you want to do.. left or right");
            Console.WriteLine(@"

Type in left to duck the gunfire in a little village hidden in the mountains. Type right to go faster and attempt to out drive the Koenigsegg across the twisting mountains.");
            String decisionsOne = Console.ReadLine();

            if (decisionsOne == "left")
            {
                twentyThree();
            }
            else if (decisionsOne == "right")
            {
                Console.WriteLine(@"Right it is. The Lambo speeds up to incredibly high speeds and both cars' engines are singing operatically through the valleys. These agents weren't a match for him he felt almost instantly. Their shot grouping was improving precision but he could out pace them. Faster and Faster, GoalFinger felt the G-Forces turn to nothing as competing car began to slow at turns instead of attempt to catch up. ''tch, no contest.");
                twentySix();
            }
            else
            {
                Console.WriteLine("---Error in input. Exact phrasing only please---");
                twentyTwo();
            }

        }

        private void twentyThree()
        {
            Console.WriteLine(@"The lambo breaks left and heads off into the little village. Through back streets and antiquated brick roads and you almost got away.");
            Console.WriteLine(@"Except you didn't see a little old man pull out with a cart of cabbage. A hard hand break and stomp on the brake is all 
GoalFinger remembers before hearing a crash and an enveloping white haze.");
            Console.WriteLine(@"He wakes in a dark room hanging from your wrists. In and out of reality... GoldFinger passes out..");
            Console.WriteLine(@"He feels incessant fists plummeting his body like hammers trenching into his flesh. 
*Bang bang bang* the fists become percussive to GoalFingers skull. Blood pours from the mouth of GoalFinger. 
Hanging in the manner which he was made GoalFinger feel like a piece of meat ready for the grinder. The heavy builded torturer steps out of the room. 
GoalFinger remembers the pair in the Koenigsegg. He scans the room as his eyes adjust and takes attention to his location. This isn't a room. This is a dungeon. 'I've gotta be on the outskirts still'. He sees a table to the right of the door where the torturer left. "+ artificialInt+" he exclaims to himself. "+ artificialInt +" where am I? How long have I been out? Get me out of here.");
            Console.WriteLine(@artificialInt+" lightly chirps up. I've been listening and watching attentively. GoalFinger, you've requested my assistance. You've been unconscious for seven hours and was dragged to a castle hidden discretely in the mountains. There's only 2 in the building as far as I'm aware but they're waiting for reinforcements to further extrapolate data from you. If you want to escape you've got two options at the moment. You can either dislocate your hand to slide out of those cuffs or wait until a sleeper is sent.");
            Console.WriteLine(artificialInt + " , how far away is this sleeper? They can be here in less than two hours. Not much of options you're giving me "+artificialInt);
            Console.WriteLine(@"Type 'break' to push GoalFinger to break his hand");
            Console.WriteLine(@"Type 'call' to ring a sleeper agent in area for assistance");
            string decisionTwo = Console.ReadLine();//user input for stoyline split. 

            if (decisionTwo == "break") //this decision moves to a different page
            {
                twentyFive();

            }
            else if (decisionTwo == "call") //this decisions moves user to a different page
            {

                twentyFour();
            }
            else // repeats user input query if failed to meet prior conditions
            {
                Console.WriteLine("---Error in input. Exact phrasing only please---");
                twentyThree();
            }
 
        }
        private void twentyFour() //page 24 of user 'story'
        {
            Console.WriteLine(@"
You touch every strand of data on the networks around; screening for an agent, an officer, anybody. You find one in seconds detailing plans and methods to proceed.");
            Console.WriteLine(@"
The only thing they see on their phone is a location and a purpose. They proceed.");
            Console.WriteLine(@"
GoalFinger waits patiently hanging, listening and contriving his means of escape. " + artificialInt + ", do you know who they are? 'KGB, sir', " + artificialInt + " retorts quickly. The cell is dark and humid. The air tastes of stale humidity and human feces. GoalFinger wonders to himself what's been hidden away in these walls. If they were using it discretely then they'd made a mistake by bringing him here. There'd soon be another agent in the building soon enough and would clear it out.");
            Console.WriteLine(@"'GoalFinger your assistance is here,'" + artificialInt + "beeps.Let's get the frack out of here. Gunshots reverberated through the corridors outside the door. Shot after shot it goes on for a while before quieting down. Footsteps approach your room. The door opens ever so slowly and a man drenched in blood walks in. Staring at GoalFinger hanging by his hands he walks towards him. 'GoalFinger you're free,'he says with an idiotic smile.'Took care of the backup too'. You should get out of here before things get hairy. This castillo is filled with objects, paperwork, and riches that'll only add to the reasons why you shouldn't be here.");
            Console.WriteLine(@"'Thanks, I owe you one'.");
            twentySix(); //leads to page 26
        }
        private void twentyFive()
        {
            Console.WriteLine(@"
You quietly tell GoalFinger, 'Do it or they'll kill you. You know what you have to do.' GoalFinger bites his lip, yelps silently and slips out. 
You hear multiple cracking/popping noise before you feel GoalFinger touch you. One hand at a time, wincing at every movement. "+artificialInt+ " creates a path through the castle and pings their position through a type of sonar and detection A.I. 'All that's left is opening this door,huh? Okay, let's catch a bad guy.' The bulky KGB agent walks opens the door dramatically but fails to recognize GoalFingers absence before receiving a foot to the face. With the newly created map GoalFinger sneaks quietly through the Castilian architecture.'Tunnel after tunnel, this isn't endless GoalFinger. We're nearly there'. They reach the gate with the automobiles, GoalFinger places his bones correctly. Quietly cringes and writhes with each pop that would be damn near impossible to achieve without the coercion of KGB agents lurking about with automatic weapons. The odd duo reaches the auto-mobiles and opens the gate out. "+artificialInt+", plot a course out of here. ");
            twentySix();
        }
        private void twentySix()
        {
            Console.WriteLine(@"
Escaped. Free, bloody. Pained and full of rage. Gold Finger firmly grasps you. 'Take me home',"+artificialInt+"', he exclaims before peeling out.");
            Console.WriteLine(@"
You reach the safe house. Bitter, exhausted with adrenaline coursing through your veins. Hurt and enraged.."+artificialInt+", contact MI6 for briefing. The screen glows and changes background. A man in a tux walks into frame and debriefs you on the corrupt official. They'd been trafficking people, drugs, and guns for decades without any form of resistance. Hell they ran the bloody government in these parts. The official was a corrupt state senator for this Spanish state. They'd been leaking information and providing aid to the defunct operatives. They had heard of GoalFinger being in the state and wanted at his brain. 'They aren't going to get away with putting their sights on me', thought GoalFinger.");

            synth.Speak("attack or confront...");

            Console.WriteLine(@"
There'd be two methods of taking this bastard down. He could head to their digitally tracked 'safe house' and gather evidence before laying down the 
hammer or head straight to the senators office to attempt to passively communicate before making any further decisions.
Type in attack or confront... decide your path of method of confrontation");

            String decisionThree = Console.ReadLine();

            if (decisionThree == "attack")
            {
                Console.WriteLine(@"
GoalFinger let's head to their base, sneak in and gather some intel. We can shut him down permanently with sufficient data and find 
enough accomplices to slow down some of their operations worldwide. The area routed is their most consumptive energy hotspot in the area. 
No doubt about it, let's head there.");
                twentyEighth();
            }
            else if (decisionThree == "confront")
            {
                Console.WriteLine(@"
GoalFinger let's go to the government building. Attempt that speech check before doing anything crazier. "+artificialInt+" pipes up in feigned terror.");
                twentySeven();
            }
            else
            {
                Console.WriteLine("---Error in input. Exact phrasing only please---");
                twentySix();
            }

        }
        private void twentySeven()
        {
            Console.WriteLine(@"
At the government building - Tuxed out pulling up unannounced. GoalFinger walks into the government offices. The receptionist 
glances at you and with a high browed accent asks you where you are going. GoalFinger lays out his charm on a silver platter. 
Smiles delicately at the older brunette trying to be vigilante but failing to do so with every subtle inspection of this man referring himself as 'GoalFinger'. 
Without a hitch, GoalFinger had succeeded on paying this scumbag a visit and was seconds away from getting out of the elevator and reading his soul. '"+artificialInt+", you on their network yet?' 'Just about, you'll have access in a few seconds'. As GoalFinger leaves the elevator and walks through the finely ornate hallway, he can't help but feel his blood boil. Everything in this building was providence through means of pain, sacrifice, and fear.'Good Morning, Mr. GoalFinger' -Likewise. The pleasure is mine. I've had  to take it upon myself to greet the man many of the locals are calling a hero. "+artificialInt+" beeps twice signaling the network connectivity. Thank you for your time, I must get moving. 'Not so fast GoalFinger', make sure you try the lamb in the area. I have no doubt you'd like the gentle texture of the meat. As GoalFinger leaves the building he feels eyes connected onto him. He'd exposed himself for the data. What do we got"+artificialInt+"? Not much I'm afraid. Another town a few miles away contains more high sensitivity materials. I'm sure actual explicit data on their treachery would be found there. Good"+artificialInt+" let's get moving. ");
            twentyEighth();
        }
        private void twentyEighth()
        {
            Console.WriteLine(@"
GoalFinger pulls up to the little town suspected of housing nefarious affairs. He parks the car in some close by back streets 
before performing his lurking. Luckily the safe house he was in was equipped with nighvision goggles, night vision scopes, and a plethora of other gadgets 
meant for covert missions such as this. The added bonus of the black turtle neck and the silcers on his pistols weren't anything to scoff at
, 'he thought to himself'. 'GoalFinger, I'm noticing specific convergent movement through the CCTV in the area'"+artificialInt+" announces.'I can overload a few transformers and shut down half the grid in this town before you make your move'. Let's make it GoalFinger bravely endeavors. They duo leave the car and after a block of walking explosions around the small town leave the area in complete darkness. GoalFinger manages to slip inside the building amidst the chaos created. With the swarm of people inside, it was almost too simple walking upstairs incapacitating a few guards and accessing their database and filing system. With each file glanced into GoalFinger is repulsed by the depravity of human condition. But everyone's got to eat and everyone is innocent as much as they are guilty, he scoffs. "+artificialInt+" beeps up, we've got to get moving lights will be on in 5 min. As soon as they are you will be spotted and induced to a oversaturation of lead. GoalFinger scans documents with "+artificialInt+", storing and compiling the data. They'd have to get out of there soon but not without taking enough information to liberate a few hundred people from the pains of modern slavery. GoalFinger 2 minutes. I'd suggest heading out. GoalFinger reluctantly pulls out of the building without being spotted and more miraculously with the data unencrypted and packaged to MI6.");
            twentyNine();
        }
        private void twentyNine()
        {
            Console.WriteLine(@"
With all the added information and confirmation on the exact villainy taking place. 
GoalFinger decides its time to stop pussy footing around and confront the final boss. Just because he'd become senator didn't guarantee his 
power would continue to go abound unhinged. Sacrificing his people for silver a penny. Despicable. As GoalFinger makes his way up the stairs to the officials office. 
He feels as though he is being expected. The security was more lax this time around and there wasn't a receptionist any more. "+artificialInt+" pings the building. Sir we've got  several individuals covering your exits and one inside this room. This is where he plans to make his stand. 'It's over.'");
            Console.WriteLine(@"
you get two options on this one. Turn the bastard in or let his ass rot on that floor. You ask GoalFinger : 'kill' or 'spare'");

            synth.Speak("kill or spare");
            String decisionFour = Console.ReadLine();


            if (decisionFour == "spare")
            {
                Console.WriteLine(@"
He was going to get his coming. There was no reason to limit any of the suffering and agony this scumbag is entitled to. 
You're coming with me. You've done enough harm, now let's see you do some good. GoalFinger reaches for the senator only to have the senator put a gun to his chest. 
Don't do this.. you've lost.. GoalFinger demands ");
                Console.WriteLine(@"
The final boss shoots GoalFinger in the chest. You've had no say in your destiny, 
the same as birth "+artificialInt+" thinks before accepting the bullet's penetration.. You feel nothing and see it all end in bang and a flash");
                thirty();
            }
            else if (decisionFour == "kill")
            {
                Console.WriteLine(@"
GoalFinger pulls out his silenced P9 without hesitation ready to deliver only to get a 
gun pulled on him almost instantaneously. The senator pulls a gun out and aims at GoalFingers chest. 
You take the bullet for him almost as if that were your entire purpose. GoalFinger retaliates. 'Too close', he thinks to himself.");
                thirty();
            }
            else
            {
                Console.WriteLine("---Error in input. Exact phrasing only please---");
                twentyNine();
            }
        }
        private void thirty()
        {
            Console.WriteLine(@"
GoalFinger connects a punch to the solar plexus and instantly places the garbage of a human in cuffs. 
GoalFinger touches his shirt pocket. Had "+artificialInt+" not been there he'd have been toast. I guess that machine never did fail me. It's a real shame, he though.\n Never would he feel so close and connected as he did with "+artificialInt+"");
            Console.WriteLine(@"
Desperately clinging to the one being he'd felt most intimate with GoalFinger 
chuckles and places "+artificialInt+" in his back pocket to send back to MI6");
            Console.WriteLine(@"
As the sirens begin to grow louder in the distance he steps forward and 
says to himself 'pathetic' squeezing the phone until his fists grew white.");
            thirtyOne();
        }
        private void thirtyOne()
        {
            Console.WriteLine(@"
This was just another day for our hero GoalFinger. The complexities of life and death seconds from one 
another and infinite in their results. GoalFinger would go on to continue doing justice and the expense of his own well being. 
This mission was one early in his career and only left in his own memory and the R.A.M. of a deceased friend.");

            synth.Speak("Rest in peace friend... beep boop beep");
            Console.ReadKey();
        }
    }
}