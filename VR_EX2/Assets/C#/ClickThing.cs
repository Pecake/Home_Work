using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickThing : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
    }

    public void replayGame()
    {
        Application.LoadLevel("VR");
    }
}
