using Application.Entities;
using Application.IO;

namespace Application.Manager
{
    public class ConsoleApplication
    {
        private Player _MainPlayer;
        public List<Player> PlayerList { get; }

        public bool IsRunning { get; set; }

        public ConsoleApplication(Player mainPlayer)
        {
            _MainPlayer = mainPlayer;
            PlayerList = new List<Player>();

            IsRunning = false;
        }

        public void Start()
        {
            Console.WriteLine($"Bienvenue, {_MainPlayer.Name} !\n");
            IsRunning = true;

            while (IsRunning)
            {
                string input;
                Input.Open(out input, $"{_MainPlayer.Name}'s app> ", "Vous ne pouvez pas saisir de texte vide");

                if (input != "exit")
                {
                    Console.WriteLine($"Vous avez dit : {input}\n");
                    continue;
                }

                IsRunning = false;
            }
        }
        
    }
    
}
