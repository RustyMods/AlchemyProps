using System.Collections.Generic;
using PieceManager;

namespace AlchemyProps;

public static partial class Assets
{
    private static Dictionary<string, string> books = new()
    {
        ["piece_alchemy_book_1"] = "Book",
        ["piece_alchemy_book_2"] = "Book",
        ["piece_alchemy_book_3"] = "Book",
        ["piece_alchemy_book_4"] = "Book",
        ["piece_alchemy_book_5"] = "Book",
        ["piece_alchemy_book_6"] = "Book",
        ["piece_alchemy_book_7"] = "Book",
        ["piece_alchemy_book_8"] = "Book",
        ["piece_alchemy_book_9"] = "Book",
        ["piece_alchemy_book_10"] = "Book",
        ["piece_alchemy_book_11"] = "Book",
    };

    private static Dictionary<string, string> bookPiles = new()
    {
        ["piece_alchemy_bookpile_1"] = "Book Pile",
        ["piece_alchemy_bookpile_2"] = "Book Pile",
        ["piece_alchemy_bookpile_3"] = "Book Pile",
        ["piece_alchemy_bookpile_4"] = "Book Pile",
        ["piece_alchemy_bookpile_5"] = "Book Pile",
        ["piece_alchemy_bookpile_6"] = "Book Pile",
    };

    private static Dictionary<string, string> papers = new()
    {
        ["piece_alchemy_paper_2"] = "Paper",
        ["piece_alchemy_paper_3"] = "Paper",
        ["piece_alchemy_paper_4"] = "Paper",
        ["piece_alchemy_paper_5"] = "Paper",
    };

    private static Dictionary<string, string> paperStacks = new()
    {
        ["piece_alchemy_paperstack_1"] = "Paper Stack",
        ["piece_alchemy_paperstack_2"] = "Paper Stack",
    };

    private static Dictionary<string, string> scrolls = new()
    {
        ["piece_alchemy_scroll"] = "Scroll",
    };

    private static void LoadBooks()
    {
        foreach (var kvp in books)
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

        foreach (var kvp in bookPiles)
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

        foreach (var kvp in paperStacks)
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

        foreach (var kvp in scrolls)
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