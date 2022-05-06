using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //Bir sınıfın içerisinde miras olarak interface alacaksan o interace'teki metodları ilgili class'ıın içine implement etmen şart.

    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);//Kategoriden gelen değeri ekle.
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();//Kategoriye göre listeleme..
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);//EF Core ile birlikte gelen bir method bu.
            c.SaveChanges();
        }
    }
}
