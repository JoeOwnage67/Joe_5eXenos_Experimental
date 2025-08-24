using System;
using HarmonyLib;
using Verse;
using FacialAnimation;

namespace Joe_5eXenos.Diagnostics
{
    [HarmonyPatch(typeof(FacialAnimationGeneticHeads.Patch_HeadControllerComp), "InitializeIfNeed_Postfix")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_GeneticHeads_HeadControllerComp_Diagnostics
    {
        static void Postfix(FacialAnimation.HeadControllerComp __instance)
        {
            try
            {
                var pawnField = Traverse.Create(__instance).Field("pawn").GetValue();
                var faceTypeField = Traverse.Create(__instance).Field("faceType").GetValue();
                if (pawnField == null || faceTypeField == null)
                {
                    Log.Message("[5eXenos Diagnostics] GeneticHeads Postfix: pawn or faceType is null, skipping diagnostics.");
                }
                else
                {
                    Log.Message($"[5eXenos Diagnostics] GeneticHeads Postfix: pawn type={pawnField.GetType().FullName}, faceType type={faceTypeField.GetType().FullName}, faceType value={faceTypeField}");
                }
                // Log all fields and their types for cast diagnostics
                var fields = __instance.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                foreach (var field in fields)
                {
                    object value = null;
                    try { value = field.GetValue(__instance); }
                    catch { }
                    Log.Message($"[5eXenos CastDiagnostics] Field: {field.Name}, Type: {field.FieldType.FullName}, Value: {value}, ValueType: {value?.GetType().FullName}");
                }
            }
            catch (Exception ex)
            {
                Log.Error("[5eXenos Diagnostics] Error in GeneticHeads diagnostics postfix: " + ex);
            }
        }
    }
}
