using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iRacingSdkWrapper;

namespace OverlayWeb.Data
{
    public class SdkService
    {
        public SdkWrapper Wrapper { get; }

        public SdkService()
        {
            Wrapper = new SdkWrapper();
            Wrapper.TelemetryUpdated += OnTelemetryUpdated;
            Wrapper.SessionInfoUpdated += OnSessionInfoUpdated;
        }

        private static void OnSessionInfoUpdated(object sender, SdkWrapper.SessionInfoUpdatedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OnTelemetryUpdated(object sender, SdkWrapper.TelemetryUpdatedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
