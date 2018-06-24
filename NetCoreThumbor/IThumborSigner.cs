namespace NetCoreThumbor
{
    public interface IThumborSigner
    {
        string Encode(string input, string key);
    }
}
