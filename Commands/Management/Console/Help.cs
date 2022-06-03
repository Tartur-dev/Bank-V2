using BankV2.Commands.Common;
using BankV2.Entities;
using BankV2.Manager;

namespace BankV2.Commands.Management.Console;

public class Help : Command
{
    private readonly CommandManager _commandManager;
    
    public Help(CommandManager commandManager) : base("help", "Obtenir toutes les utilisations des commandes", new ArgumentsBuilder().Add("commande").Required(false).Build())
    {
        _commandManager = commandManager;
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count == 0)
        {
            System.Console.WriteLine("Voici la liste des commandes disponibles :\n");
            foreach (var command in _commandManager.Commands) System.Console.WriteLine(command.Help);

            return true;
        }

        foreach (var commandName in providedArguments)
        {
            var command = _commandManager.GetCommand(commandName);
            System.Console.WriteLine(command != null ? command.Help : $"La commande \"{commandName}\" n'a pas pu être trouvée.");
        }

        return true;
    }
}