using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_text_rim : MonoBehaviour
{
    public Text changingText;
    public int counter = 1;

    public void Rim()
    {
        changingText.text = "Green";
        counter++;

    }

    public void Rim1()
    {
        changingText.text = "yellow";
        counter++;
    }

    public void Rim2()
    {
        changingText.text = "dark_blue";
        counter++;
    }

    public void Rim3()
    {
        changingText.text = "red";
        counter++;

    }
}
