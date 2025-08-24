using System.Linq;
using HarmonyLib;
using FacialAnimation;
using Verse;

namespace Joe_5eXenos
{
    // BrowType
    [HarmonyPatch(typeof(FaceTypeGenerator<BrowTypeDef>), "GetRandomDef")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_FaceTypeGenerator_Brow
    {
        static void Prefix(string raceName, Gender gender)
        {
            var headTypeDef = DefDatabase<FacialAnimation.HeadTypeDef>.GetNamedSilentFail(raceName);
            FacePartSelectionContext.CurrentFAHeadTypeDef = headTypeDef;
            FacePartSelectionContext.CurrentGender = gender;
            Log.Message($"[5eXenos] Set context: headTypeDef={raceName}, gender={gender}");
        }

        static void Postfix(ref BrowTypeDef __result, string raceName, Gender gender)
        {
            Log.Message("Harmony Brow Patch Applied");
            var headType = FacePartSelectionContext.CurrentFAHeadTypeDef;
            var pawnGender = FacePartSelectionContext.CurrentGender ?? gender;
            FacePartSelectionContext.CurrentFAHeadTypeDef = null;
            FacePartSelectionContext.CurrentGender = null;
            Log.Message("[5eXenos] Reset context");

            if (headType != null)
            {
                var allowed = headType.GetAllowedFaceParts();
                if (allowed != null && allowed.Count > 0)
                {
                    var allowedDefs = DefDatabase<BrowTypeDef>.AllDefs
                        .Where(def => allowed.Contains(def.defName) && (def.gender == pawnGender || (int)def.gender == 0))
                        .ToList();
                    if (allowedDefs.Count > 0)
                        __result = allowedDefs.RandomElement();
                }
            }
        }
    }

    // MouthType
    [HarmonyPatch(typeof(FaceTypeGenerator<MouthTypeDef>), "GetRandomDef")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_FaceTypeGenerator_Mouth
    {
        static void Prefix(string raceName, Gender gender)
        {
            var headTypeDef = DefDatabase<FacialAnimation.HeadTypeDef>.GetNamedSilentFail(raceName);
            FacePartSelectionContext.CurrentFAHeadTypeDef = headTypeDef;
            FacePartSelectionContext.CurrentGender = gender;
            Log.Message($"[5eXenos] Set context: headTypeDef={raceName}, gender={gender}");
        }

        static void Postfix(ref MouthTypeDef __result, string raceName, Gender gender)
        {
            Log.Message("Harmony Mouth Patch Applied");
            var headType = FacePartSelectionContext.CurrentFAHeadTypeDef;
            var pawnGender = FacePartSelectionContext.CurrentGender ?? gender;
            FacePartSelectionContext.CurrentFAHeadTypeDef = null;
            FacePartSelectionContext.CurrentGender = null;
            Log.Message("[5eXenos] Reset context");

            if (headType != null)
            {
                var allowed = headType.GetAllowedFaceParts();
                if (allowed != null && allowed.Count > 0)
                {
                    var allowedDefs = DefDatabase<MouthTypeDef>.AllDefs
                        .Where(def => allowed.Contains(def.defName) && (def.gender == pawnGender || (int)def.gender == 0))
                        .ToList();
                    if (allowedDefs.Count > 0)
                        __result = allowedDefs.RandomElement();
                }
            }
        }
    }

    // SkinType
    [HarmonyPatch(typeof(FaceTypeGenerator<SkinTypeDef>), "GetRandomDef")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_FaceTypeGenerator_Skin
    {
        static void Prefix(string raceName, Gender gender)
        {
            var headTypeDef = DefDatabase<FacialAnimation.HeadTypeDef>.GetNamedSilentFail(raceName);
            FacePartSelectionContext.CurrentFAHeadTypeDef = headTypeDef;
            FacePartSelectionContext.CurrentGender = gender;
            Log.Message($"[5eXenos] Set context: headTypeDef={raceName}, gender={gender}");
        }

        static void Postfix(ref SkinTypeDef __result, string raceName, Gender gender)
        {
            Log.Message("Harmony Skin Patch Applied");
            var headType = FacePartSelectionContext.CurrentFAHeadTypeDef;
            var pawnGender = FacePartSelectionContext.CurrentGender ?? gender;
            FacePartSelectionContext.CurrentFAHeadTypeDef = null;
            FacePartSelectionContext.CurrentGender = null;
            Log.Message("[5eXenos] Reset context");

            if (headType != null)
            {
                var allowed = headType.GetAllowedFaceParts();
                if (allowed != null && allowed.Count > 0)
                {
                    var allowedDefs = DefDatabase<SkinTypeDef>.AllDefs
                        .Where(def => allowed.Contains(def.defName) && (def.gender == pawnGender || (int)def.gender == 0))
                        .ToList();
                    if (allowedDefs.Count > 0)
                        __result = allowedDefs.RandomElement();
                }
            }
        }
    }

    // LidType
    [HarmonyPatch(typeof(FaceTypeGenerator<LidTypeDef>), "GetRandomDef")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_FaceTypeGenerator_Lid
    {
        static void Prefix(string raceName, Gender gender)
        {
            var headTypeDef = DefDatabase<FacialAnimation.HeadTypeDef>.GetNamedSilentFail(raceName);
            FacePartSelectionContext.CurrentFAHeadTypeDef = headTypeDef;
            FacePartSelectionContext.CurrentGender = gender;
            Log.Message($"[5eXenos] Set context: headTypeDef={raceName}, gender={gender}");
        }

        static void Postfix(ref LidTypeDef __result, string raceName, Gender gender)
        {
            Log.Message("Harmony Lid Patch Applied");
            var headType = FacePartSelectionContext.CurrentFAHeadTypeDef;
            var pawnGender = FacePartSelectionContext.CurrentGender ?? gender;
            FacePartSelectionContext.CurrentFAHeadTypeDef = null;
            FacePartSelectionContext.CurrentGender = null;
            Log.Message("[5eXenos] Reset context");

            if (headType != null)
            {
                var allowed = headType.GetAllowedFaceParts();
                if (allowed != null && allowed.Count > 0)
                {
                    var allowedDefs = DefDatabase<LidTypeDef>.AllDefs
                        .Where(def => allowed.Contains(def.defName) && (def.gender == pawnGender || (int)def.gender == 0))
                        .ToList();
                    if (allowedDefs.Count > 0)
                        __result = allowedDefs.RandomElement();
                }
            }
        }
    }

    // EyeType
    [HarmonyPatch(typeof(FaceTypeGenerator<EyeballTypeDef>), "GetRandomDef")]
    [HarmonyAfter("sd.geneticheads.patch")]
    public static class Patch_FaceTypeGenerator_Eye
    {
        static void Prefix(string raceName, Gender gender)
        {
            var headTypeDef = DefDatabase<FacialAnimation.HeadTypeDef>.GetNamedSilentFail(raceName);
            FacePartSelectionContext.CurrentFAHeadTypeDef = headTypeDef;
            FacePartSelectionContext.CurrentGender = gender;
            Log.Message($"[5eXenos] Set context: headTypeDef={raceName}, gender={gender}");
        }

        static void Postfix(ref EyeballTypeDef __result, string raceName, Gender gender)
        {
            Log.Message("Harmony Eye Patch Applied");
            var headType = FacePartSelectionContext.CurrentFAHeadTypeDef;
            var pawnGender = FacePartSelectionContext.CurrentGender ?? gender;
            FacePartSelectionContext.CurrentFAHeadTypeDef = null;
            FacePartSelectionContext.CurrentGender = null;
            Log.Message("[5eXenos] Reset context");

            if (headType != null)
            {
                var allowed = headType.GetAllowedFaceParts();
                if (allowed != null && allowed.Count > 0)
                {
                    var allowedDefs = DefDatabase<EyeballTypeDef>.AllDefs
                        .Where(def => allowed.Contains(def.defName) && (def.gender == pawnGender || (int)def.gender == 0))
                        .ToList();
                    if (allowedDefs.Count > 0)
                        __result = allowedDefs.RandomElement();
                }
            }
        }
    }
}