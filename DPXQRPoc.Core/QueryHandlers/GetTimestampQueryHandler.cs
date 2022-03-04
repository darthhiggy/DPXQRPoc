using AutoMapper;
using DPXQRPoc.Core.Helpers.BaseClasses;
using DPXQRPoc.Core.Models;
using DPXQRPoc.Core.Queries;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Core.QueryHandlers;

public class GetTimestampQueryHandler : IsoTimestampHandlerBase<GetTimestampQuery, IsoTimestamp>
{

    public GetTimestampQueryHandler(IMapper mapper, IIsoTimestampRepository repository) : base(mapper, repository)
    {
    }
    public override Task<IsoTimestamp> Handle(GetTimestampQuery request, CancellationToken cancellationToken)
    {
        return new Task<IsoTimestamp>(() =>
            Mapper.Map<IsoTimestamp>(Repository.GetEntityById(request.IsoTimestampId)));
    }
}
