using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneContext : MonoBehaviour
{
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0 || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("LobbyScene");
        }

        timer -= Time.deltaTime;
    }
}
