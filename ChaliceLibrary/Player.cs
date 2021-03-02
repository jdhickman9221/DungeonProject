using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{
    public class Player : Character
    {
        public CharacterRace Race { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int life, int maxLife, int hitChance, int block, int speed, CharacterRace race, Weapon equippedWeapon) : base(name, life, maxLife, hitChance, block, speed)
        {
            Race = race;
            EquippedWeapon = equippedWeapon;

            switch (race)
            {
                case CharacterRace.Hellion://TODO: make these races like it would be easy, intermediate, hard
                    MaxLife += 25;
                    Life += 25;
                    Block += 4;
                    HitChance +=5 ;
                    Speed += 5;                                        
                    break;

                case CharacterRace.Nephalim:
                    MaxLife += 45;
                    Life += 45;
                    Block += 6;
                    HitChance += 10;
                    Speed += 7;                                       
                    break;

                case CharacterRace.Sentinel:
                    MaxLife += 35;
                    Life += 35;
                    Block += 5;
                    HitChance += 6;
                    Speed += 6;                                       
                    break;
                case CharacterRace.DoomGuy:
                    MaxLife += 45;
                    Life += 45;
                    Block += 6;
                    HitChance += 20;
                    Speed += 20;
                    break;
            }
        }//end ctor

        public override string ToString()
        {
            return string.Format($"{Name}\nRace: {Race}\nLife {Life} of {MaxLife}\nHitChance: {(CalcHitChance())}%\n" +
                $"Block Chance: {Block}%\n" +
                $"Equipped Weapon: {EquippedWeapon}");
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
    }
}
