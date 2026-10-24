using System.Reflection;
using BepInEx;
using HarmonyLib;

namespace AlchemyProps;
#nullable disable

[BepInPlugin(ModGUID, ModName, ModVersion)]
public class AlchemyPropsPlugin : BaseUnityPlugin
{
    internal const string ModName = "AlchemyProps";
    internal const string ModVersion = "1.0.0";
    internal const string Author = "RustyMods";
    public const string ModGUID = Author + "." + ModName;
    public readonly Harmony _harmony = new(ModGUID);
    public static Harmony harmony => instance._harmony;

    public static AlchemyPropsPlugin instance;

    public void Awake()
    {
        instance = this;
        // ReadMeBuilder.Init(false);
        VersionHandshake.Init();
        Assets.Setup();

        var assembly = Assembly.GetExecutingAssembly();
        _harmony.PatchAll(assembly);
    }

    private void OnDestroy()
    {
        Config.Save();
    }

    public static void LogDebug(string msg)
    {
        instance.Logger.LogDebug(msg);
    }

    public static void LogWarning(string msg)
    {
        instance.Logger.LogWarning(msg);
    }

    public static void LogError(string msg)
    {
        instance.Logger.LogError(msg);
    }

    public static void LogInfo(string msg)
    {
        instance.Logger.LogInfo(msg);
    }
}