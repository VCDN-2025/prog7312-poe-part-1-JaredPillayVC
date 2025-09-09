namespace MunicipalityServicesApplication.Services
{
    /// <summary>
    /// Generates unique, human-readable ticket identifiers for submitted issues.
    /// </summary>
    public static class TicketIdFactory
    {
        public static string NewId()
        {
            var ts = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            var rand = Guid.NewGuid().ToString("N")[..6].ToUpperInvariant();
            return $"MAPP-{ts}-{rand}";
        }
    }
}
