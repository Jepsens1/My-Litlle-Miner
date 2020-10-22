using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Linq;

namespace My_little_Miner
{
    class Smeltery
    {

        public string SmeltAll(Player player)
        {
            string temp2 = "";
            for (int i = 0; i < player.Backpack.Count; i++)
            {
                
                temp2 += i+1 + " " + player.Backpack[i].Stage.ToString() + " " + player.Backpack[i].TypeOfMineral + "\n";
            }
            return temp2;
        }
        public string Smelt(Player player)
        { 
            string temp = "";
            
            int userinput = Convert.ToInt32(Console.ReadLine());
            userinput--;
            for (int i = 0; i < player.Backpack.Count; i++)
            {
                if (userinput == i && player.Backpack[i].Stage == Stage.Raw)
                {
                    
                    player.Backpack[i].Stage = Stage.Refined;
                    temp = player.Backpack[i].TypeOfMineral.ToString() + player.Backpack[i].Stage.ToString(); 


                }
            }
            return  temp;
            
        }
       




    }
}
//loop igennem for at få raw mineraler
//Change raw minerals to smelted minerals
//clear raw minerals
//add smelted minerals to backpack
