using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusTimerScript : MonoBehaviour
{
    Button bttn;
    bool isUsed = false;
    void Start()
    {
        bttn = GetComponent<Button>();
        bttn.onClick.AddListener(TimerGet);
    }

    void TimerGet()
    {
        var x = PlayerPrefs.GetInt("stocktimer");
        if(x > 0 && !isUsed)
        {
            x--;
            PlayerPrefs.SetInt("stocktimer", x);
            isUsed = true;
            GameObject.FindGameObjectWithTag("script").GetComponent<GameplayScript>().AddTime(60f);
            GameObject.FindGameObjectWithTag("script").GetComponent<stockPrint>().Print();
        }
    }
}
