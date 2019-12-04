using System;
using System.Collections.Generic;
using System.IO;
using Casino.TwentyOne_Blackjack;
using System.Data.SqlClient;
using System.Data;

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
                if (playerName.ToLower() == "admin")
                {
                    List<ExceptionEntity> Exceptions = ReadExceptions();
                    foreach (var exception in Exceptions)
                    {
                        Console.Write(exception.Id + " | ");
                        Console.Write(exception.ExceptionType + " | ");
                        Console.Write(exception.ExceptionMessage + " | ");
                        Console.Write(exception.TimeStamp + " | \n");
                    }
                    Console.Read();
                    return;
                }
            }
            while (string.IsNullOrEmpty(playerName));
           

            //converted to a check to see if a number entered
            Console.WriteLine("How much money did you bring today?");
            int bank;
            bool corInt = int.TryParse(Console.ReadLine(), out bank) && bank > 0;

            while (!corInt)
            {
                Console.WriteLine("You didn't enter a correct amount, please try again.");
                corInt = int.TryParse(Console.ReadLine(), out bank) && bank > 0;
                if (!corInt) Console.WriteLine("Please enter number digits only.");
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
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino, Bye for now.");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BlackJackGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp",SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BlackJackGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions;
        }


    }
}
