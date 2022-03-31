using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    GameObject scoreBoardUI;
    public static int score;

    private void Start()
    {
        scoreBoardUI = GameObject.FindGameObjectWithTag("ScoreCanvas");
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }


}