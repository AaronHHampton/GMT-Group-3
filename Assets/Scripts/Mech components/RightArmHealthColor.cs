using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RightArmHealth : MonoBehaviour
{

    public Gradient gradient;
    public Image fill;

    private float rightArmColor;

    public void SetRightArmStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetRightArmHealth(float rightArmHealth, float maxrightArmHealth)
    {
        rightArmColor = rightArmHealth / maxrightArmHealth;

        fill.color = gradient.Evaluate(rightArmColor);
    }
}
