using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ElementScript : MonoBehaviour
{
    public string element;
    public GameObject scriptmng;

    #region colors
    public Sprite fire;
    public Sprite water;
    public Sprite air;
    public Sprite earth;
    #endregion
    void Start()
    {
        ChangeElement();
        ChangeColor();
    }

    public void ChangeElement()
    {
        var x = Random.Range(0,3);
        switch (x)
        {
            case 0:
                element = "water";
                break;
            case 1:
                element = "fire";
                break;
            case 2:
                element = "air";
                break;
            case 3:
                element = "earth";
                break;
        }
    }
    public void ChangeColor()
    {
        switch (element)
        {
            case "water":
                GetComponent<Image>().sprite = water;
                break;
            case "air":
                GetComponent<Image>().sprite = air;
                break;
            case "fire":
                GetComponent<Image>().sprite = fire;
                break;
            case "earth":
                GetComponent<Image>().sprite = earth;
                break;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collide");
        if(element == other.gameObject.tag)
        {
            Debug.Log("Match!");
            ChangeElement();
            ChangeColor();
            scriptmng.GetComponent<GameplayScript>().GetScore();
        }
        else
        {
            Debug.Log("GG");
            scriptmng.GetComponent<GameplayScript>().TakeDamage();
        }
        other.GetComponent<CardScript>().StopDraggin();
    }
}    