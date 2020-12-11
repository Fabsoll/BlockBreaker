using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed;

    [SerializeField] int currentScore = 0;
    [SerializeField] int pointsPerBlockDestroyed = 2;
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] bool isAutoPlayEnabled;

    int levelNumber = 1;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetlevelNumber()
    {
        return levelNumber;
    }

    private void Start()
    {
        ScoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float gameSpeed = 0.85f;
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore = currentScore + pointsPerBlockDestroyed;
        ScoreText.text = currentScore.ToString();
    }
    public void ScoreReset()
    {
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
