using System.Collections.Generic;
using PieceManager;

namespace AlchemyProps;

public static partial class Assets
{
    private static Dictionary<string, string> candles = new()
    {
        ["piece_alchemy_candle_1"] = "Candle",
        ["piece_alchemy_candle_2"] = "Candle",
        ["piece_alchemy_candle_3"] = "Candle",
        ["piece_alchemy_candle_4"] = "Candle",
        ["piece_alchemy_candles_1"] = "Candles",
        ["piece_alchemy_candles_2"] = "Candles",
        ["piece_alchemy_candles_3"] = "Candles",
        ["piece_alchemy_candles_4"] = "Candles",
        ["piece_alchemy_candles_5"] = "Candles",
        ["piece_alchemy_candlestick"] = "Candlestick",
        ["piece_alchemy_candlestick_floor_1"] = "Large Candlestick",
        ["piece_alchemy_candlestick_floor_2"] = "Large Candlestick",
    };

    private static void LoadCandles()
    {
        foreach (var kvp in candles)
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
            piece.m_placeEffect = new EffectListRef("sfx_build_hammer_default");
            wnt.m_destroyedEffect = new EffectListRef("sfx_build_hammer_default", "fx_candle_off");
            build.Prefab.AddComponent<LightToggle>();
        }
    }
}