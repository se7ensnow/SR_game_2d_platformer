using System;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coin_count;

    private void Start()
    {
        coin_count = 0;
        coinText.text = coin_count.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coin_count++;
            coinText.text = coin_count.ToString();
        }
    }
}
