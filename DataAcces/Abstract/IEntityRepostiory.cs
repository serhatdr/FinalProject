﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface IEntityRepostiory<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
