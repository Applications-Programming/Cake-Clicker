using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Clicker_Game
{
    public static class Test
    {
        static void MainTesting()
        {
            Console.WriteLine("Testing game clicks, multiplier, and caketype...");
            Game game = new Game();
            for (int i = 0; i < 200; i++)
            {
                game.AddCake();
                if (i % 20 == 0)
                {
                    game.IncrementMultiplier();
                }
                //game.ChangeCakeType();
                //Console.WriteLine("CURRENT CAKE TYPE: " + game.AccessCakeType());
            }
            Console.WriteLine("Testing game ToString...");
            Console.WriteLine(game.ToString());

            Console.WriteLine("Testing Get Methods...");
            game.GetMultiplier();
            game.GetAmountOfCake();

            Console.WriteLine("Testing SaveGameToFile...");
            game.SaveGameToFile();
            game.ResetGame();
            Console.WriteLine("Clicks" + game.GetAmountOfCake());
            game.LoadFile();
            Console.WriteLine("Clicks Loaded" + game.GetAmountOfCake());

            /**
             * 
             * try
            {
                File.Exists("CakeGameData.txt");
                Console.WriteLine("The File Exists IN THIS DIRECTORY");
            }
            catch
            {
                Console.WriteLine("The File Does NOT exist");
            }
             */

            Console.WriteLine("Testing Game Reset...");
            game.ResetGame();
            //****Changed this test case, please double check****
            if (game.GetAmountOfCake() == 0)
            {
                Console.WriteLine("All tests passed!");
            }

        }
    }
}
