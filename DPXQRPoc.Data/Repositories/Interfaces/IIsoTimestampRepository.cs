using DPXQRPoc.Core.Interfaces;
using DPXQRPoc.Data.DbContexts;

namespace DPXQRPoc.Core.Models;

public interface IIsoTimestampRepository : IRepository
{
    List<IsoTimestamp> GetAllTimestamps();
    IsoTimestamp GetTimestampById(int id);
    List<IsoTimestamp> SearchTimestamp(string searchString);
    void AddTimeStamp(IsoTimestamp timeStamp);
}
