using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class //öyle bir T ki sadece class olmalı demek where T:class
    {

        Context c=new Context();
        DbSet<T> _object;

        public GenericRepository() //constructor yapıcı metotla T değerini atadık ki, genericrepository i kullanırken doğruca class ı alabilelim
        {
            _object = c.Set<T>(); //bu kodla, _object isimli field değişken, dışarıdan gönderdiğim entity neyse o olacak
        }


        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();    
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
