using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part
{

    public enum PartTypes{

        Head,
        Torso,
        LeftArm,
        RightArm,
        LeftLeg,
        RightLeg,

    }

    public PartTypes partType;
    public int amount;

    public Sprite Getsprite()
    {
        switch (partType)
        {
            default:
            case PartTypes.Head:        return PartsAssets.Instance.headSprite;
            case PartTypes.Torso:       return PartsAssets.Instance.torsoSprite;
            case PartTypes.LeftArm:     return PartsAssets.Instance.leftArmSprite;
            case PartTypes.RightArm:    return PartsAssets.Instance.rightArmSprite;
            case PartTypes.LeftLeg:     return PartsAssets.Instance.leftLegSprite;
            case PartTypes.RightLeg:    return PartsAssets.Instance.rightLegSprite;
        }
    }

}
