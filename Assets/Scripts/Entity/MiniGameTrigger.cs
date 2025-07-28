using UnityEngine;

public class MiniGameTrigger : MonoBehaviour
{
    public GameObject popupUI; // <- 여기다 텍스트 오브젝트 연결할 거야

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(true); // UI 보이기
            MiniGameInput.canEnter = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popupUI.SetActive(false); // UI 숨기기
            MiniGameInput.canEnter = false;
        }
    }
}