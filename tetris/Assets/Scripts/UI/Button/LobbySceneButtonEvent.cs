using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneButtonEvent : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnClickOption()
    {

    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void OnClickScore()
    {

    }
}
