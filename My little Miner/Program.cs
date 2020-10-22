using System;

namespace My_little_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Pickaxe pickaxe = new Pickaxe(PickaxeRarity.Wood);
            Player player = new Player("Phiilip", pickaxe);
            Menu menu = new Menu();
            menu.MineScene(player);
        }
    }
}
