using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    private float time;

    private void Update()
    {
        time += Time.deltaTime;
        score.text = time.ToString("N1");
    }
}
