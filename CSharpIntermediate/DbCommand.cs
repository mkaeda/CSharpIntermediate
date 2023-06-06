using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class DbCommand
    {
        public DbConnection Connection { get; private set; }
        public string Command { get; private set; } 

        public DbCommand(DbConnection connection, string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("command cannot be null, empty or whitespace");
            }
            Connection = connection ?? throw new ArgumentNullException("conneciton");
            Command = command;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("executing command...");
            Console.WriteLine("done.");
            Connection.Close();
        }

    }
}
