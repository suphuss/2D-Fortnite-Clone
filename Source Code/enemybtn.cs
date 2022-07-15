using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemybtn : MonoBehaviour
{
    public GameObject _object;
    public Button yourButton;

    public void Start()
    {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Instantiate(_object, new Vector3(4, -2, 0), Quaternion.identity);
    }
}
