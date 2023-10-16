using HarmonyLib;
using Home.HomeScene;
using SML;
using UnityEditor.CrashReporting;

namespace CrashSuppressor
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
        {
            Utils.Logger.Log("ain't no way");
        }
    }

    [HarmonyPatch(typeof(HomeSceneController), "Start")]
    public class CrashReportSuppressor
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            CrashReportingSettings.enabled = false;
        }
    }

    public static class ModInfo
    {
        public const string PLUGIN_GUID = "CrashSuppressor";

        public const string PLUGIN_NAME = "CrashSuppressor";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}