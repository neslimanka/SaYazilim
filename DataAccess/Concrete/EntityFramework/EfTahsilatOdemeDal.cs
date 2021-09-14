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
    public class EfTahsilatOdemeDal : ITahsilatOdemeDal
    {
        public void Add(Tahsilat_odeme entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tahsilat_odeme entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tahsilat_odeme Get(Expression<Func<Tahsilat_odeme, bool>> filter)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return context.Set<Tahsilat_odeme>().SingleOrDefault(filter);
            }
        }

        public List<Tahsilat_odeme> GetAll(Expression<Func<Tahsilat_odeme, bool>> filter=null)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return filter == null
                    ? context.Set<Tahsilat_odeme>().ToList()
                    : context.Set<Tahsilat_odeme>().Where(filter).ToList();
            }
        }

      

        public void Update(Tahsilat_odeme entity)
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
