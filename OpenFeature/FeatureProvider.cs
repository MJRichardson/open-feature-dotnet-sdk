namespace OpenFeature;

public interface IFeatureProvider
{
    FeatureProviderMetadata Metadata { get; }

    ResolutionDetails<bool> ResolveBooleanValue(string key);
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
    public NoOpFeatureProvider()
    {
        Metadata = new FeatureProviderMetadata("No-Op Provider");
    }
    
    public FeatureProviderMetadata Metadata { get; }
    
    public ResolutionDetails<bool> ResolveBooleanValue(string key)
    {
        throw new NotImplementedException();
    }
}