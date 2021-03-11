using Microsoft.EntityFrameworkCore;
using ProjetoDecode.Domain.Interfaces.Repositories;
using ProjetoDecode.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDecode.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DecodeContext _decodeContext;

        public RepositoryBase(DecodeContext decodeContext)
        {
            _decodeContext = decodeContext;
        }

        public void Add(T obj)
        {
            try
            {
                _decodeContext.Set<T>().Add(obj);
                _decodeContext.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _decodeContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _decodeContext.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            try
            {
                _decodeContext.Set<T>().Remove(obj);
                _decodeContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(T obj)
        {
            try
            {
                _decodeContext.Entry(obj).State = EntityState.Modified;
                _decodeContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
