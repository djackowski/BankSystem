using System.Collections.Generic;
using System.Linq;

namespace BankSystem.Operations
{
    public class ActiveOperationEngine
    {
        private readonly LinkedList<IOperation> _commands;

        public ActiveOperationEngine()
        {
            _commands = new LinkedList<IOperation>();
        }

        public ActiveOperationEngine(LinkedList<IOperation> commands)
        {
            _commands = commands;
        }

        public void AddCommand(IOperation command)
        {
            _commands.AddLast(command);
        }

        public void Run()
        {
            while (!_commands.Any())
            {
                var command = _commands.First();
                _commands.RemoveFirst();
                command.ExecuteOperation();
            }
        }
    }
}
