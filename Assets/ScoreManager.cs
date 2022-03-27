using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; //UI dependency

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<TMPro.TextMeshProUGUI>();
        scoreText.text = score.ToString() + " POINTS";
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
    }
}
