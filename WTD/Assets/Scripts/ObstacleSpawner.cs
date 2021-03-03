using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject m_toSpawn;
    
    protected void SpawnAt(Vector3 position, Quaternion rotation)
    {
        Instantiate(m_toSpawn, position, rotation);
    }

}
