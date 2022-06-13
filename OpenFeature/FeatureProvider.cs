namespace OpenFeature;

public interface IFeatureProvider
{
    FeatureProviderMetadata Metadata { get; }

    ResolutionDetails<bool> ResolveBooleanValue(string key, bool defaultValue);
}

public class FeatureProviderMetadata
{
    internal FeatureProviderMetadata(string name)
    {
        Name = name;
    }
    
    string Name { get; }
}

// A no-op implementation of IFeatureProvider
internal class NoOpFeatureProvider : IFeatureProvider
{
    const string Reason = "DEFAULT";
    const string Variant = "Passed in default"; 
    
    public NoOpFeatureProvider()
    {
        Metadata = new FeatureProviderMetadata("No-Op Provider");
    }
    
    public FeatureProviderMetadata Metadata { get; }
    
    public ResolutionDetails<bool> ResolveBooleanValue(string key, bool defaultValue)
    {
        return new ResolutionDetails<bool>(defaultValue) { Reason = Reason, Variant = Variant};
    }
}