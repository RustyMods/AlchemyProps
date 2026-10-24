using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PieceManager;

public class MaterialData
{
    private static readonly List<Material> processedMaterials = [];
    private static readonly int MetallicGlossMap = Shader.PropertyToID("_MetallicGlossMap");
    private static readonly int MetallicTex = Shader.PropertyToID("_MetallicTex");

    public static Texture _noiseTex
    {
        get
        {
            if (field != null) return field;
            var textures = Resources.FindObjectsOfTypeAll<Texture>();
            field = textures.FirstOrDefault(t => t.name == "Noise");
            return field;
        }
    }
    
    public Material material;
    public MaterialReplacer.ShaderType shaderType;
    public Dictionary<string, float> floatProps = new();
    public Texture metallicGlossMap;
    
    public MaterialData(Material material, MaterialReplacer.ShaderType shaderType)
    {
        this.material = material;
        this.shaderType = shaderType;
        metallicGlossMap = material.HasProperty(MetallicGlossMap) ? material.GetTexture(MetallicGlossMap) : null;
        MaterialReplacer.materialsToSet.Add(this);
    }

    public void Process()
    {
        if (processedMaterials.Contains(material)) return;
        
        material.shader = MaterialReplacer.GetShaderForType(material.shader,  shaderType, material.shader.name);

        if (material.HasProperty("_NoiseTex"))
        {
            material.SetTexture("_NoiseTex", _noiseTex);
        }
        
        if (material.HasProperty(MetallicTex))
        {
            material.SetTexture(MetallicTex, metallicGlossMap);
        }
        
        
        foreach (KeyValuePair<string, float> kvp in floatProps)
        {
            if (material.HasProperty(kvp.Key))
            {
                material.SetFloat(kvp.Key, kvp.Value);
            }
        }
        
        processedMaterials.Add(material);
    }
}

///// PIECE SHADER
// _MainTex
// _BumpMap
// _EmissionMap
// _NoiseTex
// _MetallicTex
// _Cutoff
// _BumpScale
// _Glossiness
// _Metallic
// _Cull
// _AddRain
// _ColorFoldout
// _EmissionSpacer
// _MetallicAlphaGloss
// _MiscFoldout
// _MoveableObject
// _NoiseFoldout
// _NormalFoldout
// _RippleDistance
// _RippleFreq
// _SmoothnessFoldout
// _TriplanarFoldout
// _TriplanarLocalPos
// _TriplanarMap
// _TriplanarScale
// _TwoSidedNormals
// _ValueNoise
// _ValueNoiseVertex


///// ROCK SHADER
// _MainTex
// _BumpMap
// _EmissiveTex
// _GlossMap
// _MetalTex
// _MossTex
// _BumpScale
// _Glossiness
// _Metallic
// _AddSnow
// _AddRain
// _ColorFoldout
// _EmissionSpacer
// _NormalFoldout
// _RippleDistance
// _RippleFreq
// _SmoothnessFoldout
// _TriplanarMap
// _TriplanarScale
// _MetalGloss
// _EndFoldout
// _FresnelPower
// _MossAlpha
// _MossBlend
// _MossFoldout
// _MossGloss
// _MossNormal
// _MossTransition
// _SmoothnessSpacer
// _UseGlossMap
// _WaterlineOffset



///// VEGETATION SHADER
// _Cutoff
// _BumpScale
// _Glossiness
// _Metallic
// _Cull
// _AddSnow
// _AddRain
// _Height
// _RippleDeadzoneMax
// _RippleDeadzoneMin
// _RippleDistance
// _RippleSpeed
// _SwayDistance
// _SwaySpeed
// _TwoSidedNormals
// _MetalGloss
// _CamCull
// _PushDistance
// _MossAlpha
// _MossBlend
// _MossNormal
// _MossTransition
// _SphereNormals
// _SphereOffset
// _PushClothMode
// _SnowSparkleLum
// _USEMETALMAP
// _UV2Height
// _MainTex
// _BumpMap
// _EmissiveTex
// _MetalTex
// _MossTex



//// SHADERS
// TextMeshPro/Distance Field
// Custom/LitGui
// Custom/Heightmap
// Custom/Water
// Lux Lit Particles/ Bumped
// Lux Lit Particles/ Tess Bumped
// Hidden/SimpleClear
// Hidden/SunShaftsComposite
// Hidden/Dof/DX11Dof
// Hidden/Dof/DepthOfFieldHdr
// TextMeshPro/Distance Field (Surface)
// Custom/AlphaParticle
// Unlit/BeaconBeam
// Hidden/BlitCameraDepth
// Custom/Blob
// Custom/Bonemass
// Particles/Standard Surface2
// Particles/Standard Unlit2
// Custom/Clouds
// Custom/Creature
// Custom/Decal
// Custom/Distortion
// Custom/Fallen Warrior
// Custom/Flow
// Custom/FlowOpaque
// Custom/Grass
// Unlit/Invis
// Unlit/Lighting
// Custom/LitParticles
// Custom/Mesh Flipbook Particle
// Custom/ParticleDecal
// Custom/Gradient Mapped Particle (Unlit)
// Custom/Particle (Unlit)
// Custom/Piece
// Custom/Player
// Custom/Rug
// Custom/ShadowBlob
// Custom/SkyObject
// Custom/SkyboxProcedural
// Valheim/Snow Mesh
// Standard TwoSided
// Custom/StaticRock
// Custom/Tar
// Custom/Trilinearmap
// Custom/Vegetation
// Custom/WaterMask
// Unlit/WeaponGlow
// Custom/Yggdrasil_root
// Custom/UI/AntiAliasedCircle
// Hidden/RadialSegementShader
// Unlit/DepthWrite
// UI/Lava Indicator
// Custom/WaterBottom
// Custom/Yggdrasil
// Custom/icon
// Custom/mapshader
// Custom/UI_BGBlur
// Hidden/RadialCutoutShader