using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{

    public static score instance;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    private int _score;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentScoreText.text = _score.ToString();

        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        UpdateHighScore();
    }


    public void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore")) 
        {
            PlayerPrefs.SetInt("HighScore" , _score);
            highScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
