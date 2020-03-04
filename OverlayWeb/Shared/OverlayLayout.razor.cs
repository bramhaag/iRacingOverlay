using System;
using System.Collections.Generic;
using iRacingSimulator;
using iRacingSimulator.Drivers;
using Microsoft.AspNetCore.Components;
using OverlayWeb.Services;

namespace OverlayWeb.Shared
{
    public class OverlayLayoutBase : LayoutComponentBase
    {
        [Inject] public SdkService Sdk { get; set; }

        public List<Driver> Drivers => Sim.Instance.Drivers;
        public Track Track => Sim.Instance.SessionData.Track;

        public OverlayLayoutBase()
        {
            Sdk.Updated += OnUpdate;
        }

        public void OnUpdate()
        {
            this.StateHasChanged();
        }
    }
}
