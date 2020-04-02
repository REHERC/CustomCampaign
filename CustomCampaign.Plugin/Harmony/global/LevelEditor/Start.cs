#pragma warning disable RCS1197, RCS1163, IDE0060
using Harmony;
using System;
using System.Text;

namespace CustomCampaign.Harmony
{
    [HarmonyPatch(typeof(global::LevelEditor), "Start")]
    internal static class StartLevelEditor
    {
        internal static void Postfix(global::LevelEditor __instance)
        {
            return;
            //foreach (var input in __instance.registeredInputEvents_)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append('=', 10);
            //    sb.Append('\n');
            //    sb.Append($"EVENT : {input.iEvent_}\n");
            //    sb.Append($"TOOL  : ");
            //    foreach (var type in input.types_)
            //    {
            //        sb.Append($"{type.Name} ({type.FullName});");
            //    }

            //    Console.WriteLine(sb.ToString());
            //}
        }
    }
}
