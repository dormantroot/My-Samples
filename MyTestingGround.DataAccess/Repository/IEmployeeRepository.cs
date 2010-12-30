using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTestingGround.DomainObjects;

namespace MyTestingGround.DataAccess.Repository
{
    public interface IEmployeeRepository : IRepository<IEmployee>
    {
        ICollection<IEmployee> FindAll();

        void Add(IEmployee entity);
    }
}
