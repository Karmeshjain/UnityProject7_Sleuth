﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbarscript : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
        
    public void SetHealth(int health)
    {
        slider.value = health;
       fill.color= gradient.Evaluate(slider.normalizedValue);
    }
    public void MaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }


}
