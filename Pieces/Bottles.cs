using System.Collections.Generic;
using PieceManager;

namespace AlchemyProps;

public static partial class Assets
{
    private static Dictionary<string, string> bottles = new()
    {
        ["piece_alchemy_bottle_1"] = "Bottle",
        ["piece_alchemy_bottle_2"] = "Bottle",
        ["piece_alchemy_bottle_3"] = "Bottle",
    };

    private static Dictionary<string, string> cups = new()
    {
        ["piece_alchemy_cup"] = "Cup",
    };

    private static Dictionary<string, string> flasks = new()
    {
        ["piece_alchemy_flask_1"] = "Flask",
        ["piece_alchemy_flask_2"] = "Flask",
        ["piece_alchemy_flask_3"] = "Flask",
        ["piece_alchemy_flask_4"] = "Flask",
        ["piece_alchemy_flask_5"] = "Flask",
    };

    private static Dictionary<string, string> jars = new()
    {
        ["piece_alchemy_glass_jar_1"] = "Jar",
        ["piece_alchemy_glass_jar_2"] = "Jar",
    };

    private static Dictionary<string, string> potions = new()
    {
        ["piece_alchemy_potion_1"] = "Potion",
        ["piece_alchemy_potion_2"] = "Potion",
        ["piece_alchemy_potion_3"] = "Potion",
        ["piece_alchemy_potion_4"] = "Potion",
        ["piece_alchemy_potion_5"] = "Potion",
        ["piece_alchemy_potion_6"] = "Potion",
    };

    private static void LoadBottles()
    {
        foreach (var kvp in bottles)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Crystal", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal");
            wnt.m_destroyedEffect = new EffectListRef("fx_crystal_destruction");
        }

        foreach (var kvp in cups)
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

        foreach (var kvp in flasks)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Crystal", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal");
            wnt.m_destroyedEffect = new EffectListRef("fx_crystal_destruction");
        }

        foreach (var kvp in jars)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Crystal", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal");
            wnt.m_destroyedEffect = new EffectListRef("fx_crystal_destruction");
        }

        foreach (var kvp in potions)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Crystal", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Decor);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_crystal");
            wnt.m_destroyedEffect = new EffectListRef("fx_crystal_destruction");
        }
    }
}