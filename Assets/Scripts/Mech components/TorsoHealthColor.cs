using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TorsoHealth : MonoBehaviour
{

    public Gradient gradient;
    public Image fill;

    private float torsoColor;

    public void SetTorsoStartColor()
    {
        fill.color = gradient.Evaluate(1f);
    }

    public void SetTorsoHealth(float torsoHealth, float maxTorsoHealth)
    {
        torsoColor = torsoHealth / maxTorsoHealth;

        fill.color = gradient.Evaluate(torsoColor);
    }
}
