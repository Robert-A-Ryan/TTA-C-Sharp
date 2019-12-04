using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.BlackJack;
using Casino;

namespace TwentyOne_Blackjack
{
    class Program
    {
        
        static void Main(string[] args)
        {


            string playerName;
            do
            {
                Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's star be telling me your name.");
                playerName = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(playerName));
           

            //converted to a check to see if a number entered
            Console.WriteLine("How much money did you bring today?");
            int bank;
            bool corInt = int.TryParse(Console.ReadLine(), out bank) && bank > 0;

            while (!corInt)
            {
                Console.WriteLine("You didn't enter an amount, please try again.");
                corInt = int.TryParse(Console.ReadLine(), out bank) && bank > 0;
            }


            
            Console.WriteLine("Hello, {0}. Would you like to joing a game of Blackjack right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\coach\Documents\The-Tech-Academy-Projects\C-Sharp\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                Game game = new BlackJackGame();
                game += player;
                player.isActivelyPlaying = true;
                
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino, Bye for now.");
            Console.ReadLine();
        }

        
    }
}
