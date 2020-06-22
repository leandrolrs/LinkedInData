﻿using System.Collections.Generic;

namespace LinkedInData.Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {

        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
