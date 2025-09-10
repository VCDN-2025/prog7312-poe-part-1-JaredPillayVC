namespace MunicipalityServicesApplication.Services.Geo
{
    // Minimal model for Nominatim /search?format=json
    public sealed class NominatimPlace
    {
        public string? display_name { get; set; }
        public string? lat { get; set; }
        public string? lon { get; set; }
        public double? importance { get; set; }
    }
}
