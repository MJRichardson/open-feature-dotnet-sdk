namespace OpenFeature;

// https://github.com/open-feature/spec/blob/main/specification/flag-evaluation/flag-evaluation.md 
// This class is a singleton: https://github.com/open-feature/spec/blob/main/specification/flag-evaluation/flag-evaluation.md#requirement-111  
public sealed class OpenFeatureAPI
{
    static OpenFeatureAPI()
    {
        Provider = new NoOpFeatureProvider();
    }
    
    public static IFeatureProvider Provider
    {
        internal get;
        set;
    }

    public static FeatureProviderMetadata ProviderMetadata => Provider.Metadata;

    public static IClient GetClient()
    {
        return GetClient(null);
    }

    public static IClient GetClient(string? name)
    {
        return new Client(name);
    }
    
}