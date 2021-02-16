using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{
    class Player : Character
    {
        public CharacterRace Race { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int life, int maxLife, int hitChance, int block, int speed, CharacterRace race, Weapon equippedWeapon) : base(name, life, maxLife, hitChance, block, speed)
        {
            Race = race;
            EquippedWeapon = equippedWeapon;

            switch (race)
            {
                case CharacterRace.Demon://TODO: make these races like it would be easy, intermediate, hard
                    MaxLife += 100;
                    Life += 100;
                    Block += 40;
                    HitChance += 6;
                    Speed += 3;
                    break;

                case CharacterRace.Nephalim:
                    MaxLife += 130;
                    Life += 130;
                    Block += 20;
                    HitChance += 4;
                    Speed += 9;
                    break;

                case CharacterRace.Sentinel:
                    MaxLife += 150;
                    Life += 150;
                    Block += 10;
                    HitChance += 4;
                    Speed += 9;
                    break;
            }
        }//end ctor

        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {Race}\n {Life} of {MaxLife}\nHit Chance:" +
                $" {(CalcHitChance())}%\nBlock Chance: {Block}%\nEquipped Weapon: {EquippedWeapon}");
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance; //this is race's hit chance plus the bonus
            //of the weapon.
        }//end Calc HitChance Override.

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;//here we want the battle sequence to calculate a random number of damage based
            //on range of min/max damage that the weapon stats provide, +1 on max damage because the max 
            //is exclusive.
        }//end CalcDamage Override.

    
        
    }
}
