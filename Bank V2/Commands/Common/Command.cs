
using BankV2.Entities;

namespace BankV2.Commands.Common;

public abstract class Command
{
    public string Name { get; }
    private string Description { get; }
    private string? RequiredArguments { get; }

    public string Help => $"- /{Name} {RequiredArguments ?? ""}: {Description}.";

    protected Command(string name, string description, string? requiredArguments)
    {
        Name = name;
        Description = description;
        RequiredArguments = requiredArguments;
    }

    public abstract bool Run(Player player, IReadOnlyList<string> providedArguments);
}