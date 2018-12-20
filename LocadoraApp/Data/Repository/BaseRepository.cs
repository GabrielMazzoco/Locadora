using System;
using System.Collections.Generic;
using LocadoraApp.Data.Context;
using LocadoraApp.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly LocadoraAppContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(LocadoraAppContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            Db.Update(obj);
        }
    }
}
