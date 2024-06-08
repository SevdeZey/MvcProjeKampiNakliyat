using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {

        //gereric repository sınıfıma bağlı olarak üzerinde çalışıcağım sınıfı çağırıcam
        GenericRepository<Category> repo = new GenericRepository<Category> ();
        /*üstteki satırı kullanarak repo adında bir nesne türetirken hem
        dataaccesslayer hem de entitylayer katmanlarını import ettik */

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName==""||p.CategoryName.Length<3||p.CategoryName.Length>51||p.CategoryDescription=="")
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
            
        /*diyelim bir password belirleme işleminde 20den fazla karakter kullanılmaması kuralı
         için veya kullanıcı adında rakam bulunmaması gibi konularda belirleyici kurallarla
         yönetimi sağlamak için businesslayer kullanıcaz(crud işlemleri falan belki...)*/

        }



    }
}
