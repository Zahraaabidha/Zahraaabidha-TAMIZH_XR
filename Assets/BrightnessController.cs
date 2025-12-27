using UnityEngine;

public class BrightnessController : MonoBehaviour
{
    public CanvasGroup brightnessOverlay;

    private float brightness = 0f; // 0 = normal, higher = darker

    public void IncreaseBrightness()
    {
        brightness = Mathf.Clamp(brightness + 0.1f, 0f, 0.8f);
        brightnessOverlay.alpha = brightness;
        Debug.Log("Brightness Overlay Alpha: " + brightness);
    }

    public void DecreaseBrightness()
    {
        brightness = Mathf.Clamp(brightness - 0.1f, 0f, 0.8f);
        brightnessOverlay.alpha = brightness;
        Debug.Log("Brightness Overlay Alpha: " + brightness);
    }
}
