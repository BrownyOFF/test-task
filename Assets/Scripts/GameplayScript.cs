using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameplayScript : MonoBehaviour
{
    #region GameObjects
    public GameObject scoreText;
    public GameObject timerText;
    public GameObject jokerBarrier;
    public GameObject[] hpHearts;
    public GameObject[] obstacleCard;
    #endregion

    #region Variables
    public int health = 3;
    private int hpdecreasecount = 0;
    private int barriersBreaked = 0;
    private int obstaclesSwiped = 0;
    public float gameDuration = 60f;
    public int score = 0;
    public float timer;
    public bool x2Active = false;
    public bool noObstacle = false;
    #endregion
    void Start()
    {
        foreach(GameObject x in obstacleCard)
        {
            x.SetActive(false);
        }
        gameDuration = GetComponent<LevelCreate>().timeToBeat;
        timer = gameDuration;
    }
    public void AddTime(float time)
    {
        timer += time;
    }
    void EndGame()
    {
        Debug.Log("End");
    }
    void WinGame()
    {

    }
    public void TakeDamage()
    {
        hpHearts[hpdecreasecount].GetComponent<Image>().color = new Color32(0,0,0,100);
        hpdecreasecount++;
        health--;
        if(health <= 0)
        {
            EndGame();
        }
    }
    public void CreateObsticle()
    {
        var x = Random.Range(0,obstacleCard.Length);
    }
    public void GetScore()
    {
        if(x2Active)
        {
            score += 2;
        }
        else
        {
            score ++;
        }

        barriersBreaked++;
        if(barriersBreaked >= GetComponent<LevelCreate>().barriersToBreak)
        {
            WinGame();
        }
    
        if(GetComponent<LevelCreate>().obstaclesNumbers.Contains(barriersBreaked) && !noObstacle)
        {
            CreateObsticle();
        }
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            EndGame();
        }
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        timerText.GetComponent<TextMeshProUGUI>().text = Mathf.Round(timer).ToString();
    }
}