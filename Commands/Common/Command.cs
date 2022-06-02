
namespace Bank_V2.Commands.Common
{
    public abstract class Command
    {
        public string Name { get; }
        public string Description { get; }
        public string? RequiredArguments { get; }

        public string Help { get => $"- /{Name} {(RequiredArguments != null ? RequiredArguments : "")}: {Description}."; }

        public Command(string name, string description, string? requiredArguments)
        {
            Name = name;
            Description = description;
            RequiredArguments = requiredArguments;
        }

        public abstract bool Run(params string[] providedArguments);
    }
}
