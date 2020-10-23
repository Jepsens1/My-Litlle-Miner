using System;
using System.Collections.Generic;
using System.Text;

namespace My_little_Miner
{
    class Shop
    {
        //Money for material
        //Refined + 10 coins
        //Raw stone = 10 coins
        //RawCoal = 15 coins
        //RawIron = 25 coins
        //Gold = 35 coins
        //Diamond = 60 coins
        //Sapphire = 80 coins 
        //Ruby  100 coins 
        public string ShopInventory(Player player)
        {
            string inventory = "";
            for (int i = 0; i < player.Backpack.Count; i++)
            {
                inventory += $"{i + 1} {player.Backpack[i].Stage} {player.Backpack[i].TypeOfMineral}\n";
            }
            return inventory;
        }
        public string SellItem(Player player)
        {
            string item = "";
            int userinput = Convert.ToInt32(Console.ReadLine());
           
                switch (player.Backpack[userinput].TypeOfMineral)
                {
                    case MineralRarity.Stone:
                        player.Money += 10 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    case MineralRarity.Coal:
                        player.Money += 15 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    case MineralRarity.Iron:
                        player.Money += 25 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    case MineralRarity.Gold:
                        player.Money += 35 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    case MineralRarity.Diamond:
                        player.Money += 60 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                            break;
                    case MineralRarity.Sapphire:
                        player.Money += 80 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    case MineralRarity.Ruby:
                        player.Money += 100 + Calculator(player.Backpack[userinput]);
                        player.Backpack.RemoveAt(userinput);
                        break;
                    
                        
                }
                item = $"You have sold {player.Backpack[userinput].TypeOfMineral}";
            
            return item;
        }
        public int Calculator(Mineral mineral)
        {
            switch (mineral.Stage)
            {
                case Stage.Refined:
                    return 10;
                case Stage.Raw:
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
