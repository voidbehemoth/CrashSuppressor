using System;

namespace CrashSuppressor.Utils
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("[" + CrashSuppressor.ModInfo.PLUGIN_GUID + "] " + message);
        }
    }
}
