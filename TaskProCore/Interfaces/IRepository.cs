using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskProCore.Interfaces;

public interface IRepository<TEntity> : IDisposable where TEntity : class
{
    Task<TEntity> GetById(int id);
    Task<IEnumerable<TEntity>> GetAll();
    Task Add(TEntity entity);
    Task Update(TEntity entity);
    Task Remove(int id);
    Task <IEnumerable<TEntity>> Find(Func<TEntity, bool> predicate);
    Task<int> SaveChanges(); 
}