using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    private scoreManager SCManager;

    void start()
    {
        SCManager = FindObjectOfType<scoreManager>();
        SCManager.scoreCount = 0;
        SCManager.scoreIncreases = true;
    }

    public void endGame ()
    {
        SceneManager.LoadScene("GameOver");
    }


}
