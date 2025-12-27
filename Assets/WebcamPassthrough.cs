using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WebcamPassthrough : MonoBehaviour
{
    public RawImage rawImage;
    public CanvasGroup canvasGroup;

    private WebCamTexture webcamTexture;

    void Start()
    {
        webcamTexture = new WebCamTexture();
        rawImage.texture = webcamTexture;
        rawImage.enabled = true;
        canvasGroup.alpha = 0f;
    }

    public void SetWebcam(bool enable)
    {
        if (enable)
        {
            webcamTexture.Play();
            StopAllCoroutines();
            StartCoroutine(FadeIn());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeIn()
    {
        while (canvasGroup.alpha < 1f)
        {
            canvasGroup.alpha += Time.deltaTime * 2f;
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        while (canvasGroup.alpha > 0f)
        {
            canvasGroup.alpha -= Time.deltaTime * 2f;
            yield return null;
        }
        webcamTexture.Stop();
    }
}
