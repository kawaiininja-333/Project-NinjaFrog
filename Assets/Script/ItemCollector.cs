using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    private int apples = 0;
    private int bananas = 0;
    private int Cherries = 0;
    private int dimond = 0;
    private int coin = 0;

    private int totaldimond = 0;

    [SerializeField] private Text totalScore;
    [SerializeField] private Text dimondcount;
    [SerializeField] private AudioSource collectCoinSound;

    [SerializeField] private AudioSource collectFruitsSound;
    [SerializeField] private AudioSource collectDimondSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectFruitsSound.Play();
            Destroy(collision.gameObject);
            apples += 4;
            // Debug.Log("Apples => " + apples);
        }
        else if (collision.gameObject.CompareTag("Banana"))
        {
            collectFruitsSound.Play();
            Destroy(collision.gameObject);
            bananas += 2;
            // Debug.Log("Banana => " + bananas);
        }
        else if (collision.gameObject.CompareTag("Cherry"))
        {
            collectFruitsSound.Play();
            Destroy(collision.gameObject);
            Cherries += 3;
            // Debug.Log("cherrey => " + Cherries);

        }
        else if (collision.gameObject.CompareTag("Dimond"))
        {
            collectDimondSoundEffect.Play();
            Destroy(collision.gameObject);
            dimond += 8;
            totaldimond++;
            // Debug.Log("cherrey => " + Cherries);

        }
        else if (collision.gameObject.CompareTag("Coin"))
        {
            collectCoinSound.Play();
            Destroy(collision.gameObject);
            coin++;
            // Debug.Log("cherrey => " + Cherries);

        }
        totalScore.text = "Score: " + (Cherries + bananas + apples + dimond + coin);
        dimondcount.text = totaldimond + "X";
    }
}

