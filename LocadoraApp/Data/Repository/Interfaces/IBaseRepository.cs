﻿using System;
using System.Collections.Generic;

namespace LocadoraApp.Data.Repository.Interfaces
{
    public interface IBaseRepository<TEntity>  : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        int SaveChanges();
    }
}
