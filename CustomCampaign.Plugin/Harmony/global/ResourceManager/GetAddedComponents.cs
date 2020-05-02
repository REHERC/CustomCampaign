using CustomCampaign.LevelEditor.Attributes;
using Harmony;
using System;
using System.Collections.Generic;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(ResourceManager), "GetAddedComponents")]
    public static class ResourceManager_GetAddedComponents
    {
        public static void Postfix(ref AddedComponent[] __result)
        {
            List<AddedComponent> __output = new List<AddedComponent>();

            foreach (AddedComponent Component in __result)
            {
                Type ComponentType = Component.GetType();

                bool KeepComponent = true;

                foreach (Attribute ComponentAttribute in ComponentType.GetCustomAttributes(true))
                {
                    switch (ComponentAttribute)
                    {
                        case HideComponentAttribute HideComponent:
                            KeepComponent = false;
                            break;
                    }
                }

                if (KeepComponent)
                {
                    __output.Add(Component);
                }
            }

            __result = __output.ToArray();
        }
    }
}
