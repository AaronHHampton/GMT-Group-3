using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RightLegHealth : MonoBehaviour
{

    public Gradient gradient;
    public Image fill;

    private float rightLegColor;

    public void SetRightLegStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetRightLegHealth(float rightLegHealth, float maxRightLegHealth)
    {
        rightLegColor = rightLegHealth / maxRightLegHealth;

        fill.color = gradient.Evaluate(rightLegColor);
    }
}
