using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployCrates : MonoBehaviour
{
    public GameObject cratePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBnds;
    void Start()
    {
        screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(crateWave());
    }

    void spawnCrate (){
        GameObject d = Instantiate(cratePrefab) as GameObject;
        d.transform.position = new Vector2 (Random.Range(-screenBnds.x, screenBnds.x), screenBnds.y);
    }

    IEnumerator crateWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCrate();
        }
    }

   // if (respawnTime )
   // {

   // }

}
