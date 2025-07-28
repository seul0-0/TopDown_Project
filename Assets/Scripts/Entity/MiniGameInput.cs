using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameInput : MonoBehaviour
{
    public static bool canEnter = false;

    public string miniGameSceneName = "Mini Scene";

    void Update()
    {
        if (canEnter && Input.GetKeyDown(KeyCode.Space))
        {
            EnterMiniGame();
        }
    }

    void EnterMiniGame()
    {
        SceneManager.LoadScene(miniGameSceneName);
    }
}