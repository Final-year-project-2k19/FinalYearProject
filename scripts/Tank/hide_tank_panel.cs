﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide_tank_panel : MonoBehaviour
{
    public void hidePanel(GameObject obj)
    {
        obj.SetActive(false);
    }
}