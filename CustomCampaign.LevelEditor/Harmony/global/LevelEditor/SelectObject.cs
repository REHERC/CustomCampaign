using System;
using System.Collections.Generic;
using Harmony;
using UnityEngine;

namespace CustomCampaign.LevelEditor.Harmony
{
    [HarmonyPatch(typeof(global::LevelEditor), "SelectObject")]
    internal static class SelectObject
    {
        internal static bool Prefix(global::LevelEditor __instance, ref bool __result, ref GameObject newObj)
        {
            if (newObj is null)
            {
                Debug.LogWarning("Trying to select a null object");
                __result = false;
                return false;
            }
            if (!newObj.transform.IsRoot() && false)
            {
                Debug.LogWarning("Trying to select a child object");
                __result = false;
                return false;
            }
            if (!__instance.selectedObjects_.Contains(newObj))
            {
                LevelLayer layerOfObject = __instance.workingLevel_.GetLayerOfObject(newObj);
                if (layerOfObject != null && !layerOfObject.Frozen_)
                {
                    __instance.AddObjectToSelectedList(newObj);
                    __result = true;
                    return false;
                }
            }
            else
            {
                __instance.SetActiveObject(newObj);
            }

            __result = false;
            return false;
        }
    }
}
