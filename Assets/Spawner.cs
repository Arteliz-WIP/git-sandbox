    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    
    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 4f);
    }

   
    void Spawn()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        position.y = Random.Range(14f, 21f);
        position.x = Random.Range(65f, 65f);
        position.z = 0f;
        Instantiate(prefab, position, Quaternion.identity);
    }
}
