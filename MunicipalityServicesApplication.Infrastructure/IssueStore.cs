using System;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;

namespace MunicipalityServicesApplication.Infrastructure
{
    /// <summary>
    /// In-memory store backed by a custom ForwardList that mirrors writes to the flat-file repository.
    /// </summary>
    public sealed class IssueStore
    {
        private readonly ForwardList<Issue> _issues = new();
        private readonly FlatFileRepository _repo;

        public IssueStore(FlatFileRepository repo)
        {
            _repo = repo;
        }

        public void Add(Issue issue)
        {
            _issues.AddLast(issue);
            _repo.SaveIssue(issue);
        }

        public string StoreAttachment(string path) => _repo.StoreAttachment(path);

        public ForwardList<Issue> GetAll() => _issues;
    }
}
