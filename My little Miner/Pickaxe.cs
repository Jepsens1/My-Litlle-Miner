
using System;
using System.Collections.Generic;
using System.Text;

namespace My_little_Miner
{
    //Enum of Raritys
    public enum PickaxeRarity
    {
        Wood,
        Stone,
        Iron,
        Gold,
        Diamond
    }
        
    class Pickaxe
    {
        //Property
        private PickaxeRarity typeOfPickaxe;

        public PickaxeRarity TypeOfPickaxe
        {
            get { return typeOfPickaxe; }
            set { typeOfPickaxe = value; }
        }
        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        private int attack;

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        //Constructor
        public Pickaxe(PickaxeRarity pickaxe)
        {
            TypeOfPickaxe = pickaxe;
            Health = health;
            Attack = attack;
        }



    }
}
