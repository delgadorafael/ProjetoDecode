﻿using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Domain.Interfaces.Servicies;
using System.Collections.Generic;

namespace ProjetoDecode.Domain.Servicies
{
    class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Update(T obj)
        {
            _repositoryBase.Update(obj);
        }

        public void Remove(T obj)
        {
            _repositoryBase.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }
    }
}
