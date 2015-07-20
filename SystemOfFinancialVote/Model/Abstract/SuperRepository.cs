using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Abstract
{
    public interface SuperRepository:IDisposable
    {
        IRepository<User> Users { get;}
        IRepository<Proposal> Proposals { get;}
        void Save();
    }
}
