using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCats : MonoBehaviour
{
    public GameObject catPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBnds;
    void Start()
    {
        screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(catWave());
    }

    void spawnCat (){
        GameObject b = Instantiate(catPrefab) as GameObject;
        b.transform.position = new Vector2 (Random.Range(-screenBnds.x, screenBnds.x), screenBnds.y);
    }

    IEnumerator catWave()
    {
        while (true)
        {
            yield return new WaitForSeconds (respawnTime);
            spawnCat();
        }

    }
}
