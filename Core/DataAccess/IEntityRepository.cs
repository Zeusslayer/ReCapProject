﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class , IEntity,new()
    {
        List<T> GetAll(Expression<Func<T , bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetCarsByBrandId(int brandId);
        List<T> GetCarsByColorId(int colorId);

    }
}
