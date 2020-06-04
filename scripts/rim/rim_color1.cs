using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rim_color1 : MonoBehaviour
{
    public Material nMaterial;

    public void setColorToGreen()
    {
        nMaterial.SetColor("_Color", Color.green);
    }

    public void setColorToYellow()
    {
        nMaterial.SetColor("_Color", Color.yellow);
    }

    public void setColorToBlue()
    {
        nMaterial.SetColor("_Color", Color.blue);
    }

    public void setColorToRed()
    {
        nMaterial.SetColor("_Color", Color.red);
    }
}
