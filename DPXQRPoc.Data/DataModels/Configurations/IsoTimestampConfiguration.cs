using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DPXQRPoc.Data.DataModels.Configurations;

public class IsoTimestampConfiguration : IEntityTypeConfiguration<IsoTimestampDataModel>
{

    public void Configure(EntityTypeBuilder<IsoTimestampDataModel> builder)
    {
        builder.ToTable("IsoTimestamps");
        
        // this is where we would/will put a conversion of the PaymentInfo as a list of objects into a JSON String
        //builder.Property(e => e.PaymentInfo).HasConversion(v => JsonConverter.SerializeObject(v), v => JsonConverter.DeserializeObject<List<PaymentInfo>>(v));
    }
}
