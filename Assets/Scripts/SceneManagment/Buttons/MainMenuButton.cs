using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    public void MainMenu()
    {

        Loader.Load(Loader.Scene.StartScreen);

    }
}
