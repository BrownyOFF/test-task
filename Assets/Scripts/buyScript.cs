using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class buyScript : MonoBehaviour
{
    IEnumerator coroutine;
    public int idBuy;
    private Button bttn;
    public GameObject errorMsg;
    void Start()
    {
        errorMsg.SetActive(false);
        bttn = GetComponent<Button>();
        bttn.onClick.AddListener(Buy);
    }
    private IEnumerator ShowAndWait()
    {
        errorMsg.SetActive(true);
        yield return new WaitForSeconds(2);
        errorMsg.SetActive(false);
    }

    void Buy()
    {
        var x = PlayerPrefs.GetInt("balance");
        if(x < 100)
        {
            StartCoroutine(ShowAndWait());
            return;
        }
        PlayerPrefs.SetInt("balance", x - 100);
        switch (idBuy)
        {
            case 0:
                var t = PlayerPrefs.GetInt("stock60");
                PlayerPrefs.SetInt("stock60", t + 1);
                break;
            case 1:
                var a = PlayerPrefs.GetInt("stockx2");
                PlayerPrefs.SetInt("stockx2", a + 1);
                break;
            case 2:
                var b = PlayerPrefs.GetInt("stocktimer");
                PlayerPrefs.SetInt("stocktimer", b + 1);
                break;
            default:
                Debug.Log("Error, Item not found. Check ID");
                break;
        }
    }
}
