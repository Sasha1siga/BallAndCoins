using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private CoinManager _coinManager;
    [SerializeField] PlayerScale PlayerScale;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<Coin>())
        {
            //Debug.Log("Coin");
            Coin coin = other.GetComponent<Coin>();
            _coinManager.CollectCoin(coin);
            PlayerScale.BallEat();
        }
    }
}
