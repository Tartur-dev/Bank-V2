using BankV2.Commands.Common;
using BankV2.Entities;

namespace BankV2.Commands.Management.Console;

public class Echo : Command
{
    public Echo() : base("echo", "Imprimer du texte en console", new ArgumentsBuilder().Add("texte").Build())
    {
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count == 0) return false;

        foreach (var argument in providedArguments)
        {
            System.Console.Write($"{argument} ");
        }

        return true;
    }
}