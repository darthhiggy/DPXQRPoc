using DPXQRPoc.Data.DataModels;
using DPXQRPoc.Data.DbContexts;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Data.Repositories;

public class IsoTimestampRepository : RepositoryBase<IsoTimestampDataModel>, IIsoTimestampRepository
{

    public IsoTimestampRepository(DPXPocDbContext context) : base(context)
    {

    }

    public override IsoTimestampDataModel GetEntityById(int id) => Context.IsoTimestamps.FirstOrDefault(e => e.Id == id) ?? new IsoTimestampDataModel();

    public List<IsoTimestampDataModel> SearchEntity(string searchString) => Context.IsoTimestamps
        .Where(e => e.EventType.ToLower().Contains(searchString.ToLower()) 
                    || e.EventSource.ToLower().Contains(searchString.ToLower())).ToList();

}
