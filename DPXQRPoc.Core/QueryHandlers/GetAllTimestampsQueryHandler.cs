using AutoMapper;
using DPXQRPoc.Core.Helpers.BaseClasses;
using DPXQRPoc.Core.Models;
using DPXQRPoc.Core.Queries;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Core.QueryHandlers;

public class GetAllTimestampsQueryHandler : IsoTimestampHandlerBase<GetAllTimestampsQuery, List<IsoTimestamp>>
{
    public GetAllTimestampsQueryHandler(IMapper mapper, IIsoTimestampRepository repository)
        : base(mapper, repository)
    {
    }

    public override Task<List<IsoTimestamp>> Handle(GetAllTimestampsQuery request, CancellationToken cancellationToken)
    {
        return new Task<List<IsoTimestamp>>(
        () => Mapper.Map<List<IsoTimestamp>>(Repository.GetAll()));
    }
}
