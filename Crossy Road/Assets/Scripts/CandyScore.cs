using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandyScore : MonoBehaviour
{
    public Candy candy;
    public TextMeshProUGUI candyScore;

    private void OnEnable()
    {
        candyScore.text = candy.candy.ToString();
    }
}
