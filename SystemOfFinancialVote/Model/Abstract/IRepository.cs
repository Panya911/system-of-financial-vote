using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Concrete;
using Model.Entities;

namespace Model.Abstract
{
    public interface IRepository
    {
        GenericRepository<User> Users { get; }
        GenericRepository<Proposal> Proposals { get; }
    }
}
