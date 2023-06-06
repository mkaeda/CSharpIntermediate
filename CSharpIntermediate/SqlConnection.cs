using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("closing sql connection...");
            Console.WriteLine("connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("openning sql connection...");
            Console.WriteLine("connected.");
        }
    }
}
