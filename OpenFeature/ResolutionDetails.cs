namespace OpenFeature;

public class ResolutionDetails<TValue>
{
    public ResolutionDetails(TValue value)
    {
        Value = value;
    }
    
    public TValue Value { get; }
    public string? ErrorCode { get; set; }
    public string? Reason { get; set; }
    public string? Variant { get; set; }
    
}