using System;

namespace MunicipalityServicesApplication.DataStructures
{
    public sealed class GeoCache
    {
        private sealed class Entry
        {
            public string Key;
            public string Value;
            public DateTime SeenUtc;
            public Entry(string k, string v) { Key = k; Value = v; SeenUtc = DateTime.UtcNow; }
        }

        private ForwardList<Entry> _items = new();
        private readonly int _capacity;
        private readonly TimeSpan _ttl;

        public GeoCache(int capacity = 20, TimeSpan? ttl = null)
        {
            _capacity = Math.Max(5, capacity);
            _ttl = ttl ?? TimeSpan.FromMinutes(30);
        }

        public bool TryGet(string key, out string? json)
        {
            json = null;
            Entry? match = null;
            _items.ForEach(e =>
            {
                if (e.Key.Equals(key, StringComparison.OrdinalIgnoreCase)) match = e;
            });
            if (match == null) return false;
            if (DateTime.UtcNow - match.SeenUtc > _ttl) return false;

            match.SeenUtc = DateTime.UtcNow;
            json = match.Value;
            return true;
        }

        public void Put(string key, string json)
        {
            int count = 0;
            Entry? oldest = null;
            _items.ForEach(e =>
            {
                count++;
                if (oldest == null || e.SeenUtc < oldest.SeenUtc) oldest = e;
            });

            if (count >= _capacity && oldest != null)
            {
                var newList = new ForwardList<Entry>();
                bool removed = false;
                _items.ForEach(e =>
                {
                    if (!removed && ReferenceEquals(e, oldest)) { removed = true; }
                    else newList.AddLast(e);
                });
                _items = newList;
            }

            _items.AddLast(new Entry(key, json));
        }
    }
}
