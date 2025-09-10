using System.Net.Http;
using System.Text.Json;
using System.Web;
using MunicipalityServicesApplication.DataStructures;

namespace MunicipalityServicesApplication.Services.Geo
{
    public sealed class GeoLookupClient
    {
        private readonly HttpClient _http;
        private readonly GeoCache? _cache;

        public GeoLookupClient(HttpClient http, GeoCache? cache = null)
        {
            _http = http;
            _cache = cache;
            // Required by Nominatim usage policy
            _http.DefaultRequestHeaders.UserAgent.ParseAdd(
                "MunicipalityServicesApp-Jared/1.0 (ST10339829@vcconnect.edu.za)");
        }

        public async Task<NominatimPlace?> SearchAsync(string query, CancellationToken ct = default)
        {
            var q = (query ?? "").Trim();
            if (q.Length < 5) return null;

            if (_cache != null && _cache.TryGet(q, out var cachedJson))
            {
                var arrCached = JsonSerializer.Deserialize<NominatimPlace[]>(cachedJson);
                return arrCached != null && arrCached.Length > 0 ? arrCached[0] : null;
            }

            var url = $"https://nominatim.openstreetmap.org/search?format=json&limit=1&q={HttpUtility.UrlEncode(q)}";
            using var resp = await _http.GetAsync(url, ct).ConfigureAwait(false);
            if (!resp.IsSuccessStatusCode) return null;

            var json = await resp.Content.ReadAsStringAsync(ct).ConfigureAwait(false);
            _cache?.Put(q, json);

            var arr = JsonSerializer.Deserialize<NominatimPlace[]>(json);
            return arr != null && arr.Length > 0 ? arr[0] : null;
        }
    }
}
