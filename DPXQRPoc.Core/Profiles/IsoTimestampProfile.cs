using AutoMapper;
using DPXQRPoc.Core.Models;
using DPXQRPoc.Data.DataModels;

namespace DPXQRPoc.Core.Profiles;

public class IsoTimestampProfile : Profile
{
    public IsoTimestampProfile()
    {
        CreateMap<IsoTimestamp, IsoTimestampDataModel>().ReverseMap();
    }
}
