using System;
using MunicipalityServicesApplication.DataStructures;
using MunicipalityServicesApplication.Domain;

namespace MunicipalityServicesApplication.Infrastructure
{
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

        public void ForEach(Action<Issue> action) => _issues.ForEach(action);
    }
}
