using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class LevelCreate : MonoBehaviour
{
    #region variables
    public int level;
    public int barriersToBreak;
    public int obstaclesToSwipe;
    public int[] obstaclesNumbers;
    public float timeToBeat;
    private int t = 0;
    #endregion
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        GenerateLevel();
    }

    void GenerateLevel()
    {
        if(level != 0)
        {
            barriersToBreak = level * 3 / (level / 2);
            obstaclesToSwipe = barriersToBreak / 3;
            timeToBeat = (30 * level) / (level * 2);

            while(t != obstaclesToSwipe)
            {
                var x = Random.Range(1, barriersToBreak);
                obstaclesNumbers[t] = x;
                t++;
            }
        }
    }
}
