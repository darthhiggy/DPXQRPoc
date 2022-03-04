using AutoMapper;
using DPXQRPoc.Core.Helpers.BaseClasses;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Core.CommandHandlers.BaseHandlers;

public abstract class IsoTimestampHandlerBase<TQ, T> : HandlerBase<TQ, T> where TQ : MediatR.IRequest<T>
{
    protected readonly IIsoTimestampRepository Repository;

    protected IsoTimestampHandlerBase(IMapper mapper, IIsoTimestampRepository repository) 
        : base(mapper)
    {
        Repository = repository;
    }
    
}
