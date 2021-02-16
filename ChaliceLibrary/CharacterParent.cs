using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaliceLibrary
{   //MaxLife int, HitChance int, Defense int, Speed int, Name string, life int.
    public abstract class Character
    {
        private string _name;
        private int _life;

        public int MaxLife { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int Speed { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value.Trim(); }//here we return the value of _name, but we assigned the value
            //based on user input and we trimmed for whitespace.
        }//end Name property

        public int Life
        {
            get { return _life; }
            set { _life = value <= MaxLife ? value : MaxLife; }//here life is given value by an int
            //is value less than max life, then its current life. If not then its at its maximum.
        }// end life property

        //ctors
        public Character(string name, int life, int maxLife, int hitChance, int block, int speed)
        {
            MaxLife = MaxLife;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            Speed = speed;
        }//end ctor

        public virtual int CalcBlock()//The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. For example, this method can be overridden by any class that inherits it
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public abstract int CalcDamage();//remember abstract classes are meant to be forced to be 
                                         //completed by the class that enherits it. 
    }

}
