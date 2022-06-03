using BankV2.Entities;
using BankV2.IO;

namespace BankV2.Manager;

public class ConsoleApplication
{
    private readonly Player _mainPlayer;
    private readonly CommandManager _commandManager;
    
    public readonly List<Player> PlayerList;
    
    public bool Running { get; set; }

    public ConsoleApplication(Player mainPlayer)
    {
        _mainPlayer = mainPlayer;
        PlayerList = new List<Player> {_mainPlayer};
        _commandManager = new CommandManager(this);
        Running = false;
    }

    public void Start()
    {
        var pseudo = _mainPlayer.Name;

        Console.WriteLine($"Bienvenue, {pseudo} !\n");
        Running = true;

        while (Running)
        {
            Console.WriteLine();
            Input.Open(out var input, $"{pseudo}'s app> ", "Vous ne pouvez pas saisir de texte vide");

            var arguments = input.Split(' ').ToList();
            var command = _commandManager.GetCommand(arguments[0]);
            
            arguments.RemoveAt(0);

            if (command != null)
            {
                if (!command.Run(_mainPlayer, arguments))
                {
                    Console.WriteLine($"Commande invalide. Utilisation correcte : \n{command.Help}");
                }

                continue;
            }

            Console.WriteLine($"Commande {arguments[0]} introuvable.");
        }

        Console.WriteLine($"Ravi de vous avoir connu, {pseudo} !");
    }
}
