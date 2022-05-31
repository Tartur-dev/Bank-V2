using Application.Entities;
using Application.Manager;
using Application.IO;

namespace Application
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
