using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace My_little_Miner
{
    class Menu
    {
        Mine mine = new Mine();
        Smeltery smelt = new Smeltery();
        //Menu Scene
        public void MineScene(Player player)
        {
            MainMenu();
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == 1)
            {
                Console.Clear();
                Console.WriteLine("Going to the cave");
                Thread.Sleep(1000);
                Console.WriteLine("1. Start Mining");
                Mining(player); 
            }
            else if (userinput == 2)
            {
                Console.Clear();
                Console.WriteLine("Loading inventory");
                Thread.Sleep(1000);
                Console.WriteLine("2 show inventory");
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
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu(player)

            }
                
                        
                
        }
        //Start Menu when opening game
        public void MainMenu()
        {
            Console.WriteLine("My LITTLE MINER" + "\n" + "1. Go to the cave and mine" + "\n" + "2. Open your inventory" + "\n" + "3. Smelt your stuff in the smeltery" + "\n" + "4. Go to Shop");
        }
        //Mining Scene
        public void Mining(Player player)
        {
            while (true)
            {
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1. Keep Mining" + "\n" + "2. Return To Villages" + "\n" + "You got a new mineral " + mine.Mining(player));
                }
                if (userinput == 2)
                {
                    Console.WriteLine("Returning to villages...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    MineScene(player);
                }
            }
        }
        //Inventory menu
        public void Inventory(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Inventory:" + "\n" + "--------------------------" + "\n");
                Console.WriteLine(player.ShowInventory() + "\n" + "--------------------------");
                
                Console.WriteLine("1. Close backpack");
                int userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    Console.Clear();
                    MineScene(player);
                }
            }
        }
        



    }
}
