using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] private CoinManager CoinManager;
    [SerializeField] private Transform _playerTransform;
    public Coin ClosestCoin;
    void Update()
    {
        ClosestCoin = CoinManager.GetClosest(transform.position);
        Vector3 toTarget = ClosestCoin.transform.position - transform.position;
        Vector3 toTargetXZ = new Vector3(toTarget.x, 0, toTarget.z);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(toTarget), Time.deltaTime * 10);
        
        transform.position = _playerTransform.position;
    }
}
