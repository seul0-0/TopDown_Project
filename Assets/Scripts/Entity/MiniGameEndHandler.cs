using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameEndHandler : MonoBehaviour
{
    public int score = 0;

    public void EndMiniGame()
    {
        PlayerPrefs.SetInt("LastMiniGameScore", score);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }
}