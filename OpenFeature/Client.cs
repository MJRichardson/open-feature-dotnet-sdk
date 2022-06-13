namespace OpenFeature;

public interface IClient : IFlagEvaluation
{
    ClientMetadata Metadata { get; }
}

public class ClientMetadata 
{
    internal ClientMetadata(string? name)
    {
        Name = name;
    }
    
    public string? Name { get; }
}

sealed class Client : IClient
{
    internal Client(string? name)
    {
        Metadata = new ClientMetadata(name);
    }

    public ClientMetadata Metadata { get; }

    public bool GetBooleanValue(string key, bool defaultValue)
    {
        return OpenFeature.Provider.ResolveBooleanValue(key, defaultValue).Value;
    }
}