using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playermanager : MonoBehaviour
{
    public static float playerHealth, currentScore;
    public Image healthImg;
    public TMP_Text scoreText;
    public GameObject gameON, gameOFF, enemies;
    AudioSource audioData;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
            gameOver();
        healthImg.fillAmount = playerHealth;
        scoreText.text = currentScore.ToString();
        
    }
    public void gameStart()
    {
        gameON.SetActive(true);
        gameOFF.SetActive(false);
        playerHealth = 1;
        currentScore = 0;
        scoreText.text = "0";
        audioData.Play();

    }
    public void gameOver()
    {
        foreach (Transform child in enemies.transform)
            child.gameObject.GetComponent<enemycontroller>().Death();
        gameON.SetActive(false);
        gameOFF.SetActive(true);
        audioData.Stop();
    }
}
