using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : PowerUpBase
{
    [SerializeField] Material _invincibilityMaterial = null;
    [SerializeField] Material _playerMaterial = null;

    /*protected override void OnTriggerEnter(Collider other)
    {
        GameObject _playerObject = other.gameObject;
        _playerObject.GetComponentInChildren<MeshRenderer>().material = _invincibilityMaterial;
        
    }*/
    protected override IEnumerator PowerUp(GameObject playerObject)
    {
        Debug.Log("power up" + base._powerupDuration);
        
        // disable visual and collider
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;

        playerObject.GetComponent<Player>().isInvincible = true;
        playerObject.GetComponentInChildren<MeshRenderer>().material = _invincibilityMaterial;

        //Invoke("PowerDown", base.powerupDuration);
        yield return new WaitForSeconds(base._powerupDuration);

        PowerDown(playerObject);
    }

    protected override void PowerDown(GameObject playerObject)
    {
        playerObject.GetComponent<Player>().isInvincible = false;
        playerObject.GetComponentInChildren<MeshRenderer>().material = _playerMaterial;

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;

        
        Debug.Log("power down");

        Destroy(gameObject);
    }
}
