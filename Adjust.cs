using System;
using System.Collections.Generic;
using Harmony;
using UnityEngine;

namespace Patches
{ 
    [HarmonyPatch(typeof(ExteriorWallConfig), "CreateBuildingDef")]
    public static class ExteriorWallAdjust
    {

         public static void Postfix(ref BuildingDef __result)
         {
            __result.ConstructionTime = 3f;
            __result.BuildLocationRule = BuildLocationRule.Anywhere;

            __result.ReplacementTags = new List<Tag>
            {
                 //Who can tell me which TAG does the Drywall&Tempshift wall use
     
            };
            __result.EquivalentReplacementLayers = new List<ObjectLayer>
            {
                  ObjectLayer.ReplacementTile
            };
        }


    }


    [HarmonyPatch(typeof(ThermalBlockConfig), "CreateBuildingDef")]
    public static class TempShiftAdjust
    { 
        public static void Postfix(ref BuildingDef __result)
        { 
              __result.ConstructionTime = 3f;
        }
    }
}