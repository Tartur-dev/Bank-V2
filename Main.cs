using BankV2.Entities;
using BankV2.Manager;
using BankV2.IO;

namespace BankV2;

public class Program
{
    public static void Main(string[] args)
    {
        Input.OpenIf(out var playerName,
            "Quel est votre nom ? : ",
            "Nom invalide. Votre pseudo doit faire entre 3 et 20 caractères",
            name => name.Length is >= 3 and <= 20);

        var player = new Player(playerName);

        var application = new ConsoleApplication(player);
        application.Start();
    }
}
