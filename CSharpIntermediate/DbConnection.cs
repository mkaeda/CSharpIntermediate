using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        public readonly string ConnectionString;
        public readonly TimeSpan Timeout;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("connectionString cannot be null, empty or whitespace");
            }
            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();

    }
}
