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
    public class EfBankaDal : IBankaDal
    {
        public void Add(Banka entity)
        {
            using (SaDatabase context=new SaDatabase())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Banka entity)
        {
            using (SaDatabase context = new SaDatabase())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Banka Get(Expression<Func<Banka, bool>> filter)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return context.Set<Banka>().SingleOrDefault(filter);
            }
        }

        public List<Banka> GetAll(Expression<Func<Banka, bool>> filter=null)
        {
            using (SaDatabase context = new SaDatabase())
            {
                return filter == null
                    ? context.Set<Banka>().ToList()
                    : context.Set<Banka>().Where(filter).ToList();
            }
        }

     

        public void Update(Banka entity)
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
