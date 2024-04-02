using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class x2PointsScript : MonoBehaviour
{
    Button bttn;
    bool isUsed = false;
    void Start()
    {
        bttn = GetComponent<Button>();
        bttn.onClick.AddListener(X2Get);
    }

    void X2Get()
    {
        var x = PlayerPrefs.GetInt("stockx2");
        if(x > 0 && !isUsed)
        {
            x--;
            PlayerPrefs.SetInt("stockx2", x);
            isUsed = true;
            GameObject.FindGameObjectWithTag("script").GetComponent<GameplayScript>().x2Active = true;
            GameObject.FindGameObjectWithTag("script").GetComponent<stockPrint>().Print();
        }
    }
}
