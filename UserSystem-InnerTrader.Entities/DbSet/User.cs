using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem_InnerTrader.Entities.DbSet
{
    public class User
    {
        public Guid IdentityId { get; set; } = Guid.NewGuid();

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }
    }
}
