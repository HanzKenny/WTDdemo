﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text Scoretxt;          //Score in current game
    

    public float scoreCount;
    public float BestscoreCount;

    public float PointsPerSec;

    public bool scoreIncreases;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreases)
        {
            scoreCount += PointsPerSec * Time.deltaTime;
        }

        Scoretxt.text = "SCORE: " + Mathf.Round(scoreCount * 100f) / 100f;
        PlayerPrefs.SetFloat("BestScore", scoreCount);
        


    }

    public void resetScore()
    {
        scoreIncreases = false;
    }
}