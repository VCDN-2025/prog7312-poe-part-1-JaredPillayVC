using System;
using System.IO;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;

namespace MunicipalityServicesApplication.Infrastructure
{
    /// <summary>
    /// Handles flat-file persistence of issues and attachments under a configured root folder.
    /// </summary>
    public sealed class FlatFileRepository
    {
        private readonly string _root;

        public FlatFileRepository(string root)
        {
            _root = root;
            Directory.CreateDirectory(_root);
            Directory.CreateDirectory(Path.Combine(_root, "issues"));
            Directory.CreateDirectory(Path.Combine(_root, "attachments"));
        }

        /// <summary>
        /// Saves an issue to disk as a simple text record and returns the file path.
        /// </summary>
        public string SaveIssue(Issue issue)
        {
            var path = Path.Combine(_root, "issues", issue.TicketId + ".txt");
            using var sw = new StreamWriter(path);

            sw.WriteLine(issue.TicketId);
            sw.WriteLine(issue.CreatedUtc.ToString("O"));
            sw.WriteLine(issue.Category.ToString());
            sw.WriteLine(issue.Location.Replace('\n', ' '));
            sw.WriteLine(issue.Description.Replace('\n', ' '));

            int count = 0;
            issue.Attachments.ForEach(_ => count++);
            sw.WriteLine(count);

            issue.Attachments.ForEach(a =>
                sw.WriteLine($"{a.StoredPath}|{a.OriginalPath}|{a.SizeBytes}")
            );

            return path;
        }

        /// <summary>
        /// Copies an attachment into the attachments folder and returns the stored path.
        /// </summary>
        public string StoreAttachment(string sourcePath)
        {
            var fileName = Path.GetFileName(sourcePath);
            var destPath = Path.Combine(
                _root,
                "attachments",
                Guid.NewGuid().ToString("N") + "_" + fileName
            );

            File.Copy(sourcePath, destPath, overwrite: false);
            return destPath;
        }
    }
}
