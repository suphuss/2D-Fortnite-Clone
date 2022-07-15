using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
