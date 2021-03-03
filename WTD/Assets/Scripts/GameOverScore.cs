using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{

    public Text go_Scoretxt;          //Score in current game
    public Text go_Bestscoretxt;      //Best or highest score attained

    public float scoreCount;
    public float BestscoreCount;

    public float PointsPerSec;

    private scoreManager GOmanager;
    void Start()
    {
        GOmanager = FindObjectOfType<scoreManager>();
        if (PlayerPrefs.HasKey("BestScore")) 
        {
            go_Bestscoretxt.text = "SCORE: " + Mathf.Round(PlayerPrefs.GetFloat("BestScore") * 100f) / 100f;
        }
    }

}
