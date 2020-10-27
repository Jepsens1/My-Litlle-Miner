using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
                inventory += $"{i} {player.Backpack[i].Stage} {player.Backpack[i].TypeOfMineral}\n";
            }
            return inventory;
        }
        public string SellItem(Player player)
        {

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
            return "Thanks for selling";
        }
        public string PickaxeList(Player player)
        {
            string list = "";
            Type enumtype = typeof(PickaxeRarity);
            string[] EnumName = enumtype.GetEnumNames();
            for (int i = 0; i < EnumName.Length; i++)
            {
                list += $"{i} Pickaxe {EnumName[i]}\n";
            }
            return list;
        }
        public string BuyPickaxe(Player player)
        {
            string item = "";

            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "0":
                    player.Money -= 20;
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Wood;
                    item = $"You have now got {player.MyPickaxe.TypeOfPickaxe}";
                    Thread.Sleep(1000);
                    break;
                case "1":
                    player.Money -= 60;
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Stone;
                    item = $"You have now got {player.MyPickaxe.TypeOfPickaxe}";
                    Thread.Sleep(1000);
                    break;
                case "2":
                    player.Money -= 150;
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Iron;
                    item = $"You have now got {player.MyPickaxe.TypeOfPickaxe}";
                    Thread.Sleep(1000);
                    break;
                case "3":
                    player.Money -= 200;
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Gold;
                    item = $"You have now got {player.MyPickaxe.TypeOfPickaxe}";
                    Thread.Sleep(1000);
                    break;
                case "4":
                    player.Money -= 300;
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Diamond;
                    item = $"You have now got {player.MyPickaxe.TypeOfPickaxe}";
                    Thread.Sleep(2000);
                    break;
                default:
                    item = "Wrong input";
                    Thread.Sleep(1000);
                    break;
            }

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
