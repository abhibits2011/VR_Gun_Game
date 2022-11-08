using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemycontroller : GazePointer
{
    public GameObject particleEffects;
    public Animator enemymodel;
    bulletSpawner bspawner;

    // Start is called before the first frame update
    void Start()
    {
        bspawner = GameObject.FindObjectOfType<bulletSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            attack();
       
        
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        
        //Death();
        bspawner.shootbullet();
    }
    public void Death()
    {
        particleEffects.SetActive(true);
        particleEffects.transform.SetParent(null);
        Destroy(gameObject);
        playermanager.currentScore += 100;
    }
    public void attack()
    {
        enemymodel.SetTrigger("attack");
        playermanager.playerHealth -= 0.2f;
    }
}
