using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Tests.ClassFixtures
{
    public class IdentifierFixture : IDisposable
    {
        public static Guid Id { get; set; }

        public IdentifierFixture()
        {
            Id = Guid.NewGuid();
        }

        public void Dispose()
        {
            Id = Guid.Empty;
        }
    }
}
