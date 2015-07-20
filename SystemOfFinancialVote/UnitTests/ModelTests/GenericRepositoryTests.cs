using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Concrete;
using Model.Entities;
using NUnit.Framework;

namespace UnitTests.ModelTests
{
    [TestFixture]
    public class GenericRepository_should
    {
        [Test]
        public void addElement()
        {
            var repository = new GenericRepository<User>(new SystemOfFinancialContext());
            repository.Insert(new User(){FirstName = "Flyagin"});

            Assert.NotNull(repository.Get(x=>x.FirstName=="Flyagin"));
        }
    }
}
