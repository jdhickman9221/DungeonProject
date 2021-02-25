using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChaliceLibrary;
using MonstersLibrary;
using System.Threading;
namespace Chalice
{
    class Chalice
    {
        static void Main(string[] args)
        {
            Console.Title = "Chalice: Armegeddon";//name of console app.
            int playerScore = 0;//How many kills.
            int playerContinueCount = 0;//How many blood droplets until revive gain.
            int playerContinues = 0;//Total number of revives.

            //level 1 weapons
            Weapon demonClaws = new Weapon("Bare Demon Claws", 1, 6, 2, true);
            Weapon chainGun = new Weapon("Blessed Chain Gun", 1, 6, 1, true);
            Weapon sentinelGun = new Weapon("Sentinel Hand Cannon", 1, 6, 1, false);


            //level 2 weapons
            Weapon demonSword = new Weapon("Great Sword of Incendiary Realms", 1, 11, 4, true);
            Weapon rocket = new Weapon("Holy Rocket Launcher", 1, 11, 4, true);
            Weapon sentinelGuns = new Weapon("Dual-Arcane Hand Cannons", 1, 11, 4, true);


            //level 3 weapons
            Weapon demonSwords = new Weapon("Dual-Hellion Great Axes", 1, 15, 6, true);
            Weapon superShotgun = new Weapon("Holy Super Shotgun", 1, 15, 6, true);
            Weapon plasmaGun = new Weapon("Sentinel King's Plasma Cannon", 1, 15, 6, false);

            Weapon equippedWeapon = new Weapon("", 1, 1, 1, false);//creaing weapon that can be reassigned.
            Weapon[] startWeapon =
            {
                demonClaws, chainGun, sentinelGun, demonSword, rocket, sentinelGuns, demonSwords, superShotgun, plasmaGun
            };

            CharacterRace race = new CharacterRace();


            Console.WriteLine("Welcome, soul of bravity... You strap on the armor of legacy and enter an end world...\n" +
                "But yet, here you are, talking to a feeble old crone in a burial yard... Hahaha... Very odd.\n" +
                "Do you recall what the name and breed shall be written on YOUR headstone?\n" +
                "I would ask for you birthdate, but all that will be etched into these graves is the end year.\n" +
                "This year. Like the countless that have fallen before you.\n\n" +
                "Enter Hero Name:");
            string playerName = Console.ReadLine();
            Console.Clear();

            bool validRace = false;
            do
            {
                Console.WriteLine("Choose your breed:\n" +
                    "N) Nephalim (difficulty: easy)\n " +
                    "Nephalim: Part Angel. Part Demon. Perfect hellion adversary.\n\n" +
                    $"Starter Weapon: {chainGun.Name}\n\n" +
                    "S) Sentinel (difficulty: medium)\n Sentinel: A warrior race, mysteriously arrived the same time as \n" +
                    "the current plight. " +
                    "For those who enjoy a balanced experience. Trained warriors only.\n\n" +
                    $"Starter Weapon: {sentinelGun.Name}\n\n" +
                    "H) Hellion (difficulty: hard)\n Demon: Fallen one... Renegade...\n" +
                    "Those who fight against hellions to create the rule of their own kind.\n\n" +
                    $"Starter Weapon:{demonClaws.Name}\n\n" +
                    "Ruling always comes with a price.");
                ConsoleKey raceChoice = Console.ReadKey().Key;
                Console.Clear();
                switch (raceChoice)
                {
                    case ConsoleKey.N:
                        race = CharacterRace.Nephalim;
                        equippedWeapon = chainGun;
                        playerContinues++;
                        playerContinues++;
                        validRace = true;
                        break;

                    case ConsoleKey.S:
                        race = CharacterRace.Sentinel;
                        equippedWeapon = sentinelGun;
                        playerContinues++;
                        validRace = true;
                        break;

                    case ConsoleKey.H:
                        race = CharacterRace.Hellion;
                        equippedWeapon = demonClaws;
                        validRace = true;
                        break;

                    default:
                        Console.WriteLine("That was not a valid choice.");
                        break;
                }
            } while (!validRace);
            Player playerBuild = new Player(playerName, 20, 20, 10, 5, 10, race, equippedWeapon);



            bool response1 = false;
            do
            {
                Console.WriteLine($"{playerName} is it? Aye, tis you. I remember this name in a dream. \n" +
                    $"Will you.\n" +
                    $"Brave one.\n" +
                    $"Be the one to reduce the demon hordes so Earth can have a fighting chance?\n" +
                    $"Y) Yes\n" +
                    $"N) No\n" +
                    $"X) Nod Head and Say Nothing");
                ConsoleKey playerResponse1 = Console.ReadKey().Key;
                Console.Clear();
                switch (playerResponse1)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine($"Aye. I give you my blessing, for what it's worth, {playerName} the {race}.\nI am only referred to as The Betrayer. You do what I cannot hero.\nFor my cowardice has led me to abandon battle.\nMy curse now: being among those who bury the remains of those who I could not fight for.\nDo not let me keep you. There is a battle to be fought.\nThis world, whats left of it... depends on the bravity of those bold enough.");
                        Console.ReadLine();
                        response1 = true;
                        break;

                    case ConsoleKey.N:
                        Console.WriteLine($"Aye, I may have been mistaken. {playerName} the {race}.\nMaybe you're not the one from my dream.\nI am only referred to as The Betrayer.\nEven though you have no hope in self, you do what I cannot hero.\nFor my cowardice has led me to abandon battle.\nMy curse now: being among those who bury the remains of those who I could not fight for.\nDo not let me keep you. There is a battle to be fought.\nThis world, whats left of it... depends on the bravity of those bold enough.");
                        Console.ReadLine();
                        response1 = true;
                        break;

                    case ConsoleKey.X:
                        Console.WriteLine($"...Not a talker aye {playerName} the {race}? We shall see what your battle brings us.\nI am only referred to as The Betrayer.\nYou must do what I cannot hero. For my cowardice has led me to abandon battle.\nMy curse now: being among those who bury the remains of those who I could not fight for.\nDo not let me keep you. There is a battle to be fought.\nThis world, whats left of it... depends on the bravity of those bold enough.");
                        Console.ReadLine();
                        response1 = true;
                        break;
                    default:
                        Console.WriteLine("Aye, did you hear me? Give me your eyes while I am talking.");
                        break;
                }//endswitch


            } while (!response1);

            Console.Clear();
            Console.WriteLine($"CHALICE\nArise, {playerName} the {race}. Nearly 60% of the planet has been\n" +
                    $"consumed by the demons, increasing in number by the day.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nearly every man made system has faced catastrophic failure.\n" +
                "Mankind's military response was immediate but only slightly effective...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Many factions remain in safe zones, but have all but been cut off" +
                " from communications.\nFacing overwhelming opposition, these safe zones have been overtaken" +
                "by the growing\ndemonic presence one after another. Earth is becoming uninhabitable.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("With swarms of demons scouting the globe... and most regions suffering " +
                "from an atmosphere \nthat has become infected and poisonous by process of some form of" +
                "demonic terraformation....\n" +
                "Such is the will of the Hellion Priests.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your fight begins here. Fight back these demon hordes and claim victory\n" +
                "over the Hellion Priests.\n" +
                "Keep your chalice filled with Adversary Blood.... Or die trying....");
            Console.ReadLine();
            Console.Clear();
            string chaliceLogo = @"
         _____  _   _   ___   _     _____ _____  _____        ___  ______ ________  ___ _____ _____  _________________ _____ _   _ 
        /  __ \| | | | / _ \ | |   |_   _/  __ \|  ___|  _   / _ \ | ___ \  ___|  \/  ||  ___|  __ \|  ___|  _  \  _  \  _  | \ | |
        | /  \/| |_| |/ /_\ \| |     | | | /  \/| |__   (_) / /_\ \| |_/ / |__ | .  . || |__ | |  \/| |__ | | | | | | | | | |  \| |
        | |    |  _  ||  _  || |     | | | |    |  __|      |  _  ||    /|  __|| |\/| ||  __|| | __ |  __|| | | | | | | | | | . ` |
        | \__/\| | | || | | || |_____| |_| \__/\| |___   _  | | | || |\ \| |___| |  | || |___| |_\ \| |___| |/ /| |/ /\ \_/ / |\  |
         \____/\_| |_/\_| |_/\_____/\___/ \____/\____/  (_) \_| |_/\_| \_\____/\_|  |_/\____/ \____/\____/|___/ |___/  \___/\_| \_/
                                                                                                  
                                                                           
                                         _ __  _ __ ___  ___ ___    ___ _ __ | |_ ___ _ __ 
                                        | '_ \| '__/ _ \/ __/ __|  / _ \ '_ \| __/ _ \ '__|
                                        | |_) | | |  __/\__ \__ \ |  __/ | | | ||  __/ |   
                                        | .__/|_|  \___||___/___/  \___|_| |_|\__\___|_|   
                                        |_|                                                
                                      

";
            Console.WriteLine(chaliceLogo);
            Console.ReadLine();
            Console.Clear();
            string levelOne = @"
                                             _                _                    
                                            | |              | |                   
                                            | | _____   _____| |   ___  _ __   ___ 
                                            | |/ _ \ \ / / _ \ |  / _ \| '_ \ / _ \
                                            | |  __/\ V /  __/ | | (_) | | | |  __/
                                            |_|\___| \_/ \___|_|  \___/|_| |_|\___|                                                                              
";
            Console.WriteLine(levelOne);
            Console.ReadLine();
            Console.Clear();
            ///////////////////////////////////////////entering the game loop///////////////////////////////////////////////////
            bool exit = false;

            do
            {
                //monsters
                #region 
                Monster arachnotron = new Monster("Arachno-tron", 5, 5, 10, 0, 15, 5, 5, "Deadly spider demon built with genetic material recovered from the remains.\n" +
                    "Bio-engineered for cyber-augmentation and armed with a pulse cannon mounted to it's back.");

                Monster dreadKnight = new Monster("Dread Knight", 3, 3, 10, 5, 20, 10, 25, "As a result of its augmentation, the Dread Knight is driven by a biochemically engineered state of pure, unbroken rage.\n" +
                    "A suffering for which respite can only be found in the act of the kill.\n" +
                    "A hulking towering 7 foot demon, armed with two blade prothetics protruding from it's forearms.");

                Monster revenant = new Monster("Skeletal Revenant", 5, 5, 10, 15, 5, 5, 5, "The revenant, a bio-weapon using re-animated necrotic human tissue. Modified for a rocket payload launched from two shoulder mounted cannons.");

                Monster marauder = new Monster("Marauder", 5, 5, 10, 15, 5, 5, 5, "An elite guardian. A hardened warrior. Nemisis to the Sentinel race. Led by exhaulted cultists.\n" +
                    "Marauders are a deadly mix of combat savy and agile.\n" +
                    "Wielding an axe and super shotgun. Expect interchaning attacks.");

                Monster mancubus = new Monster("Mancubus", 5, 5, 10, 15, 5, 5, 5, "A hulking flesh pile, although slow, bearing two flame thrower cannons on it's wrists.\n" +
                    "Cybernetic modifications made its mobility even possible.\n" +
                    "It specializes in ranged attacks.");
                
                Monster[] monsters =
                {
                   dreadKnight, revenant, marauder, mancubus, arachnotron
                };
                Monster monster = monsters[new Random().Next(monsters.Length)];
                #endregion 
                

                Console.WriteLine(Room.GetRoom());
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"A {monster.Name} glares you down!");
                Console.ReadLine();
                Console.ResetColor();

                bool reloadLvl1Room = false;//condition for entering lvl 1

                do
                {
                    Console.WriteLine("\nChoose an action:\n" +
                        "A)ttack\n" +
                        "F)lee\n" +
                        "P)layer Stats\n" +
                        "M)onster Stats\n" +
                        "Esc) to exit");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.Battle(playerBuild, monster);
                            if (monster.Life < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{monster.Name} is annhilated by your {equippedWeapon.Name}!");
                                Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("+1 Adversary Blood Droplet.\n" +
                                    "A little demonic blood is collected into your chalice.");
                                Console.ReadLine();
                                playerScore++;
                                playerContinueCount++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Demons Vanquished: {playerScore}\n" +
                                    $"Adversary Blood Droplets: {playerContinueCount}\n" +
                                    $"Chalice Revives: {playerContinues}");
                                Console.ReadLine();
                                Console.Clear();
                                reloadLvl1Room = true;
                                Console.ResetColor();
                                if (playerContinueCount == 7)
                                {
                                    playerContinues++;
                                    playerContinueCount = 0;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Your chalice is full of adversary blood.\n" +
                                        "When in mortal danger, drink it's contents...");                                                                       
                                }
                            }
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine($"Threatened you attempt escape, {monster.Name} lashes at you!");
                            Combat.Attack(monster, playerBuild);
                            #region
                            Console.Beep(600, 30);
                            Thread.Sleep(35);
                            Console.Beep(300, 30);
                            Thread.Sleep(35);
                            Console.Beep(150, 30);
                            Thread.Sleep(35);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            #endregion
                            Console.WriteLine("Check player stats to access damages...");
                            Console.ReadLine();
                            reloadLvl1Room = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine(playerBuild);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You've given up on Earth...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("You haven't chosen an option that is available to you.\n");
                            break;
                    }//end switch player choice


                    if (playerBuild.Life < 1)
                    {
                        Console.WriteLine($"You have been annihilated.\n");
                        Console.Clear();
                        if (playerContinues > 0)
                        {
                            playerContinues--;
                            //Healing green flash effect.
                            Console.ReadLine();
                            Console.ResetColor();
                            Console.Clear();
                            Console.Beep(250, 30);
                            Thread.Sleep(35);
                            Console.Beep(500, 30);
                            Thread.Sleep(35);
                            Console.Beep(1000, 30);
                            Thread.Sleep(35);
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Thread.Sleep(30);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ResetColor();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You drink all the contents of your chalice and it revives you.");
                            Console.ReadLine();
                            Console.ResetColor();
                            playerBuild.Life = playerBuild.MaxLife;
                        }
                        else
                        {
                            exit = true;
                        }
                    }//end if player dies
                     ///////////////////////permission to enter scene///////////////////////
                    if (playerScore == 3)
                    {

                        playerScore++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("You stumble into a dimly lit room.\n");
                        Console.ReadLine();
                        Console.WriteLine("Your clumsiness led you to trip over a single clothed skeleton.\n");
                        Console.ReadLine();
                        Console.WriteLine("You notice that the skeleton has a journal tightly gripped,\n");
                        Console.WriteLine("Cradled close to it's chest.\n");
                        Console.ReadLine();
                        Console.WriteLine("Fighting the stuck nature of the skeleton,\n");
                        Console.WriteLine("you pry back it's arms, crumbling some of it's old bones in the process.");
                        Console.ReadLine();
                        Console.WriteLine("Finally freed from the skeleton's arms, the cover,\n");
                        Console.WriteLine("crudely scribbled with sharpie reads:");
                        Console.WriteLine("CODING FOR DUMMIES.\n");
                        Console.Clear();
                        Console.WriteLine("You open the front cover, written again in sharpie reads:\n");
                        Console.WriteLine("Property of Jordan Hickman - Web Developer.\n");
                        Console.WriteLine("As you opened the cover,\n" +
                            "an I.D. key card of the Web Developer falls out.");
                        Console.ReadLine();
                        Console.WriteLine("Poor soul... Must have belonged to this sad and mangled corpse.\n");
                        Console.ReadLine();
                        Console.WriteLine("...odd. You decide to keep this journal on your person... Just in case?");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        playerContinueCount += 2;
                        Console.WriteLine();
                        Console.WriteLine("The Corpse of the Web Developer left behind: +14 Adversary Blood Droplets.\n" +
                                   "Demonic blood is collected into your chalice.");
                        reloadLvl1Room = true;
                        Console.Clear();
                    }//end if
                    if (playerScore == 6)
                    {

                        playerBuild.Life = playerBuild.MaxLife;
                        Console.WriteLine("Your life has been restored...");
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("You find a room with a large Computer Monitor mounted to the wall.");
                        Console.ReadLine();
                        Console.WriteLine("An office chair is turned away from a desk with a single keyboard.\n");
                        Console.ReadLine();
                        Console.WriteLine("It looks like someone got up in a hurry.\n");
                        Console.ReadLine();
                        Console.WriteLine("There is a I.D. card scanner on the desk and\n" +
                            "you decide to scan the I.D. card you found.");
                        Console.ReadLine();
                        Console.WriteLine("The monitor suddenly turns on... A demonic face filling the screen.\n");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"GREETINGS {playerName} the {race}!\n");
                        Console.WriteLine($"YOU KILL {playerScore} MY HELLIONS WITH JUST A {equippedWeapon.Name}?! ");
                        Console.ReadLine();
                        Console.WriteLine("YOU HAVE BECOME QUITE THE FOE...");
                        Console.WriteLine("SO I LOCKED THE DOOR TO THIS ROOM YOU'VE ENTERED!");
                        Console.ReadLine();
                        Console.WriteLine("I HAVE A NEW CHALLENGE FOR YOU HERO...");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The demonic face shrouded by a shadowy hood, but red beaming\n");
                        Console.WriteLine("eyes are the only thing seen floating with where a face should be.\n");
                        Console.ReadLine();
                        Console.WriteLine("This is no doubt... a Hellion Priest!!!\n");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("With it's lout distorted boomy voice, it speaks again.\n");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("A CODING CHALLENGE! I DO LOVE A GOOD OPPONENT, AS DO ALL HELLION PRIESTS!");
                        Console.ReadLine();
                        Console.WriteLine("ANSWER 3 CODING QUESTIONS TO BEAT ME!\n" +
                            "I WILL ALTER THIS EARTH EVERY TIME YOU CHOOSE INCORRECTLY!\n");
                        Console.ReadLine();
                        Console.WriteLine($"DO NOT WORRY {race} I HAVE MADE IT FAIR!\n");
                        Console.ReadLine();
                        Console.WriteLine("FOR EVERY RIGHT ANSWER I'VE SET ONE OF MY REACTORS TO EXPLODE!\n");
                        Console.ReadLine();
                        Console.WriteLine("HELLION PRIESTS LOVE CHALLENGING WORTHY FOE...\n");
                        Console.ReadLine();
                        Console.WriteLine("CHOOSE WISELY!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("An Evil cackle shudders out of it's now visable mandibles...");
                        Console.ReadLine();
                        Console.WriteLine("...What a hideous creature...");
                        Console.ResetColor();
                        Console.Clear();

                        bool validAnswer1 = false;
                        do
                        {

                            Console.WriteLine("\nHellion Boss 1: C#\n" +
                            "What code do you need to write on the second line to get a random int from 0 to 10?\n\n" +
                            "A) int nbr = rand.next(11);\n" +
                            "B) Int nbr = rand.Next(10);\n" +
                            "C) int nbr = rand.next(10);\n" +
                            "D) int nbr = rand.Next(11);\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice1 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice1)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest raises a random graveyard from the dead!");
                                    Console.ReadLine();
                                    validAnswer1 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest evaporates a body of recycled drinking water!");
                                    Console.ReadLine();
                                    validAnswer1 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest rains hellfire onto a random city block!");
                                    Console.ReadLine();
                                    validAnswer1 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region                                
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion 
                                    validAnswer1 = true;
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You cannot escape this battle.");
                                    Console.ResetColor();
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    Console.ResetColor();
                                    validAnswer1 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer1 == false);//do while
                                                        /////////////////////////////End question 1////////////////////////////
                        bool validAnswer2 = false;
                        do
                        {

                            Console.WriteLine("\nHellion Boss 1: C#\n" +
                            "What is a constructor?\n\n" +
                            "A) A specialized method used to create objects of a specific type\n" +
                            "B) A generic method used to create objects of a generic type.\n" +
                            "C) An object used to create methods of a specific type.\n" +
                            "D) A specialized object created by a specific method.\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice1 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice1)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
#endregion
                                    validAnswer2 = true;
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest summons Slimer from Ghostbusters!");
                                    Console.ReadLine();
                                    validAnswer2 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest Crashes the stock market!");
                                    Console.ReadLine();
                                    validAnswer2 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest rains hellfire onto a random city block!");
                                    Console.ReadLine();
                                    validAnswer2 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer1 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer2 == false);//do while

                        bool validAnswer3 = false;
                        do
                        {
                            string Question3 = @"
                            bool leave = false;
                            do
                            {
                                   //update
                            } while (!leave);
";
                            Console.WriteLine($"\nHellion Boss 1: C#\n" +
                           " What code will you need to write for the update to cause the loop to stop ?\n" +
                           Question3);

                            Console.WriteLine("" +
                            "A) bool leave = false;\n" +
                            "B) bool leave = true;\n" +
                            "C) leave = true;\n" +
                            "D) leave = false;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice1 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice1)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest okay's another SpiderMan Reboot!");
                                    Console.ReadLine();
                                    validAnswer3 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer3 = true;
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer3 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer3 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer3 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer3 == false);//do while
                        playerContinueCount++;//killed boss
                        playerScore++;
                        Console.WriteLine("A false wall opens up revealing a chest: +7 Adversary Blood Droplets.\n" +
                                   "Demonic blood is collected into your chalice.");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (race == CharacterRace.Sentinel)
                        {
                            equippedWeapon = sentinelGuns;
                        }
                        if (race == CharacterRace.Nephalim)
                        {
                            equippedWeapon = rocket;
                        }
                        else
                        {
                            equippedWeapon = demonSword;
                        }
                        Console.WriteLine($"Inside the chest you you also find:\n" +
                            $"{equippedWeapon}!\n\n\n{equippedWeapon.Name} is now equipped.");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        string levelTwo = @"
                                             _                _   _                 
                                            | |              | | | |                
                                            | | _____   _____| | | |___      _____  
                                            | |/ _ \ \ / / _ \ | | __\ \ /\ / / _ \ 
                                            | |  __/\ V /  __/ | | |_ \ V  V / (_) |
                                            |_|\___| \_/ \___|_|  \__| \_/\_/ \___/ 
";
                        Console.WriteLine(levelTwo);
                        Console.ReadLine();
                        Console.Clear();
                        reloadLvl1Room = true;
                    }//end if boss
                    if (playerScore == 20)
                    {

                        playerBuild.Life = playerBuild.MaxLife;
                        Console.WriteLine("Your life has been restored...");
                        Console.Clear();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("You find ANOTHER room with a large Computer Monitor mounted to the wall.");
                        Console.ReadLine();
                        Console.WriteLine("An office chair is turned away from a desk with a single keyboard.\n");
                        Console.ReadLine();
                        Console.WriteLine("It looks like someone got up in a hurry. Wait...\n");
                        Console.ReadLine();
                        Console.WriteLine("You wonder if that Web Developer guy you found dead was battling these\n" +
                            "Hellion Preists all alone... His I.D. key card DOES unlock the consoles...");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("There is a I.D. card scanner on the desk and\n" +
                            "you decide to scan the I.D. card you found.");
                        Console.ReadLine();
                        Console.WriteLine("Another demonic face filling the screen.\n");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"YOU WILL PAY FOR THIS!\n");
                        Console.WriteLine($"YOU KILL OFF ONE OF US HELLION PRIESTS! ");
                        Console.ReadLine();
                        Console.WriteLine("YOU HAVE BECOME QUITE THE FOE...");
                        Console.WriteLine("SO I LOCKED THE DOOR TO THIS ROOM YOU'VE ENTERED!");
                        Console.ReadLine();                       
                        Console.WriteLine("A CODING CHALLENGE! THIS TIME ABOUT FRONT END DEVELOPMENT!");
                        Console.ReadLine();
                        Console.WriteLine("ANSWER 7 CODING QUESTIONS TO BEAT ME!\n" +
                            "I WILL ALTER THIS EARTH EVERY TIME YOU GET ONE WRONG!\n");
                        Console.ReadLine();
                        Console.WriteLine($"DO NOT WORRY {race} I HAVE MADE IT FAIR!\n");
                        Console.ReadLine();
                        Console.WriteLine("FOR EVERY RIGHT ANSWER I'VE SET ONE OF MY REACTORS TO EXPLODE!\n");
                        Console.ReadLine();
                        Console.WriteLine("HELLION PRIESTS LOVE CHALLENGING WORTHY FOE...\n");
                        Console.ReadLine();
                        Console.WriteLine("CHOOSE WISELY!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("An Evil cackle shudders out of it's now visable mandibles...");
                        Console.ReadLine();
                        Console.WriteLine("...What a hideous creature...");
                        Console.ResetColor();
                        Console.Clear();

                        bool validAnswer4 = false;
                        do
                        {

                            Console.WriteLine("\nHellion Boss 2: Front End Development\n" +
                            "At its most basic level, a website is what?\n\n" +
                            "A) HTML files;\n" +
                            "B) A folder with files;\n" +
                            "C) Scripts;\n" +
                            "D) Layouts;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice4 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice4)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest raises a random graveyard from the dead!");
                                    Console.ReadLine();
                                    validAnswer4 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region                                
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion 
                                    validAnswer4 = true;
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest rains hellfire onto a random city block!");
                                    Console.ReadLine();
                                    validAnswer4 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest rains hellfire onto a random city block!");
                                    Console.ReadLine();
                                    validAnswer4 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You cannot escape this battle.");
                                    Console.ResetColor();
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    Console.ResetColor();
                                    validAnswer4 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer4 == false);//do while
                                                        /////////////////////////////End question 1////////////////////////////
                        bool validAnswer5 = false;
                        do
                        {

                            Console.WriteLine("\nHellion Boss 2: Front End Development\n" +
                            "The highest level parent folder for a project is the _____ folder.\n\n" +
                            "A) Solution\n" +
                            "B) Root\n" +
                            "C) Index\n" +
                            "D) Home\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice5 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice5)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest Crashes the stock market!");
                                    Console.ReadLine();
                                    validAnswer5 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer5 = true;
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest Crashes the stock market!");
                                    Console.ReadLine();
                                    validAnswer5 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest rains hellfire onto a random city block!");
                                    Console.ReadLine();
                                    validAnswer5 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer5 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer5 == false);//do while

                        bool validAnswer6 = false;
                        do
                        {                           
                            Console.WriteLine($"\nHellion Boss 2: Front End Development\n" +
                           "Which of the following is NOT an advantage to using Source Control? \n");

                            Console.WriteLine("" +
                            "A) Remote Back Up;\n" +
                            "B) Multiple Developers Can Work At The Same Time;\n" +
                            "C) Long Term Change History;\n" +
                            "D) Easier To Deploy A Website;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice6 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice6)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest okay's another SpiderMan Reboot!");
                                    Console.ReadLine();
                                    validAnswer6 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer6 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer6 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer6 = true;
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer6 = false;
                                    break;
                            }//end switch player choice  
                            

                        } while (validAnswer6 == false);//do while

                        bool validAnswer7 = false;
                        do
                        {                            
                            Console.WriteLine($"\nHellion Boss 2: Front End Development\n" +
                           " This Git operation saves a copy of changes to the local repository.\n");

                            Console.WriteLine("" +
                            "A) Commit;\n" +
                            "B) Push;\n" +
                            "C) Pull = true;\n" +
                            "D) Branch = false;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice7 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice7)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();                                    
                                    #endregion
                                    validAnswer7 = true;
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer7 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer7 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer7 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer7 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer7 == false);//do while

                        bool validAnswer8 = false;
                        do
                        {
                            Console.WriteLine($"\nHellion Boss 2: Front End Development\n" +
                           "This Git operation brings down a copy of the source code\n" +
                           "from the remote repo and automatically merges\n" +
                           "the updated version into the local repo.\n");

                            Console.WriteLine("" +
                            "A) Commit;\n" +
                            "B) Push;\n" +
                            "C) Pull;\n" +
                            "D) Branch;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice8 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice8)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest okay's another SpiderMan Reboot!");
                                    Console.ReadLine();
                                    validAnswer8 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer8 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer8 = true;
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer8 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer8 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer8 == false);//do while

                        bool validAnswer9 = false;
                        do
                        {
                            Console.WriteLine($"\nHellion Boss 2: Front End Development\n" +
                           "In which tier of full stack development would you use HTML?\n");
                           

                            Console.WriteLine("" +
                            "A) Middle End;\n" +
                            "B) Front Tier;\n" +
                            "C) Front End;\n" +
                            "D) Back Tier;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice9 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice9)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest okay's another SpiderMan Reboot!");
                                    Console.ReadLine();
                                    validAnswer9 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer9 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer9 = true;
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest writes a nasty review on Yelp about you!");
                                    Console.ReadLine();
                                    validAnswer9 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer9 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer9 == false);//do while

                        bool validAnswer10 = false;
                        do
                        {                          
                            Console.WriteLine($"\nHellion Boss 2: Front End Development\n" +
                           "What protocol or protocols are the communication\n" +
                           "standard between browsers and servers?\n"); 
                           

                            Console.WriteLine("" +
                            "A) DSN, HTTP;\n" +
                            "B) FTP, IMAP;\n" +
                            "C) HTTPS, FTP;\n" +
                            "D) HTTP, HTTPS;\n" +
                            "E) Current Life\n" +
                            "Esc) to exit");
                            ConsoleKey userChoice10 = Console.ReadKey().Key;
                            Console.Clear();

                            switch (userChoice10)
                            {
                                case ConsoleKey.A:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest okay's another SpiderMan Reboot!");
                                    Console.ReadLine();
                                    validAnswer6 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.B:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer10 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.C:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    playerBuild.Life = playerBuild.Life - 5;
                                    Console.WriteLine("Incorrect answer. Hellion Priest deleted the CyberPunk 2077 source code!\n" +
                                        "Now it will never be fixed!");
                                    Console.ReadLine();
                                    validAnswer10 = false;
                                    Console.ResetColor();
                                    break;

                                case ConsoleKey.D:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You have chosen correct!");
                                    Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOUR BUTTON TRIGGERS AN EXPLOSION! It harms the Hellion Priest!");
                                    Console.ReadLine();
                                    #region 
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    Console.Beep(900, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(600, 50);
                                    Thread.Sleep(50);
                                    Console.Beep(300, 50);
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.Clear();
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Thread.Sleep(50);
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.ResetColor();
                                    #endregion
                                    validAnswer10 = true;
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine($"Life:{playerBuild.Life}");

                                    Console.ResetColor();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.WriteLine("You cannot escape this boss battle.");
                                    break;

                                default:
                                    Console.WriteLine("You haven't chosen an option that is available to you.\n");
                                    validAnswer10 = false;
                                    break;
                            }//end switch player choice                           
                        } while (validAnswer10 == false);//do while

                        playerContinueCount++;
                        Console.WriteLine("A false wall opens up revealing a chest: +7 Adversary Blood Droplets.\n" +
                                   "Demonic blood is collected into your chalice.");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (race == CharacterRace.Sentinel)
                        {
                            equippedWeapon = sentinelGuns;
                        }
                        if (race == CharacterRace.Nephalim)
                        {
                            equippedWeapon = rocket;
                        }
                        else
                        {
                            equippedWeapon = demonSword;
                        }
                        Console.WriteLine($"Inside the chest you you also find:\n" +
                            $"{equippedWeapon}!\n\n\n{equippedWeapon.Name} is now equipped.");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        string levelTwo = @"
                                             _                _   _                 
                                            | |              | | | |                
                                            | | _____   _____| | | |___      _____  
                                            | |/ _ \ \ / / _ \ | | __\ \ /\ / / _ \ 
                                            | |  __/\ V /  __/ | | |_ \ V  V / (_) |
                                            |_|\___| \_/ \___|_|  \__| \_/\_/ \___/ 
";
                        Console.WriteLine(levelTwo);
                        Console.ReadLine();
                        Console.Clear();
                        reloadLvl1Room = true;
                    }//end if boss
                } while (reloadLvl1Room != true && exit != true);
            } while (exit != true);
            Console.WriteLine($"You killed {playerScore} demons{(playerScore == 1 ? "" : "s")}.");
            Console.WriteLine("GAME OVER");

        }//end Main()
    }//end Chalice Class
}//end Namespace
