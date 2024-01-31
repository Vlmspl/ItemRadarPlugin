using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;

namespace ItemRadarPlugin
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "poseidon.itemradar";
        private const string modName = "Item Radar Plugin";
        private const string modVersion = "1.0.0";

        private static Plugin instance;
        internal ManualLogSource logger;

        private readonly Harmony harmony = new Harmony(modGUID);

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }

            logger = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            logger.LogInfo("Initializing ItemRadar Plugin...");

            // Additional initialization code if needed

            RegisterPatches();
            RegisterNetworking();
            RegisterItems();

            logger.LogInfo("ItemRadarPlugin:1.0.0 has successfully loaded!");
        }

        private void RegisterPatches()
        {
            logger.LogInfo("Applying patches.");
            
            // Add other patches as needed
        }

        private void RegisterNetworking()
        {
            logger.LogInfo("Doing networky stuff");
            
        }

        private void RegisterItems()
        {
            logger.LogInfo("Registering Items");
            
        }
    }
}
