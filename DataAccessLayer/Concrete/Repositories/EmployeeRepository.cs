using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class EmployeeRepository : IEmployeeDal
    {

        Context c = new Context();
        DbSet<Employee> _object;


        public void Delete(Employee p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee p)
        {
            throw new NotImplementedException();
        }

        public List<Employee> List()
        {
            throw new NotImplementedException();
        }

        public List<Employee> List(Expression<Func<Employee, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee p)
        {
            throw new NotImplementedException();
        }
    }
}
