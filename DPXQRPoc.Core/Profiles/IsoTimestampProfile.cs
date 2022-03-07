using AutoMapper;
using DPXQRPoc.Core.Models;
using DPXQRPoc.Data.DataModels;
using DPXQRPoc.MessageBussWorker.Messages;

namespace DPXQRPoc.Core.Profiles;

public class IsoTimestampProfile : Profile
{
    public IsoTimestampProfile()
    {
        CreateMap<IsoTimestamp, IsoTimestampDataModel>().ReverseMap();
        CreateMap<IsoTimestampMessage, IsoTimestamp>().ReverseMap();
    }
}
