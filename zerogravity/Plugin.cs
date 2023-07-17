using BepInEx;
using BepInEx.Configuration;

namespace zerogravity
{
    [BepInPlugin(("weitao.mm." + PluginInfo.PLUGIN_GUID), PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private ConfigEntry<float> gravityconfigX;
        private ConfigEntry<float> gravityconfigY;
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            gravityconfigX = Config.Bind("config","gravityconfigX",(float)0);gravityconfigY = Config.Bind("config","gravityconfigY",(float)-0.5);
            UnityEngine.Physics2D.gravity = new UnityEngine.Vector2(gravityconfigX.Value,gravityconfigY.Value);

        }
    }
}
