using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_color1 : MonoBehaviour
{
    public Material nMaterial;
    public Texture albedoTexture;
    MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void setColorToBlack()
    {
        nMaterial.SetColor("_Color", Color.black);
    }

    public void setColorToWhite()
    {
        nMaterial.SetColor("_Color", Color.white);

    }

    public void setColorToRed()
    {
        nMaterial.SetColor("_Color", Color.red);
    }

    public void setColorToYellow()
    {
        nMaterial.SetColor("_Color", Color.yellow);
    }

    public void setColorToGreen()
    {
        nMaterial.SetColor("_Color", Color.green);
    }
}
