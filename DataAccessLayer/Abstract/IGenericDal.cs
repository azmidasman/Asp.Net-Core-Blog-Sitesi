using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T t); //Entity'im olmadığı içi,n ve dışarıdan T türünde entity gönderdiğim için buradaki tipler T olmalı.
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
