﻿using Microsoft.EntityFrameworkCore;
using ApiMobile.Interfaces;
using ApiMobile.Models;
using System.Linq.Expressions;
using System.Security.Claims;

namespace ApiMobile.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public DbContext _context;
        public DbSet<T> dbSet;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();

        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public T GetFirst(Expression<Func<T, bool>> filter)
        {
            T data = dbSet.AsNoTracking().FirstOrDefault(filter);
            return data;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }



        IEnumerable<T> IBaseRepository<T>.GetAll()
        {
            return  dbSet.AsNoTracking().ToList();     
        }
    }
}
