using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class DeleteBuilds : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            ResetWorld();

        }
    }

    void ResetWorld()
    {
        Application.LoadLevel(0);
    }
}
