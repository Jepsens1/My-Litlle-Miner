using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace My_little_Miner
{
    class Menu
    {
        Mine mine = new Mine();
        Smeltery smelt = new Smeltery();
        Shop shop = new Shop();
        //Menu Scene

        //Start Menu when opening game
        public void MainMenu(Player player)

        {
            if (player.Health == 0)
            {
                Console.WriteLine("You died :( you ran out of health");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
            Console.WriteLine($"My LITTLE MINER\n1. Go to the cave and mine\n2. Open your inventory\n3. Smelt your stuff in the smeltery\n4. Go to Shop\n \nPlayername {player.Name}\nPickaxe {player.MyPickaxe.TypeOfPickaxe}\nCurrent coins earned {player.Money}\nHealth {player.Health}");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Going to the cave");
                    Thread.Sleep(1000);
                    Mining(player);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Loading inventory");
                    Thread.Sleep(1000);

                    Inventory(player);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Loading inventory");
                    Thread.Sleep(1000);
                    Smelting(player);
                    break;
                case "4":
                    Console.Clear();

                    Thread.Sleep(1000);
                    Shop(player);
                    break;

                default:
                    Console.WriteLine("Wrong Input!! returning to MainMenu");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MainMenu(player);
                    break;

            }



        }
        //Mining Scene
        public void Mining(Player player)
        {
            while (true)
            {


                Console.Clear();
                Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.Mining(player));
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        mine.Mining(player);
                        break;
                    case "2":
                        Console.WriteLine("Returning to villages...");
                        player.Health--;
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(player);
                        break;
                  
                    default:
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
        //Inventory menu
        public void Inventory(Player player)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Inventory:" + "\n" + "--------------------------" + "\n");
                    Console.WriteLine(player.ShowInventory() + "\n" + "--------------------------");

                    Console.WriteLine("1. Close backpack");
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 1)
                    {
                        Console.Clear();
                        MainMenu(player);
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine(player.ShowInventory());

                }


            }
        }
        public void Shop(Player player)
        {

            Console.WriteLine("Welcome to the Shop");
            Console.WriteLine("1. Buy new pickaxe");
            Console.WriteLine("2. Sell item");
            Console.WriteLine("3. Buy food");
            Console.WriteLine("4. MainMenu");
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Pickaxe Wood = 20 Coins\nPickaxe Stone = 60 Coins\nPickaxe Iron = 150 Coins\nPickaxe Gold = 200 Coins\nPickaxe Diamond = 300 Coins\n");
                    Console.WriteLine(shop.PickaxeList(player));
                    Console.WriteLine("Choose what Pickaxe you to buy");
                    Console.WriteLine(shop.BuyPickaxe(player));
                   
                    Console.Clear(); 
                    MainMenu(player);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(shop.ShopInventory(player));
                    Console.WriteLine("Type what Mineral you want to sell");
                    Console.WriteLine(shop.SellItem(player));
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu(player);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Choose how many you want");
                    Console.WriteLine($"1 health = 2 coins Press 1\n10 health = 10 coins Press 2\n50 health = 30 coins Press 3\n100 health = 70 coins Press 4");
                    Console.WriteLine(shop.BuyFood(player));
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu(player);

                    
                    break;
                case "4":
                    Console.Clear();
                    MainMenu(player);
                    break;


                default:
                    Console.WriteLine("Wrong input");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Shop(player);
                    break;
            }

        }

        public void Smelting(Player player)
        {

            Console.WriteLine(smelt.SmeltAll(player));
            Console.WriteLine("Type what Mineral you want to refine");
            Console.WriteLine(smelt.Smelt(player));
            Thread.Sleep(3000);
            Console.Clear();
            
            MainMenu(player);






        }
    }
}
