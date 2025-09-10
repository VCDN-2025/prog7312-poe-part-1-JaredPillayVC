using System;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace MunicipalityServicesApplication.App
{
    internal sealed class Debounce
    {
        private readonly WinFormsTimer _timer = new() { Interval = 350 };
        private Action? _action;

        public Debounce()
        {
            _timer.Tick += (_, __) =>
            {
                _timer.Stop();
                _action?.Invoke();
            };
        }

        public void Run(Action action, int ms = 350)
        {
            _action = action;
            _timer.Interval = ms;
            _timer.Stop();
            _timer.Start();
        }
    }
}
