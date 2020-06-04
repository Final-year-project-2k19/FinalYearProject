using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_text_color : MonoBehaviour
{
    public Text changingText;
    public int counter = 1;

    public void Black()
    {
        changingText.text = "Metallic Black";
        counter++;

    }

    public void Red()
    {
        changingText.text = "Bright Red";
        counter++;
    }

    public void Green()
    {
        changingText.text = "Green";
        counter++;
    }

    public void Yellow()
    {
        changingText.text = "Bright Yellow";
        counter++;

    }

    public void white()
    {
        changingText.text = "Plastic White";
        counter++;

    }

    public void Blue()
    {
        changingText.text = "Blue";
        counter++;

    }

    public void Cyan()
    {
        changingText.text = "Cyan";
        counter++;

    }
}
