using UnityEngine;

namespace AlchemyProps;

public class Candle : MonoBehaviour, Interactable, Hoverable
{
    public Piece m_piece;
    public ZNetView m_nview;
    public Light[] m_lights;
    public ParticleSystem[] m_particles;
    public bool m_enabled;

    public void Awake()
    {
        m_piece = GetComponent<Piece>();
        m_nview = GetComponent<ZNetView>();
        if (m_nview.GetZDO() == null) return;
        m_nview.Register<bool>(nameof(RPC_SetLight), RPC_SetLight);
        m_lights = GetComponentsInChildren<Light>();
        m_particles = GetComponentsInChildren<ParticleSystem>();
        m_enabled = m_nview.GetZDO().GetBool(ZDOVars.s_state);
        RPC_SetLight(0L, m_enabled);
    }

    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        m_nview.GetZDO().Set(ZDOVars.s_state, !m_enabled);
        m_nview.InvokeRPC(ZNetView.Everybody, nameof(RPC_SetLight), !m_enabled);
        return true;
    }

    public void RPC_SetLight(long sender, bool enable)
    {
        m_enabled = enable;
        foreach (var light in m_lights)
        {
            light.gameObject.SetActive(enable);
        }

        foreach (var ps in m_particles)
        {
            if (enable) ps.Play();
            else ps.Stop();
        }
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item) => false;
    
    public string GetHoverText()
    {
        return Localization.instance.Localize($"{m_piece.m_name}\n[<color=yellow><b>$KEY_Use</b></color>] $piece_use");
    }

    public string GetHoverName() => "Candle";

    public float GetHoverOffset() => 0f;
}