﻿using System.Collections.Generic;
using System.Linq;

namespace NPocoCachedRepository
{
    public interface IRepository<T>
    {
        object Add(T instance);
        void Update(T instance);
        void Remove(T instance);
        void RemoveById(object id);
        T GetById(object id);
        IEnumerable<T> GetAll();
        IQueryable<T> QueryAll();

        void Save();
        void Rollback();
    }
}
