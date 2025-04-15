using System.Collections;
using UnityEditorInternal;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy( this.gameObject);
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public static void FadeInEffect(CanvasGroup canvasGroup)
    {
        _instance.StartFadeInEffect(canvasGroup);
    }

    private void StartFadeInEffect(CanvasGroup canvasGroup)
    {
        StartCoroutine(_instance.CoFadeInEffect(canvasGroup));
    }

    IEnumerator CoFadeInEffect(CanvasGroup canvasGroup)
    {
        float alpha = canvasGroup.alpha;

        while(alpha < 1f)
        {
            alpha += Time.deltaTime * 0.5f;
            canvasGroup.alpha = alpha;

            yield return null;
        }

        canvasGroup.alpha = 1f;

        yield return null;
    }

    public static void FadeOutEffect(CanvasGroup canvasGroup)
    {
        _instance.StartFadeOutEffect(canvasGroup);
    }

    private void StartFadeOutEffect(CanvasGroup canvasGroup)
    {
        StartCoroutine(_instance.CoFadeOutEffect(canvasGroup));
    }

    IEnumerator CoFadeOutEffect(CanvasGroup canvasGroup)
    {
        float alpha = canvasGroup.alpha;

        while (alpha > 0f)
        {
            alpha -= Time.deltaTime * 0.5f;
            canvasGroup.alpha = alpha;
            Debug.Log(Time.frameCount);

            yield return null;
        }

        canvasGroup.alpha = 0f;
        Debug.Log("Done");

        yield return null;
    }
}
