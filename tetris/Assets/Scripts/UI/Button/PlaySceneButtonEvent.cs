using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneButtonEvent : MonoBehaviour
{
    public void OnClickReturn()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
