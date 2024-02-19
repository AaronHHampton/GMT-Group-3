using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LeftArmHealth : MonoBehaviour
{

    public Gradient gradient;
    public Image fill;

    private float leftArmColor;

    public void SetLeftArmStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetLeftArmHealth(float leftArmHealth, float maxLeftArmHealth)
    {
        leftArmColor = leftArmHealth / maxLeftArmHealth;

        fill.color = gradient.Evaluate(leftArmColor);
    }
}
