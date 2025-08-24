using HarmonyLib;
using Verse;

namespace Joe_5eXenos
{
    [StaticConstructorOnStartup]
    public static class HarmonyInit
    {
        static HarmonyInit()
        {
            var harmony = new Harmony("Joe_5eXenos.HarmonyPatches");
            harmony.PatchAll();
        }
    }
}