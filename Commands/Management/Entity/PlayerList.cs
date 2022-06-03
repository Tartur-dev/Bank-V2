using BankV2.Commands.Common;
using BankV2.Entities;
using BankV2.Manager;

namespace BankV2.Commands.Management.Entity;

public class PlayerList : Command
{
    private readonly ConsoleApplication _app;
    
    public PlayerList(ConsoleApplication app) : base("playerlist", "Obtenir la liste des joueurs connectés", null)
    {
        _app = app;
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count != 0) return false;
        
        System.Console.WriteLine("Les joueurs connectés sont :");

        foreach (var target in _app.PlayerList)
        {
            System.Console.WriteLine($"- {target.Name}");
        }

        return true;
    }
}