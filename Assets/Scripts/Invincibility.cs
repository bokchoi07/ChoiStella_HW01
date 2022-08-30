using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : PowerUpBase
{
    [SerializeField] Material _invincibilityMaterial = null;
    protected override void OnTriggerEnter(Collider other)
    {
        GameObject _playerObject = other.gameObject;
        //power up
        _playerObject.GetComponentInChildren<MeshRenderer>().material = _invincibilityMaterial;
        //_playerObject.GetComponent<MeshRenderer>().material = _invincibilityMaterial;
        gameObject.SetActive(false);
    }
    /*protected override void PowerUp(Player player)
    {
        
    }

    protected override void PowerDown(Player player)
    {
        throw new System.NotImplementedException();
    }*/
}
