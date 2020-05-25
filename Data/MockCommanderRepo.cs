using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "noP", Line = "Not on my watch", Platform = "Good" },
                new Command { Id = 1, HowTo = "noP1", Line = "Not on my watch1", Platform = "Good1" },
                new Command { Id = 2, HowTo = "noP2", Line = "Not on my watch2", Platform = "Good2" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "noP", Line = "Not on my watch", Platform = "Good" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            throw new NotImplementedException();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
