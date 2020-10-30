using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            string userinput = Console.ReadLine();
            string item = " ";
            try
            {
                if (userinput == "0" && player.Money >= 20)
                {
                    player.Money -= 20;
                    item += $"You have now got Pickaxe {PickaxeRarity.Wood}";
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Wood;
                   

                }
                else if (userinput == "1" && player.Money >= 60)
                {
                    player.Money -= 60;
                    item += $"You have now got Pickaxe {PickaxeRarity.Stone}";
                    Thread.Sleep(1000);
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Stone;
                   
                }
                else if (userinput == "2" && player.Money >= 150)
                {
                    player.Money -= 150;
                    item += $"You have now got Pickaxe {PickaxeRarity.Iron}";
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Iron;

                   
                }
                else if (userinput == "3" && player.Money >= 200)
                {
                    player.Money -= 200;
                    item += $"You have now got Pickaxe {PickaxeRarity.Gold}";
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Gold;
                    
                }
                else if (userinput == "4" && player.Money >= 300)
                {
                    player.Money -= 300;
                    item += $"You have now got Pickaxe {PickaxeRarity.Diamond}";
                    player.MyPickaxe.TypeOfPickaxe = PickaxeRarity.Diamond;
                    
                }
                else
                {
                    item += "You dont have enough money";

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong input");
                
            }
            return item;

        }
        public string BuyFood(Player player)
        {
            
            string userinput = Console.ReadLine();
            string food = "";
            if (userinput == "1" && player.Money >= 2)
            {
                player.Health++;
                player.Money -= 2;
                food = "You got 1 plus health";
            }
            else if (userinput == "2" && player.Money >= 10)
            {
                player.Health += 10;
                player.Money -= 10;
                food = "You got 10 plus health";
            }
            else if (userinput == "3" && player.Money >= 30)
            {
                player.Health += 50;
                player.Money -= 30;
                food = "You got 50 plus health";
            }
            else if (userinput == "4" && player.Money >= 70)
            {
                player.Health += 10;
                player.Money -= 70;
                food = "You got 100 plus health";
            }
            else
            {
                food = "Wrong input";
            }
           
            return  food;
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
