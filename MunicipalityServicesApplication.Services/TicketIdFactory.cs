namespace MunicipalityServicesApplication.Services
{
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
