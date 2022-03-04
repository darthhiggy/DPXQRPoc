using AutoMapper;
using DPXQRPoc.Core.Commands;
using DPXQRPoc.Core.Helpers.BaseClasses;
using DPXQRPoc.Core.Models;
using DPXQRPoc.Data.DataModels;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Core.CommandHandlers;

public class AddTimestampCommandHandler : IsoTimestampHandlerBase<AddTimestampCommand, IsoTimestamp>
{

    public AddTimestampCommandHandler(IMapper mapper, IIsoTimestampRepository repository) : base(mapper, repository)
    {
    }
    
    public override Task<IsoTimestamp> Handle(AddTimestampCommand request, CancellationToken cancellationToken)
    {
        var timeStamp = Repository.AddEntity(Mapper.Map<IsoTimestampDataModel>(request.TimeStamp));
        Repository.SaveChanges();
        return new Task<IsoTimestamp>(() => Mapper.Map<IsoTimestamp>(timeStamp));
    }
}
