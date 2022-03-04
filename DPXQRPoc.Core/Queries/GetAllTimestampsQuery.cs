using DPXQRPoc.Core.Models;
using MediatR;

namespace DPXQRPoc.Core.Queries;

public class GetAllTimestampsQuery : IRequest<List<IsoTimestamp>>
{
    
}
