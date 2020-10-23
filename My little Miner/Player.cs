using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_little_Miner
{
    class Player
    {
        //Property
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        private Pickaxe myPickaxe;

        public Pickaxe MyPickaxe
        {
            get { return myPickaxe; }
            set { myPickaxe = value; }
        }
        private List<Mineral> backpack;

        public List<Mineral> Backpack
        {
            get { return backpack; }
            set { backpack = value; }
        }
        private int money;

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        //Constructor
        public Player(string name, Pickaxe myPickaxe)
        {
            Name = name;
           
            MyPickaxe = myPickaxe;
            Backpack = new List<Mineral>();
            Money = 0;
        }
        //Method to show Inventory from when you were mining
      public string ShowInventory()
        {
            string temp = "";
            
            for (int i = 0; i < Backpack.Count; i++)
            {

               temp += FormatEnum(Backpack[i].TypeOfMineral) + " " + Backpack[i].Stage + "\n";
            }
                return temp;
            
            
            
        }
        //Formating enum to string
        private string FormatEnum(MineralRarity mineralsrare)
        {
            switch (mineralsrare)
            {
                case MineralRarity.Stone:
                    break;
                case MineralRarity.Coal:
                    break;
                case MineralRarity.Iron:
                    break;
                case MineralRarity.Gold:
                    break;
                case MineralRarity.Diamond:
                    break;
                case MineralRarity.Sapphire:
                    break;
                case MineralRarity.Ruby:
                    break;

            }
            return mineralsrare.ToString();
        }
    }
}
