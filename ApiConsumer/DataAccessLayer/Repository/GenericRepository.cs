using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<Entity> : IGenericDal<Entity> where Entity : class
    {
        private readonly Context _context;
        private Context context;

        public GenericRepository(Context context)
        {
            this.context = context;
        }

        public void Delete(Entity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Entity GetById(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public List<Entity> GetList()
        {
            return _context.Set<Entity>().ToList();
        }

        public void Insert(Entity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Entity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
