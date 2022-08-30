using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] float powerupDuration = 2.5f;

    protected virtual void OnTriggerEnter(Collider other)
    {
        /*Player player = other.gameObject.GetComponent<Player>();
        PowerUp(player);
        PowerDown(player);
        gameObject.SetActive(false);*/
    }

    /*protected abstract void PowerUp(Player player);
    protected abstract void PowerDown(Player player);*/
}
