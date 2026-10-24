using System.Collections.Generic;
using HarmonyLib;

namespace AlchemyProps;

public static class EffectListManager
{
    public static readonly List<EffectListRef> m_effectListRefs;

    static EffectListManager()
    {
        m_effectListRefs = [];
        var harmony = AlchemyPropsPlugin.instance._harmony;
        harmony.Patch(AccessTools.DeclaredMethod(typeof(ZNetScene), nameof(ZNetScene.Awake)),
            postfix: new HarmonyMethod(AccessTools.DeclaredMethod(typeof(EffectListManager),
                nameof(Patch_ZNetScene_Awake))));
    }

    public static void Patch_ZNetScene_Awake(ZNetScene __instance)
    {
        for (int i = 0; i < m_effectListRefs.Count; ++i)
        {
            var effectRef = m_effectListRefs[i];
            effectRef.Load();
        }
    }
}