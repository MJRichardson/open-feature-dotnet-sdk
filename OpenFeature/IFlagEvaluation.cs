namespace OpenFeature;

public interface IFlagEvaluation
{
   bool GetBooleanValue(string key, bool defaultValue);
}