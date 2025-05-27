using System;
using HarmonyLib;
using UnityEngine;
using UnityModManagerNet;

namespace NoMosaic
{
    // Mod主配置
    public static class Settings
    {
        public static bool Enabled = true;
    }

    // Mod核心逻辑
    [HarmonyPatch]
    public static class Main
    {
        private static Harmony harmony;
        private static bool Loaded = false;

        // UMM生命周期 - Mod加载/卸载
        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            // 初始化设置
            modEntry.OnToggle = OnToggle;
            modEntry.OnGUI = OnGUI;

            // 初始化Harmony
            if (!Loaded)
            {
                harmony = new Harmony(modEntry.Info.Id);
                harmony.PatchAll();
                Loaded = true;
            }
            return true;
        }

        // UMM开关回调
        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Settings.Enabled = value;
            return true;
        }

        // 简单的UI界面
        private static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.Label("当前马赛克状态: " + (Settings.Enabled ? "已禁用" : "已启用"));
        }

        // 马赛克渲染方法补丁
        [HarmonyPatch(typeof(nel.MosaicShower), "FnDrawMosaic")]
        [HarmonyPrefix]
        static bool Prefix_FnDrawMosaic(ref bool __result)
        {
            if (Settings.Enabled)
            {
                __result = false; // 强制返回false
                return false;     // 跳过原始方法执行
            }
            return true; // 正常执行原始方法
        }
    }
}