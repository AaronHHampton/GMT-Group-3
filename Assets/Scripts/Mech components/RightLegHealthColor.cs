using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RightLegHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float rightLegColor;

    public void SetRightLegStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetRightLegHealth(float rightLegHealth, float maxRightLegHealth)
    {
        rightLegColor = rightLegHealth / maxRightLegHealth;

        fill.color = gradient.Evaluate(rightLegColor);
    }
}
