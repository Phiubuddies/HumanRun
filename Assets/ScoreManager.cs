using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public Text scoreText;

    private float score = 0f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        score = 0f;
    }

    void Update()
    {
        score += Time.deltaTime * 20f; // tambah 10 poin per detik
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("LastScore", Mathf.FloorToInt(score));
        PlayerPrefs.Save();
    }

    public int GetScore()
    {
        return Mathf.FloorToInt(score);
    }
}
