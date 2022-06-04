using BankV2.Commands.Common;
using BankV2.Entities;
using BankV2.Manager;

namespace BankV2.Commands.Management.Entity;

public class CreatePlayer : Command
{
    private readonly ConsoleApplication _app;
    
    public CreatePlayer(ConsoleApplication app) : base("createplayer", "Créer un nouveau joueur", new ArgumentsBuilder().Add("pseudo").Build())
    {
        _app = app;
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count != 1) return false;

        var playerName = providedArguments[0];
        var newPlayer = new Player(playerName);
        
        _app.PlayerList.Add(newPlayer);
        System.Console.WriteLine($"Le joueur \"{playerName}\" a bien été créé !");

        return true;
    }
}