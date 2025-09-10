using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;

namespace MunicipalityServicesApplication.Services.Validation
{
    public static class FieldRules
    {
        public static (bool ok, string message) RequireLocation(string value, ValidationSummary sum)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                sum.Add(null!, "Location is required.");
                return (false, "Location is required.");
            }
            if (value.Trim().Length < 5)
            {
                sum.Add(null!, "Please enter at least 5 characters.");
                return (false, "Please enter at least 5 characters.");
            }
            return (true, "");
        }

        public static (bool ok, string message) RequireCategory(object? selected, ValidationSummary sum)
        {
            if (selected == null) { sum.Add(null!, "Please choose a category."); return (false, "Please choose a category."); }
            return (true, "");
        }

        public static (bool ok, string message) DescriptionMinWords(string value, int min, ValidationSummary sum)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                sum.Add(null!, "Description is required.");
                return (false, "Description is required.");
            }
            var words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            if (words < min)
            {
                sum.Add(null!, $"Description should be at least {min} words.");
                return (false, $"Description should be at least {min} words.");
            }
            return (true, "");
        }

        public static (bool ok, string message) CheckAttachments(ForwardList<Attachment> attachments, ValidationSummary sum)
        {
            // Validate extensions + size; ForwardList only
            bool bad = false;
            attachments.ForEach(a =>
            {
                var ext = Path.GetExtension(a.OriginalPath).ToLowerInvariant();
                if (ext is not (".jpg" or ".jpeg" or ".png" or ".heic" or ".pdf"))
                { sum.Add(null!, "Only jpg, jpeg, png, heic, pdf allowed."); bad = true; }

                if (a.SizeBytes > 10 * 1024 * 1024)
                { sum.Add(null!, "Each file must be ≤ 10MB."); bad = true; }
            });
            return bad ? (false, "Invalid attachment(s).") : (true, "");
        }
    }
}
