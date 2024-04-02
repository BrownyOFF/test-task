using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stockPrint : MonoBehaviour
{
    public GameObject stock60;
    public GameObject stockx2;
    public GameObject stocktimer;
    public GameObject balance;
    void Start()
    {
        Print();
    }

    public void Print()
    {
        balance.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("balance").ToString();
        stock60.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("stock60").ToString();
        stockx2.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("stockx2").ToString();
        stocktimer.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("stocktimer").ToString();
    }
}
