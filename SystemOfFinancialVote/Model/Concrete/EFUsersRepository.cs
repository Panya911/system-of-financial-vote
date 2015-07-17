using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;
using Model.Entities;

namespace Model.Concrete
{
    public class EFUsersRepository:IUsersRepository
    {
        private SystemOfFinancialContext _context = new SystemOfFinancialContext();
        
        public IQueryable<User> Users
        {
            get { return _context.Users; }
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
