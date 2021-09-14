using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKasaDal : IKasaDal
    {
        public void Add(Kasa entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Kasa entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Kasa Get(Expression<Func<Kasa, bool>> filter)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return context.Set<Kasa>().SingleOrDefault(filter);
            }
        }

        public List<Kasa> GetAll(Expression<Func<Kasa, bool>> filter=null)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return filter == null
                    ? context.Set<Kasa>().ToList()
                    : context.Set<Kasa>().Where(filter).ToList();
            }
        }

      

        public void Update(Kasa entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
