using Bank_V2.Commands.Common;

namespace Bank_V2.Commands
{
    public class Test : Command
    {
        public Test() : base("test", "Commande de test", new ArgumentsBuilder().Add("phrase").Build())
        {
        }

        public override bool Run(params string[] providedArguments)
        {
            Console.Write("Test réussi ! Vous avez dit : ");

            foreach (var argument in providedArguments)
            {
                Console.Write(argument + " ");
            }

            Console.WriteLine();

            return true;
        }
    }
}