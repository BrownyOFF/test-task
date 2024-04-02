using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrintScript : MonoBehaviour
{
    public GameObject sfx;
    public GameObject mfx;

    void Start()
    {
        RePrint();
    }

    public void RePrint()
    {
        var x = PlayerPrefs.GetInt("SoundVolume");
        var t = PlayerPrefs.GetInt("MusicVolume");
        sfx.GetComponent<TextMeshProUGUI>().text = x.ToString();
        mfx.GetComponent<TextMeshProUGUI>().text = t.ToString();
    }
}
