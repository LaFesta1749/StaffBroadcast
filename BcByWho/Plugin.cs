using Exiled.API.Features;
using Exiled.Events;
using HarmonyLib;
using System;

namespace BcByWho
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public override string Author => "LaFesta1749";
        public override string Name => "BcByWho";
        public override Version Version => new Version(1, 0, 0);

        private Harmony harmony = new Harmony(id: "BroadcastPatch");

        public override void OnEnabled()
        {
            harmony.PatchAll();
            Singleton = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            harmony.UnpatchAll();
            base.OnDisabled();
        }
    }
}