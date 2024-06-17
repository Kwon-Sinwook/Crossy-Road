using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int coin = 0;

    private void OnTriggerStay(Collider other)
    {
        coin++;
        coinText.text = coin.ToString();
        Destroy(other.gameObject);
    }
}
