using DPXQRPoc.Data.DbContexts;
using DPXQRPoc.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DPXQRPoc.Data.Repositories;

public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class 
{
    protected readonly DPXPocDbContext Context;

    protected RepositoryBase(DPXPocDbContext context)
    {
        Context = context;

    }
    public List<TEntity> GetAll() => Context.Set<TEntity>().AsNoTracking().ToList();
    
    public virtual TEntity GetEntityById(int id)
    {
        throw new NotImplementedException();
    }
    public virtual List<TEntity> SearchEntity(string searchString)
    {
        throw new NotImplementedException();
    }
    public TEntity AddEntity(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
        return entity;
    }

    public void SaveChanges() => Context.SaveChanges();
}
