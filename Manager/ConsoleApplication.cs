using Bank_V2.Entities;
using Bank_V2.IO;
using Bank_V2.Commands.Common;

namespace Bank_V2.Manager
{
    public class ConsoleApplication
    {
        private Player _mainPlayer;
        private CommandManager _commandManager;
        private List<Player> _playerList;

        public bool IsRunning { get; set; }

        public ConsoleApplication(Player mainPlayer)
        {
            _mainPlayer = mainPlayer;
            _commandManager = new CommandManager();
            _playerList = new List<Player>();

            IsRunning = false;
        }

        // À optimiser
        public void Start()
        {
            string pseudo = _mainPlayer.Name;

            Console.WriteLine($"Bienvenue, {pseudo} !\n");
            IsRunning = true;

            while (IsRunning)
            {
                string input;
                Input.Open(out input, $"{pseudo}'s app> ", "Vous ne pouvez pas saisir de texte vide");

                List<string> arguments = input.Split(' ').ToList();

                Command command = _commandManager.GetCommand(arguments[0]);

                if (command != null)
                {
                    if (!command.Run(arguments.GetRange(1, arguments.Count - 1).ToArray()))
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
}
