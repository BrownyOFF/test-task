using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    private Button bttn;
    void Start()
    {
        bttn = gameObject.GetComponent<Button>();
        bttn.onClick.AddListener(Func);
    }

    void Func()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
