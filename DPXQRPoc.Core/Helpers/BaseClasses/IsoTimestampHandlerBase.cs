using AutoMapper;
using DPXQRPoc.Data.Repositories.Interfaces;

namespace DPXQRPoc.Core.Helpers.BaseClasses;

public abstract class IsoTimestampHandlerBase<TQ, T> : HandlerBase<TQ, T> where TQ : MediatR.IRequest<T>
{
    protected readonly IIsoTimestampRepository Repository;

    protected IsoTimestampHandlerBase(IMapper mapper, IIsoTimestampRepository repository) 
        : base(mapper)
    {
        Repository = repository;
    }
    
}
