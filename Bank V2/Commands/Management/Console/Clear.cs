using BankV2.Commands.Common;
using BankV2.Entities;

namespace BankV2.Commands.Management.Console;

public class Clear : Command
{
    public Clear() : base("clear", "Vider la console", null)
    {
    }

    public override bool Run(Player player, IReadOnlyList<string> providedArguments)
    {
        if (providedArguments.Count != 0) return false;
        
        System.Console.Clear();
        return true;
    }
}