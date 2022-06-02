using Bank_V2.Entities;
using Bank_V2.Manager;
using Bank_V2.IO;

namespace Bank_V2
{    
    public class Program
    {
        public static void Main(string[] args)
        {
            string playerName;

            Input.OpenIf(out playerName,
                "Quel est votre nom ? : ",
                "Nom invalide. Votre pseudo doit faire entre 3 et 20 caractères",
                (playerName) => playerName.Length >= 3 && playerName.Length <= 20);

            Player player = new Player(playerName);

            ConsoleApplication application = new ConsoleApplication(player);
            application.Start();
        }
    }
}
