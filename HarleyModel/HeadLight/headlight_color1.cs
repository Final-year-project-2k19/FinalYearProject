using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headlight_color1 : MonoBehaviour
{
    public Material nMaterial;

    public void setColorToBlack()
    {
        nMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void setColorToYellow()
    {
        nMaterial.SetColor("_EmissionColor", Color.yellow);
    }

    public void setColorToBlue()
    {
        nMaterial.SetColor("_EmissionColor", Color.blue);
    }

    public void setColorToRed()
    {
        nMaterial.SetColor("_EmissionColor", Color.red);
    }

}
