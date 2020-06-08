using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color1 : MonoBehaviour
{
    public Material material;

    public void setColorToBlack()
    {
        material.SetColor("_Color", Color.black);
    }

    public void setColorToWhite()
    {
        material.SetColor("_Color", Color.white);
    }

    public void setColorToRed()
    {
        material.SetColor("_Color", Color.red);
    }

    public void setColorToYellow()
    {
        material.SetColor("_Color", Color.yellow);
    }

    public void setColorToGreen()
    {
        material.SetColor("_Color", Color.green);
    }

    public void setColorToCyan()
    {
        material.SetColor("_Color", Color.cyan);
    }
    
    public void setColotToBlue()
    {
        material.SetColor("_Color", Color.blue);
    }
}
