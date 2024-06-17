using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public PlayerMove Player;

    public int max = 0;

    private void Update()
    {
        if(Player.count > max)
        {
            max = Player.count;
            ScoreUpdate();
        }

        
    }

    private void ScoreUpdate()
    {
        score.text = max.ToString();
    }
}
