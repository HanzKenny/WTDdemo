using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployDogs : MonoBehaviour
{
    public GameObject dogPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBnds;
    void Start()
    {
        screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(dogWave());
    }

    void spawnDog (){
        GameObject c = Instantiate(dogPrefab) as GameObject;
        c.transform.position = new Vector2 (Random.Range(-screenBnds.x, screenBnds.x), screenBnds.y);
    }

    IEnumerator dogWave()
    {
        while (true)
        {
            yield return new WaitForSeconds (respawnTime);
            spawnDog();
        }

    }
}
