using System.Collections.Generic;
using PieceManager;

namespace AlchemyProps;

public static partial class Assets
{
    private static Dictionary<string, string> benches = new()
    {
        ["piece_alchemy_bench_1"] = "Bench",
        ["piece_alchemy_bench_2"] = "Bench",
    };

    private static Dictionary<string, string> chairs = new()
    {
        ["piece_alchemy_chair_1"] = "Chair",
        ["piece_alchemy_chair_2"] = "Stool",
    };

    private static Dictionary<string, string> cupboards = new()
    {
        ["piece_alchemy_cupboard_1"] = "Cupboard",
        ["piece_alchemy_cupboard_2"] = "Cupboard",
        ["piece_alchemy_cupboard_3"] = "Cupboard",
        ["piece_alchemy_cupboard_4"] = "Cupboard",
        ["piece_alchemy_cupboard_5"] = "Cupboard",
        ["piece_alchemy_cupboard_preset_1"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_2"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_3"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_4"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_5"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_6"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_7"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_8"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_preset_9"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_large_preset_1"] = "Preset Cupboard",
        ["piece_alchemy_cupboard_large_preset_2"] =  "Preset Cupboard",
        ["piece_alchemy_cupboard_large_preset_3"] =  "Preset Cupboard",
    };

    private static Dictionary<string, string> drawers = new()
    {
        ["piece_alchemy_drawer"] = "Drawer",
    };

    private static Dictionary<string, string> rostrums = new()
    {
        ["piece_alchemy_rostrum_1"] = "Rostrum",
        ["piece_alchemy_rostrum_2"] = "Preset Rostrum",
    };

    private static Dictionary<string, string> shelves = new()
    {
        ["piece_alchemy_shelf_1"] = "Shelf",
        ["piece_alchemy_shelf_preset_1"] = "Preset Shelf",
        ["piece_alchemy_shelf_preset_2"] = "Preset Shelf",
        ["piece_alchemy_shelf_preset_3"] = "Preset Shelf",
        ["piece_alchemy_shelf_preset_4"] = "Preset Shelf",
    };

    private static Dictionary<string, string> tables = new()
    {
        ["piece_alchemy_table_1"] = "Table",
        ["piece_alchemy_table_2"] = "Table",
    };

    private static Dictionary<string, string> ladder = new()
    {
        ["piece_alchemy_ladder"] = "Ladder",
        ["piece_alchemy_ladder_angled_1"] = "Ladder 26",
        ["piece_alchemy_ladder_angled_2"] = "Ladder 45",
        ["piece_alchemy_ladder_angled_3"] = "Ladder 67"
    };

    private static void LoadFurniture()
    {
        foreach (var kvp in benches)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("FineWood", 6, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Chair;
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in rostrums)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in chairs)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("FineWood", 4, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Chair;
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in cupboards)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in drawers)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in shelves)
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

        foreach (var kvp in tables)
        {
            var build = new BuildPiece("alchemy_props", kvp.Key);
            build.Name.English(kvp.Value);
            build.Description.English("");
            build.Crafting.Set(CraftingTable.Workbench);
            build.RequiredItems.Add("Wood", 1, true);
            build.Usage.Set(Piece.UsageTagFlags.Furniture);
            build.Category.Set("Alchemy Props");
            build.Snapshot();
            var piece = build.Prefab.GetComponent<Piece>();
            piece.m_comfort = 1;
            piece.m_comfortGroup = Piece.ComfortGroup.Table;
            var wnt = build.Prefab.GetComponent<WearNTear>();
            piece.m_placeEffect = new EffectListRef("vfx_Place_wood_pole", "sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_wood_destroyed", "vfx_SawDust");
        }

        foreach (var kvp in ladder)
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
    }
}