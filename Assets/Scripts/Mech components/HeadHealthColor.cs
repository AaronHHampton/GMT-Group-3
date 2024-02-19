using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HeadHealth : MonoBehaviour
{

    public Gradient gradient;
    public Image fill;

    private float headColor;

    public void SetHeadStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetHeadHealth(float headHealth, float maxHeadHealth)
    {
        headColor = headHealth / maxHeadHealth;

        fill.color = gradient.Evaluate(headColor);
    }
}
