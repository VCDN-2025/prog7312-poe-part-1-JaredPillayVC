namespace MunicipalityServicesApplication.Domain
{
    public sealed class Attachment
    {
        public string OriginalPath { get; }
        public string StoredPath { get; }
        public long SizeBytes { get; }

        /// <summary>
        /// Metadata for a stored attachment, including original and persisted file paths with size in bytes.
        /// </summary>
        public Attachment(string originalPath, string storedPath, long sizeBytes)
        {
            OriginalPath = originalPath;
            StoredPath = storedPath;
            SizeBytes = sizeBytes;
        }
    }
}
