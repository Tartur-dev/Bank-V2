using BankV2.Commands.Common;
using BankV2.Commands.Management.Console;
using BankV2.Commands.Management.Entity;

namespace BankV2.Manager;
public class CommandManager
{
    public readonly Command[] Commands;
    
    public CommandManager(ConsoleApplication app)
    {
        Commands = new Command[] {
            // Console Management
            new Echo(),
            new Clear(),
            new Exit(app),
            new Help(this),
            
            // Player Management
            new CreatePlayer(app),
            new PlayerList(app)
        };
    }

    public Command? GetCommand(string name)
    {
        return Commands.FirstOrDefault(cmd => string.Equals(name, cmd.Name, StringComparison.OrdinalIgnoreCase));
    }
}
