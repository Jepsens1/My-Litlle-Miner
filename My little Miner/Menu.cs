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
            Console.WriteLine("My LITTLE MINER" + "\n" + "1. Go to the cave and mine" + "\n" + "2. Open your inventory" + "\n" + "3. Smelt your stuff in the smeltery" + "\n" + "4. Go to Shop");
            try
            {
            int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Going to the cave");
                    Thread.Sleep(1000);
                    Mining(player);
                }
                else if (userinput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Loading inventory");
                    Thread.Sleep(1000);

                    Inventory(player);
                }
                else if (userinput == 3)
                {

                    Console.Clear();
                    Console.WriteLine("Loading inventory");
                    Thread.Sleep(1000);
                    Console.WriteLine(smelt.SmeltAll(player));
                    Console.WriteLine("Type what Mineral you want to refine");
                    Console.WriteLine(smelt.Smelt(player));
                    Thread.Sleep(3000);
                    Console.Clear();
                  
                    MainMenu(player);
                }
                else if (userinput == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Loading inventory");
                    Thread.Sleep(1000);
                    Shop(player);


                }
                else if (userinput > 4)
                {
                    throw new Exception();
                    
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Wrong input, exiting to mainmenu");
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu(player);
            }
           
        }
        //Mining Scene
        public void Mining(Player player)
        {
            while (true)
            {
                
               
                Console.Clear();
                    Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.Mining(player));
                try
                {
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 2)
                    {
                        Console.WriteLine("Returning to villages...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(player);
                    }
                    else if (userinput > 2)
                    {
                        Console.WriteLine("Wrong input, exiting to mainmenu");
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu(player);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, exiting to mainmenu");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MainMenu(player);
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
            while (true)
            {
                try
                {
                    Console.WriteLine(shop.ShopInventory(player));
                    Console.WriteLine("Type what Mineral you want to sell");
                    Console.WriteLine(shop.SellItem(player));
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu(player);
                    int userinput = Convert.ToInt32(Console.ReadLine());
                    if (userinput == 0)
                    {

                        MainMenu(player);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input returning to mainmenu");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MainMenu(player);
                }
                

            }
        }
        



    }
}
