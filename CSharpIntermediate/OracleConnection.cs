using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("closing oracle connection...");
            Console.WriteLine("connection closed.");
        }

        public override void Open()
        {
            Console.WriteLine("openning oracle connection...");
            Console.WriteLine("connected.");
        }
    }
}
