using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float Speed;
    private void OnTriggerEnter(Collider other)
    {
        Speed = Speed * 25;
    }
}
