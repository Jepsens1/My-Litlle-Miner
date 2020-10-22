using System;
using System.Collections.Generic;
using System.Text;

namespace My_little_Miner
{
    //Enum of raritys
    public enum MineralRarity
    {
        Stone,
        Coal,
        Iron,
        Gold,
        Diamond,
        Sapphire,
        Ruby
    }
    public enum Stage
    {
        Refined,
        Raw
    }
    class Mineral
    {
        //Propertys
        private MineralRarity typeOfMineral;

        public MineralRarity TypeOfMineral
        {
            get { return typeOfMineral; }
            set { typeOfMineral = value; }
        }
        private Stage stage;

        public Stage Stage
        {
            get { return stage; }
            set { stage = value; }
        }



        private float money;

        public float Money
        {
            get { return money; }
            set { money = value; }
        }
       

        public Mineral(MineralRarity mineral)
        {
            typeOfMineral = mineral;
            
            Money = money;
            Stage = Stage.Raw;
           
        }




    }
}
