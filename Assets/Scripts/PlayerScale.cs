using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _arrowTransform;
    public void BallEat()
    {
        _playerTransform.localScale += Vector3.one * 0.1f;
        _arrowTransform.position += new Vector3(0, 0.1f, 0); 
    }
}
