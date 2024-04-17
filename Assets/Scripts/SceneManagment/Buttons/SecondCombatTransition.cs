using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCombatTransition : MonoBehaviour
{

    public void StartSecondCombat()
    {

        Loader.Load(Loader.Scene.SecondCombat);

    }

}
