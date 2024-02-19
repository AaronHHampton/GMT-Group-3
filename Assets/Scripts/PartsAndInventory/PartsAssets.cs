using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsAssets : MonoBehaviour
{

    public static PartsAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite headSprite;
    public Sprite torsoSprite;
    public Sprite leftArmSprite;
    public Sprite rightArmSprite;
    public Sprite leftLegSprite;
    public Sprite rightLegSprite;

}
