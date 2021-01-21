using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployMaces : MonoBehaviour
{
    public GameObject macePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBnds;
    void Start()
    {
        screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(maceWave());
    }

    void spawnMace (){
        GameObject a = Instantiate(macePrefab) as GameObject;
        a.transform.position = new Vector2 (Random.Range(-screenBnds.x, screenBnds.x), screenBnds.y);
    }

    IEnumerator maceWave()
    {
        while (true)
        {
            yield return new WaitForSeconds (respawnTime);
            spawnMace();
        }

    }
}
