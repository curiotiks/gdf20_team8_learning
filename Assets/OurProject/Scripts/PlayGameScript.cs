using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameScript : MonoBehaviour
{
    public void PlayTheGame()
    {
        SceneManager.LoadScene(1);
    }
}
