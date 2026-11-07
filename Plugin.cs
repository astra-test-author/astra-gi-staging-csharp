using BepInEx;

namespace AstraGiStagingCsharp
{
    /// <summary>
    /// A staging TEST game integration: not for players. It exists only to rehearse the games
    /// catalogue's "non-owner publishes and signs" done-when, end to end, as a real third-party
    /// author would have to. It logs one line at Awake and does nothing else.
    /// </summary>
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogInfo("astra-gi-staging-csharp: staging test GI loaded (not for players)");
        }
    }
}
