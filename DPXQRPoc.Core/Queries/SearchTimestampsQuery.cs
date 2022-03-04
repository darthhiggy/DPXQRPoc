using DPXQRPoc.Core.Models;
using MediatR;

namespace DPXQRPoc.Core.Queries;

public class SearchTimestampsQuery : IRequest<List<IsoTimestamp>>
{
    public string SearchString { get; set; }
}
