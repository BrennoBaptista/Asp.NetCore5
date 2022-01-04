using Microsoft.EntityFrameworkCore;
using RestApi.Model.Base;
using RestApi.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> _dataSet;

        public GenericRepository(MySqlContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public T Create(T obj)
        {
            try
            {
                _dataSet.Add(obj);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindAll()
        {
            return _dataSet.ToList();
        }

        public T FindByID(long id)
        {
            return _dataSet.SingleOrDefault(t => t.Id.Equals(id));
        }

        public T Update(T obj)
        {
            if (!Exists(obj.Id)) return null;

            var result = _dataSet.SingleOrDefault(t => t.Id.Equals(obj.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(obj);
                    _context.SaveChanges();
                    return obj;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var result = _dataSet.SingleOrDefault(t => t.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _dataSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _dataSet.Any(t => t.Id.Equals(id));
        }
    }
}
