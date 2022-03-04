using AutoMapper;
using MediatR;

namespace DPXQRPoc.Core.Helpers.BaseClasses;

public abstract class HandlerBase<TQ, T> : IRequestHandler<TQ, T> where TQ : IRequest<T>
{
    protected readonly IMapper Mapper;

    protected HandlerBase(IMapper mapper)
    {
        Mapper = mapper;

    }

    public abstract Task<T> Handle(TQ request, CancellationToken cancellationToken);
}
