using PieceManager;
using UnityEngine;

namespace AlchemyProps;

public static partial class Assets
{
    public static void Setup()
    {
        LoadBooks();
        LoadBottles();
        LoadCandles();
        LoadFurniture();
        LoadMisc();
        SetupMaterials();
    }

    private static void SetupMaterials()
    {
        var bundle = PiecePrefabManager.RegisterAssetBundle("alchemy_props");
        var furniture = new MaterialData(bundle.LoadAsset<Material>("Atlas_Furniture_01"),
            MaterialReplacer.ShaderType.PieceShader);
        var props1 = new MaterialData(bundle.LoadAsset<Material>("Atlas_Props_01"),
            MaterialReplacer.ShaderType.PieceShader);
        var props2 = new MaterialData(bundle.LoadAsset<Material>("Atlas_Props_02"),
            MaterialReplacer.ShaderType.PieceShader);
    }
}