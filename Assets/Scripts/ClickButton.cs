using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    [SerializeField] private int _countAdd;
    [SerializeField] UIResources _uIResources;
    [SerializeField] GameObject _particleCoin;

    public void Click()
    {
        _uIResources.AddCoins(_countAdd);
        Instantiate(_particleCoin, transform.position, Quaternion.identity);
    }

}
