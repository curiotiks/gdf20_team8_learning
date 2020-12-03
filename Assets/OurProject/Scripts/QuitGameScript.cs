using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    public void QuitTheGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
