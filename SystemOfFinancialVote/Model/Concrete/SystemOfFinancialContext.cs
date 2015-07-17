using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Concrete
{
    class SystemOfFinancialContext : DbContext
    {
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
