using System;

namespace Academy.Domain.Tests
{
    public class DatabaseFixture :IDisposable
    {
        public Guid ConnectionString { get; set; }

        public DatabaseFixture()
        {
            ConnectionString = Guid.NewGuid();  
        }

        public void Dispose()
        {
            ConnectionString = Guid.Empty;
        }
    }
}
