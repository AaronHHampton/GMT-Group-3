using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TorsoHealth : MonoBehaviour
{

    public Gradient gradient;
    public SpriteRenderer fill;

    private float torsoColor;

    public void SetTorsoStartColor(float StartingHealth, float MaxHealth)
    {
        fill.color = gradient.Evaluate(StartingHealth / MaxHealth);
    }

    public void SetTorsoHealth(float torsoHealth, float maxTorsoHealth)
    {
        torsoColor = torsoHealth / maxTorsoHealth;

        fill.color = gradient.Evaluate(torsoColor);
    }
}
