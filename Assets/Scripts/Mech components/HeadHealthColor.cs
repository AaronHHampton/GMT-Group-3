using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HeadHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float headColor;

    public void SetHeadStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetHeadHealth(float headHealth, float maxHeadHealth)
    {
        headColor = headHealth / maxHeadHealth;

        fill.color = gradient.Evaluate(headColor);
    }
}
