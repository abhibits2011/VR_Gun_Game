using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet01 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<enemycontroller>())
            other.GetComponent<enemycontroller>().Death();


    }
}
