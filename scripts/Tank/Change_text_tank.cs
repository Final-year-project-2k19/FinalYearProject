using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_text_tank : MonoBehaviour
{
    public Text changingText;
    public int counter = 1;

    public void Tank()
    {
        changingText.text = "FIRETANK";
        counter++;

    }

    public void Tank1()
    {
        changingText.text = "DRAGON";
        counter++;
    }

    public void Tank2()
    {
        changingText.text = "LOGO";
        counter++;
    }

    public void Tank3()
    {
        changingText.text = "EAGLE";
        counter++;

    }

    public void Tank4()
    {
        changingText.text = "FIREBIKE";
        counter++;

    }
    
    public void Tank5()
    {
        changingText.text = "SPEEDTYRE";
        counter++;

    }
}
