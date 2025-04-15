using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneContext : MonoBehaviour
{
    float _timer;
    public CanvasGroup logo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timer = 3f;
        logo.alpha = 1f;

        UIManager.FadeOutEffect(logo);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < 0 || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("LobbyScene");
        }

        _timer -= Time.deltaTime;
    }
}