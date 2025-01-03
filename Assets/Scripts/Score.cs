using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score = 0;
    public TMPro.TextMeshProUGUI ScoreText;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("ScoringZone"))
        {
            Score += 1;
            ScoreText.text = " " + Score;
        }

    }
}
