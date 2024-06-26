using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameOver : MonoBehaviour
{
    public GameObject EndPanel;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Pumpkin") || other.gameObject.CompareTag("Wall"))
        {
            other.gameObject.SetActive(false);
            EndPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
