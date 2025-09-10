using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalityServicesApplication.Services.Validation
{
    public sealed class ValidationSummary
    {
        private readonly List<(Control ctl, string msg)> _items = new();
        public bool HasErrors => _items.Count > 0;

        public void Add(Control control, string message) => _items.Add((control, message));
        public void Clear() => _items.Clear();

        public void ApplyTo(ErrorProvider provider)
        {
            provider.Clear();
            foreach (var (ctl, msg) in _items)
                provider.SetError(ctl, msg);
        }
    }

    public static class ValidationExtensions
    {
        public static ValidationSummary Bind(this (bool ok, string message) result,
                                             ErrorProvider provider, Control ctl)
        {
            if (!result.ok) provider.SetError(ctl, result.message);
            else provider.SetError(ctl, "");
            return new ValidationSummary();
        }
    }
}
