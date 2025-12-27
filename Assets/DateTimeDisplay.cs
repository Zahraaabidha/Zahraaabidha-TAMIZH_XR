using UnityEngine;
using TMPro;
using System;

public class DateTimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI dateTimeText;

    void Update()
    {
        dateTimeText.text = DateTime.Now.ToString("dd MMM yyyy | hh:mm tt");
    }
}
