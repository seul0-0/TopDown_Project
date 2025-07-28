using UnityEngine;
using TMPro; // 또는 using UnityEngine.UI;

public class MiniGameScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("LastMiniGameScore", 0);
        scoreText.text = $"MiniGameScoer: {score}";
    }
}