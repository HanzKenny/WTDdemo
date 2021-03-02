using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deployables : MonoBehaviour
{
    //private deployWhat Deploy;
    public GameObject cratePrefab;
    private Vector2 screenBnds;
    
    void Start()
    {
        //screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(crateWave());
    }

    private void Awake()
    {
        
    }

    void spawnCrate (){
        GameObject d = Instantiate(cratePrefab) as GameObject;
        d.transform.position = new Vector2 (Random.Range(-screenBnds.x, screenBnds.x), screenBnds.y);
    }

    void Update()
    {
    // if (respawnTime >= 3)
    // {
       // respawnTime--;
    // }
    // else
    // {
       // spawnCrate();
       // respawnTime = 3;
    // }
    }

    private void resetSpawnTime()
    {
        
    }

}
