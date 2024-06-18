using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimeScore : MonoBehaviour
{
    public TextMeshProUGUI timeScore;
    private TextMeshProUGUI timeText;

    private void OnEnable()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        timeText.text = timeScore.text;
    }
}
