using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocationandTime : ObstacleSpawner
{
    [SerializeField]
    private float m_SpawnInterval;
    [SerializeField]
    private float m_minXSpawnOffset;
    [SerializeField]
    private float m_maxXSpawnOffset;
    [SerializeField]
    private float m_minYSpawnOffset;
    [SerializeField]
    private float m_maxYSpawnOffset;

    [SerializeField]
    private float m_spawnIntervalTimer;


    private Vector3 GetRandomSpawnOffset()
    {
        var xOffset = Random.Range(m_minXSpawnOffset, m_maxXSpawnOffset);
        var yOffset = Random.Range(m_minYSpawnOffset, m_maxYSpawnOffset);
        return new Vector3 (xOffset, yOffset, 0);
    }

    private void Start()
    {
        //screenBnds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        m_spawnIntervalTimer = m_SpawnInterval;
    }

    private void Update()
    {
        m_spawnIntervalTimer -= Time.deltaTime;
        if (m_spawnIntervalTimer <= 0)
        {
            var position = transform.position + GetRandomSpawnOffset();
            SpawnAt(position, Quaternion.identity);
        }
    }    

}
