using System.Collections.Generic;
using FacialAnimation;
using Verse;

namespace Joe_5eXenos
{
    public static class HeadTypeDefExtensions
    {
        public static List<string> GetAllowedFaceParts(this FacialAnimation.HeadTypeDef headTypeDef)
        {
            var ext = headTypeDef.GetModExtension<AllowedFacePartsExtension>();
            return ext?.allowedFaceParts ?? new List<string>();
        }
    }
}