using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollides : MonoBehaviour
{
    public PlayerMove RedMove;

    void OnCollisionEnter2D(Collision2D coll) {
         if (coll.gameObject.tag == "Obstacle")
         {
             RedMove.enabled = false;
             FindObjectOfType<scoreManager>().resetScore();
             FindObjectOfType<GameManage>().endGame();
         }
     }
}
