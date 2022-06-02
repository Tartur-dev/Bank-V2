using Bank_V2.Commands;
using Bank_V2.Commands.Common;

namespace Bank_V2.Manager
{
    public class CommandManager
    {
        private Command[] _commands;

        public CommandManager()
        {
            _commands = new Command[] {
                new Test()
            };
        }

        public Command? GetCommand(string name)
        {
            foreach (var cmd in _commands)
                if (string.Equals(name, cmd.Name, StringComparison.OrdinalIgnoreCase)) return cmd;

            return null;
        }
    }
}
