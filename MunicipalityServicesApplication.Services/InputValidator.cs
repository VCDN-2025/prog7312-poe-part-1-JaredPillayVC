using System.IO;

namespace MunicipalityServicesApplication.Services
{
    /// <summary>
    /// Centralized validation helpers for inputs (location, category, description, attachment).
    /// </summary>
    public static class InputValidator
    {
        /// <summary>
        /// Validates location text for presence and length limits.
        /// </summary>
        public static (bool ok, string error) Location(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return (false, "Location is required.");
            if (value.Length < 5) return (false, "Location must be at least 5 characters.");
            if (value.Length > 80) return (false, "Location max length is 80.");
            return (true, "");
        }

        /// <summary>
        /// Ensures description contains at least the minimum number of words.
        /// </summary>
        public static (bool ok, string error) Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return (false, "Description is required.");
            var words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            if (words < 20) return (false, "Description must be at least 20 words.");
            return (true, "");
        }

        /// <summary>
        /// Checks attachment extension and size against allowed constraints.
        /// </summary>
        public static (bool ok, string error) Attachment(string path, long maxBytes = 10 * 1024 * 1024)
        {
            var allowed = new[] { ".jpg", ".jpeg", ".png", ".heic", ".pdf" };
            var ext = Path.GetExtension(path).ToLowerInvariant();
            if (!allowed.Contains(ext)) return (false, "Invalid file type.");
            var fi = new FileInfo(path);
            if (!fi.Exists) return (false, "File not found.");
            if (fi.Length > maxBytes) return (false, "File too large (max 10MB).");
            return (true, "");
        }
    }
}
