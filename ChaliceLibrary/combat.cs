using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{
    public class combat
    {
        public static void Attack (Character attacker, Character defender)//here we call upon the parent class of monster and player, 
            //we will then write the combat sequences.
        {

            //we want to randomly generate hits, damages with a new random.
            Random diceRoll = new Random();
            int result = diceRoll.Next(1, 101);
            //.Next to grab an int within specified range, which whill simulate the random. Also bc its based off time. So 
            // we need a system.threading.thread.sleep(ms);
            System.Threading.Thread.Sleep(35);
            if (result <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();// so CalcDamage() has two meanings based off player or monster, rules are
                //written differently. monster is MaxDamage and MinDamage ranges, player is a random range which is parameterized
                //by Weapon min damage and weapon max damage +1 because its exclusive upper bound.
                
                defender.Life -= damageDealt;//beacuse we are dealing with character class in this, we can use the base inheritence 'life'
                //as part of our operation. This operation reassigns the life of the defender character by subtraction. 
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end Attack()

        public static void BattleInstance(Player player, Monster monster)
        {
            Random speedRoll = new Random();//here we are actually using the speed parameter of the character class.
            int playerSpeed = speedRoll.Next(1, 11) + player.Speed;//here we are creating a new var of player, which is operating
            //on a new random which ranges are between 1 - 10 + what ever the player speed is. 
            System.Threading.Thread.Sleep(25);
            int monsterSpeed = speedRoll.Next(1, 11) + monster.Speed;
            Console.WriteLine($"{(playerSpeed >= monsterSpeed ? $"{player.Name}" : $"{ monster.Name}")}  attacks first!");
            if (playerSpeed >= monsterSpeed)
            {
                Attack(player, monster);//here we are getting attacker to be player child. 
                if (monster.Life > 0)
                {
                    Attack(monster, player);
                }//end 
            }//end if player attacks first
            else
            {
                Attack(monster, player);
                if (player.Life > 0)
                {
                    Attack(player, monster);
                }
            }//end else monster attacks first

        }
    }
}
