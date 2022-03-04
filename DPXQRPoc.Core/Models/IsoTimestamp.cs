namespace DPXQRPoc.Core.Models;

public class IsoTimestamp
{
    // we will also add Data annotations to limit text size  
    public int Id { get; set; } = 0;
    public string EventType { get; set; } = string.Empty;
    public string EventSource { get; set; } = string.Empty;
    public DateTime EventTime { get; set; } = DateTime.Now;
    public Guid PaymentGuid { get; set; } = Guid.Empty;
    public Guid FileGuid { get; set; } = Guid.Empty;
    // This should be its own list of Object type payment where we should convert into a JSON object that is saved as an NVARCHAR(Max)
    public string PaymentInfo { get; set; } = string.Empty;
}
