using System;

namespace Bank_V2.Commands.Common
{
    public class ArgumentsBuilder
    {
        private List<string> _arguments;
        private bool _required;

        public ArgumentsBuilder()
        {
            _arguments = new List<string>();
            _required = false;
        }

        public ArgumentsBuilder Add(string argument)
        {
            _arguments.Add(argument);
            return this;
        }

        public ArgumentsBuilder Required(bool required)
        {
            _required = required;
            return this;
        }

        public string Build()
        {
            string finalString = _required ? "<" : "[";

            foreach (var argument in _arguments)
            {
                finalString += argument;
                if (argument != _arguments.Last()) finalString += "/";
            }

            return finalString + (_required ? "> " : "] ");
        }
    }
}
