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

    public void SetLeftLegStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetLeftLegHealth(float leftLegHealth, float maxLeftLegHealth)
    {
        leftLegColor = leftLegHealth / maxLeftLegHealth;

        fill.color = gradient.Evaluate(leftLegColor);
    }
}
