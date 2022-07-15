using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
