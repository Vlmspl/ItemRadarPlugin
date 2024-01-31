using System.IO;
using System.Reflection;
using UnityEngine;

namespace ItemRadarPlugin.PluginBase
{
    internal class Assets
    {
        internal static AssetBundle? assetBundle;
        internal static GameObject? radarPrefab;        // Assuming you have a prefab for the radar
        internal static Texture2D? radarTexture1;      // First texture for the radar
        internal static Texture2D? radarTexture2;      // Second texture for the radar

        public static void Init()
        {
            // Modify the path to load the asset bundle from the "PluginBundles" folder
            string bundlePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "radar");

            assetBundle = AssetBundle.LoadFromFile(bundlePath);

            // Load the radar prefab and textures from the asset bundle
            radarPrefab = assetBundle?.LoadAsset<GameObject>("Radar.fbx");
            radarTexture1 = assetBundle?.LoadAsset<Texture2D>("Untitled.001.png");
            radarTexture2 = assetBundle?.LoadAsset<Texture2D>("EchoLocator.png");

            // Add more asset loading as needed
        }
    }
}
