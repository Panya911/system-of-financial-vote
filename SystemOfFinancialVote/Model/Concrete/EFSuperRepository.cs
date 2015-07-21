using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFSuperRepository:ISuperRepository
    {
        private SystemOfFinancialContext _context;

        public EFSuperRepository()
        {
            _context = new SystemOfFinancialContext();
            Users = new EFRepository<User>(_context);
            Proposals = new EFRepository<Proposal>(_context);
        }

        public IRepository<User> Users { get; private set; }
        public IRepository<Proposal> Proposals { get; private set; }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
