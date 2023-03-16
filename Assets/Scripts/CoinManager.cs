using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _numberOfCoins = 20;
    [SerializeField] private Text _coinCountText;
    [SerializeField] private GameObject _parent;
    public List<Coin> CoinsList = new List<Coin>();
    void Start()
    {
        for (int i = 0; i < _numberOfCoins; i++)
        {
            Vector3 position = new Vector3(Random.Range(-40, 40), 1f, Random.Range(-40, 40));
            GameObject newCoin = Instantiate(_coinPrefab, position, Quaternion.identity, _parent.transform);
            CoinsList.Add(newCoin.GetComponent<Coin>());
        }
        UpdateCoinText();
    }

    public void CollectCoin(Coin coin)
    {
        CoinsList.Remove(coin);
        Destroy(coin.gameObject);
        UpdateCoinText();
    }
    void UpdateCoinText()
    {
        _coinCountText.text = "Осталось собрать:" + CoinsList.Count.ToString();
    }
    public Coin GetClosest(Vector3 point)
    {
        Coin closestCoin = null;
        float minDistance = Mathf.Infinity;
        for (int i = 0; i < CoinsList.Count; i++)
        {
            float distance = Vector3.Distance(point, CoinsList[i].transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestCoin = CoinsList[i];
            }
        }
        return closestCoin;
    }
}
