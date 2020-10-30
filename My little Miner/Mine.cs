using System;
using System.Collections.Generic;
using System.Text;

namespace My_little_Miner
{
    class Mine
    {
        //Mining method
        public string Mining(Player player)
        {
            string temp = "";
            //Chance of mining minerals
            //Stone 50% 1/50
            //Coal  23%  51/74
            //Iron  10% 75/85
            //Gold  5% 86/91
            //Diamond 3% 92/95
            //Sapphire 2% 96/98
            //Ruby  1% 99/100
            Random r = new Random(Guid.NewGuid().GetHashCode());
            int chance = r.Next(1, 100);
            if (chance <= 50)
            {
                temp = PickaxeFortune(player, MineralRarity.Stone, temp);
                return temp;
            }
            else if (chance >= 51 && chance <= 74)
            {
                temp = PickaxeFortune(player, MineralRarity.Coal, temp);
                return temp;
            }
            else if (chance >= 75 && chance <= 85)
            {
                temp = PickaxeFortune(player, MineralRarity.Iron, temp);
                return temp;
            }
            else if (chance >= 86 && chance <= 91)
            {
                temp = PickaxeFortune(player, MineralRarity.Gold, temp);
                return temp;
            }
            else if (chance >= 92 && chance <= 95)
            {
                temp = PickaxeFortune(player, MineralRarity.Diamond, temp);
                return temp;
            }
            else if (chance >= 96 && chance <= 98)
            {
                temp = PickaxeFortune(player, MineralRarity.Sapphire, temp);
                return temp;
            }
            else if (chance >= 99 && chance <= 100)
            {
                temp = PickaxeFortune(player, MineralRarity.Ruby, temp);
                return temp;
            }
           
            return null;

        }
        public string PickaxeFortune(Player player, MineralRarity rarity, string temp)
        {
            //Chance of extra minerals
            Random rd = new Random();
            int Echange = rd.Next(1, 100);
            if (Echange > 90)
            {
                //Adding mineral to backpack and 2x
                for (int i = 0; i < 2; i++)
                {
                    player.Backpack.Add(new Mineral(rarity));
                    temp = FormatEnum(rarity) + "2x";
                }
                return temp;
            }
            else
            {
                //Adding mineral to backpack
                player.Backpack.Add(new Mineral(rarity));
                temp = FormatEnum(rarity);
            
                
                return temp;
            }
        }
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
