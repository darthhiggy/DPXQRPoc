using DPXQRPoc.Core.Models;
using MediatR;

namespace DPXQRPoc.Core.Commands;

public class AddTimestampCommand : IRequest<IsoTimestamp>
{
    public IsoTimestamp TimeStamp { get; set; }
}
