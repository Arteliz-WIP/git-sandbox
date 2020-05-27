using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automovemalo : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime;
    }
}
