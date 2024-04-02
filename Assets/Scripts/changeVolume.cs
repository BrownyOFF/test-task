using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeVolume : MonoBehaviour
{
    private GameObject scriptmngr;
    private Button bttn;
    public bool increase;
    public bool changeSound;
    void Start()
    {
        scriptmngr = GameObject.FindGameObjectWithTag("script");
        bttn = gameObject.GetComponent<Button>();
        bttn.onClick.AddListener(Func);
    }

    void Func()
    {
        if(increase)
        {
            if(changeSound && PlayerPrefs.GetInt("SoundVolume") < 10)
            {
                var s = PlayerPrefs.GetInt("SoundVolume") + 1;
                PlayerPrefs.SetInt("SoundVolume", s);
            }
            else if(!changeSound && PlayerPrefs.GetInt("MusicVolume") < 10)
            {
                var m = PlayerPrefs.GetInt("MusicVolume") + 1;
                PlayerPrefs.SetInt("MusicVolume", m);
            }
        }
        else
        {
            if(changeSound && PlayerPrefs.GetInt("SoundVolume") > 0)
            {
                var s = PlayerPrefs.GetInt("SoundVolume") - 1;
                PlayerPrefs.SetInt("SoundVolume", s);
            }
            else if(!changeSound && PlayerPrefs.GetInt("MusicVolume") > 0)
            {
                var m = PlayerPrefs.GetInt("MusicVolume") - 1;
                PlayerPrefs.SetInt("MusicVolume", m);
            }
        }
        scriptmngr.GetComponent<PrintScript>().RePrint();
    }
}
