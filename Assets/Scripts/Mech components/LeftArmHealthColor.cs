using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LeftArmHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float leftArmColor;

    public void SetLeftArmStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetLeftArmHealth(float leftArmHealth, float maxLeftArmHealth)
    {
        leftArmColor = leftArmHealth / maxLeftArmHealth;

        fill.color = gradient.Evaluate(leftArmColor);
    }
}
