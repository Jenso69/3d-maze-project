using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollection : MonoBehaviour
{
    //add a scoring script here
private int score = 0;
public TMP_Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            AddScore(1);
            Destroy(other.gameObject);
        }
    }





    private void AddScore(int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";

    }



}
