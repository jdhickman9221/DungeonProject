using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{
    public class Weapon
    {
        public int _minDamage;
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }//Okay, so here we are setting
            //the mindamage value by using the value keyword. And we are setting the value to be what
            //ever is lesser than or equal to MaxDamage. Anything else (which would be greater than or 
            //equal to would be MaxDamage. This is logic.
        }//end MinDamage

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            Name = name;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }//end ctor

        public override string ToString()
        {
            return string.Format($"{Name}\n Handle: {(!IsTwoHanded ? "Single-Handed" : "Two-Handed")}\nDamage Range: {MinDamage} - {MaxDamage}\nBonus Hit Chance:{BonusHitChance}");



        }//end Tostring.
    }
}
