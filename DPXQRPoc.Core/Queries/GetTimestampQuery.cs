using DPXQRPoc.Core.Models;
using MediatR;

namespace DPXQRPoc.Core.Queries;

public class GetTimestampQuery : IRequest<IsoTimestamp>
{
    public int IsoTimestampId { get; set; }
}
