using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_texture4 : MonoBehaviour
{
    MeshRenderer meshRenderer;

    public Texture albedoTexture;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void ChangeAlbedoTexture()
    {
        meshRenderer.material.SetTexture("_MainTex", albedoTexture);
    }
}
