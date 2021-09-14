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
    public class EfBakiyeBankaDal : IBakiyeBankaDal
    {
        public void Add(Bakiye_Banka entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Bakiye_Banka entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Bakiye_Banka Get(Expression<Func<Bakiye_Banka, bool>> filter)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return context.Set<Bakiye_Banka>().SingleOrDefault(filter);
            }
        }

        public List<Bakiye_Banka> GetAll(Expression<Func<Bakiye_Banka, bool>> filter=null)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return filter == null
                    ? context.Set<Bakiye_Banka>().ToList()
                    : context.Set<Bakiye_Banka>().Where(filter).ToList();
            }
        }

        public void Update(Bakiye_Banka entity)
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
