using System.Collections.Generic;
using PieceManager;

namespace AlchemyProps;

public static partial class Assets
{
    private static Dictionary<string, string> props = new()
    {
        ["piece_alchemy_gas_burner"] = "Gas Burner",
        ["piece_alchemy_ink_pot"] = "Ink Pot",
        ["piece_alchemy_mortar"] = "Mortar",
        ["piece_alchemy_retort"]  = "Retort",
        ["piece_alchemy_sandglass"] = "Sandglass",
        ["piece_alchemy_scale_1"] =  "Scale",
    };

    private static Dictionary<string, string> stands = new()
    {
        ["piece_alchemy_stand_1"] = "Stand",
        ["piece_alchemy_stand_2"] = "Stand",
    };

    private static Dictionary<string, string> barrels = new()
    {
        ["piece_alchemy_barrel_1"] = "Barrel",
        ["piece_alchemy_barrel_2"] = "Barrel",
    };

    private static Dictionary<string, string> buckets = new()
    {
        ["piece_alchemy_bucket"] = "Bucket",
    };

    private static Dictionary<string, string> jugs = new()
    {
        ["piece_alchemy_jug_1"] = "Jug",
        ["piece_alchemy_jug_2"] = "Jug",
        ["piece_alchemy_jug_3"] = "Jug",
    };

    private static Dictionary<string, string> lighting = new()
    {
        ["piece_alchemy_lamp"] = "Lamp",
        ["piece_alchemy_lantern"] = "Lantern",
        ["piece_alchemy_torch_wall"] = "Wall Torch"
    };

    private static void LoadMisc()
    {
        foreach (var kvp in props)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in jugs)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_clay_pot_break");
        }

        foreach (var kvp in stands)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Copper", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in barrels)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 10, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in buckets)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in lighting)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Iron", 1, true);
            build.RequiredItems.Add("Resin", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
            build.Prefab.AddComponent<LightToggle>();
        }
    }
}