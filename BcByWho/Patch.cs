using CommandSystem;
using CommandSystem.Commands.RemoteAdmin.Broadcasts;
using HarmonyLib;
using System;
using System.Text.RegularExpressions;
using Utils;

namespace BcByWho
{
    [HarmonyPatch(typeof(BroadcastCommand), nameof(BroadcastCommand.OnExecute))]
    internal static class Patch
    {
        private static bool Prefix(BroadcastCommand __instance, ArraySegment<string> arguments, ICommandSender sender, ref string response, ref bool __result)
        {
            string inputDuration = arguments.At(0);
            if (!__instance.IsValidDuration(inputDuration, out ushort time))
            {
                response = "Invalid argument for duration: " + inputDuration + " Usage: " + arguments.Array[0] + " " + __instance.DisplayCommandUsage();
                __result = false;
                return false;
            }

            bool flag = __instance.HasInputFlag(arguments.At(1), out Broadcast.BroadcastFlags broadcastFlag, arguments.Count);

            string adminMessage = Plugin.Singleton.Config.AdminMessage;
            string userName = $"<color={Plugin.Singleton.Config.StaffNameColor}>- {Regex.Replace(sender.LogName, @"\s\(.+\)", "")}</color>";
            string broadcastText = RAUtils.FormatArguments(arguments, flag ? 2 : 1);

            string data = $"{adminMessage}\n{broadcastText}\n{userName}";

            Broadcast.Singleton.RpcAddElement(data, time, broadcastFlag);

            ServerLogs.AddLog(ServerLogs.Modules.Administrative, string.Format("{0} broadcast text \"{1}\". Duration: {2} seconds. Broadcast Flag: {3}.", (object)sender.LogName, (object)data, (object)inputDuration, (object)broadcastFlag), ServerLogs.ServerLogType.RemoteAdminActivity_GameChanging);
            response = "Global broadcast sent.";
            __result = true;
            return false;
        }
    }
}