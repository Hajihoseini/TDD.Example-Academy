using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Tests.CollectionFixtures
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
