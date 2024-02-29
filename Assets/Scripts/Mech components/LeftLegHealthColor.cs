using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LeftLegHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float leftLegColor;

    public void SetLeftLegStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetLeftLegHealth(float leftLegHealth, float maxLeftLegHealth)
    {
        leftLegColor = leftLegHealth / maxLeftLegHealth;

        fill.color = gradient.Evaluate(leftLegColor);
    }
}
