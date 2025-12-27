using UnityEngine;
using TMPro;

public class PassthroughManager : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    private bool isPassthroughOn = false;

    public void TogglePassthrough()
    {
        isPassthroughOn = !isPassthroughOn;

        if (isPassthroughOn)
        {
            Debug.Log("Passthrough ON (OpenXR simulated)");
            buttonText.text = "Passthrough ON";
            EnableWebcam(true);
        }
        else
        {
            Debug.Log("Passthrough OFF (OpenXR simulated)");
            buttonText.text = "Passthrough OFF";
            EnableWebcam(false);
        }
    }

    void EnableWebcam(bool state)
    {
        WebcamPassthrough webcam = FindObjectOfType<WebcamPassthrough>();
        if (webcam != null)
            webcam.SetWebcam(state);
    }
}
