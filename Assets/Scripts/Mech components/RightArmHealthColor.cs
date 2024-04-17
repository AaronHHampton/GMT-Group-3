using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RightArmHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float rightArmColor;

    public void SetRightArmStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetRightArmHealth(float rightArmHealth, float maxrightArmHealth)
    {
        rightArmColor = rightArmHealth / maxrightArmHealth;

        fill.color = gradient.Evaluate(rightArmColor);
    }
}
