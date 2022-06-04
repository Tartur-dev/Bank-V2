using BankV2.Commands.Common;
using BankV2.Entities;
using BankV2.Manager;

namespace BankV2.Commands.Management.Console;

public class Exit : Command
{
    private ConsoleApplication _app;
    
    public Exit(ConsoleApplication app) : base("exit", "Quitter l'invite de commandes", null)
    {
        _app = app;
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count != 0) return false;

        _app.Running = false;
        return true;
    }
}