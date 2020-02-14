using System;
using iRacingSdkWrapper;
using iRacingSimulator;

namespace OverlayWeb.Services
{
    public class SdkService
    {
        public event Action Updated;

        public SdkService()
        {
            Sim.Instance.Sdk.TelemetryUpdated += OnTelemetryUpdated;
            Sim.Instance.Sdk.SessionInfoUpdated += OnSessionInfoUpdated;
        }

        private void OnSessionInfoUpdated(object sender, SdkWrapper.SessionInfoUpdatedEventArgs e)
        {
            Updated?.Invoke();
        }

        private void OnTelemetryUpdated(object sender, SdkWrapper.TelemetryUpdatedEventArgs e)
        {
            Updated?.Invoke();
        }
    }
}
