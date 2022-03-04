namespace DPXQRPoc.Data.Repositories.Interfaces;

public interface IRepository<TEntity>
{
    List<TEntity> GetAll();
    TEntity GetEntityById(int id);
    List<TEntity> SearchEntity(string searchString);
    TEntity AddEntity(TEntity entity);
    void SaveChanges();
}
