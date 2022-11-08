using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 1;
    public void shootbullet()
    {
        var bulletInstance = Instantiate(bullet);
        bulletInstance.transform.position = transform.position;
        bulletInstance.GetComponent<Rigidbody>().velocity = transform.forward * speed;



    }
}
