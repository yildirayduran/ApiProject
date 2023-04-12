using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<Entity> where Entity : class
    {
        void Insert(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);
        List<Entity> GetList();
        Entity GetById(int id);
    }
}
