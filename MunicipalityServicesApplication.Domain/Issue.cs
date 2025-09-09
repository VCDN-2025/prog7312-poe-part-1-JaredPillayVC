using MunicipalityServicesApplication.DataStructures;

namespace MunicipalityServicesApplication.Domain
{
    public sealed class Issue
    {
        public string TicketId { get; }
        public string Location { get; }
        public IssueCategory Category { get; }
        public string Description { get; }
        public DateTime CreatedUtc { get; }
        public ForwardList<Attachment> Attachments { get; }

        /// <summary>
        /// A persisted municipal service issue with ticket id, details, and a custom list of attachments.
        /// </summary>
        public Issue(string ticketId, string location, IssueCategory category, string description, DateTime createdUtc, ForwardList<Attachment> attachments)
        {
            TicketId = ticketId;
            Location = location;
            Category = category;
            Description = description;
            CreatedUtc = createdUtc;
            Attachments = attachments;
        }
    }
}
