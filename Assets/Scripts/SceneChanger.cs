using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    private Button bttn;
    public string sceneName;
    void Start()
    {
        bttn = gameObject.GetComponent<Button>();
        bttn.onClick.AddListener(Func);
    }

    void Func()
    {
        SceneManager.LoadScene(sceneName);
    }
}
