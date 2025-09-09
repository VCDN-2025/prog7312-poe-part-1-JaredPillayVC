namespace MunicipalityServicesApplication.Domain
{
    public sealed class Attachment
    {
        public string OriginalPath { get; }
        public string StoredPath { get; }
        public long SizeBytes { get; }

        public Attachment(string originalPath, string storedPath, long sizeBytes)
        {
            OriginalPath = originalPath;
            StoredPath = storedPath;
            SizeBytes = sizeBytes;
        }
    }
}
