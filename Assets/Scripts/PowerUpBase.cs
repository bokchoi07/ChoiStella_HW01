using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float _powerupDuration = 2.5f;
    [SerializeField] ParticleSystem _powerupParticles;
    [SerializeField] AudioClip _powerupSound;


    protected virtual void OnTriggerEnter(Collider other)
    {
        GameObject _playerObject = other.gameObject;
        Feedback();
        StartCoroutine(PowerUp(_playerObject));
        //PowerDown(_playerObject);
    }
    private void Feedback()
    {
        // particles
        if (_powerupParticles != null)
        {
            _powerupParticles = Instantiate(_powerupParticles, transform.position, Quaternion.identity);
            Debug.Log("played vfx");
        }
        // audio. TODO - consider obj pooling for performance
        if (_powerupSound != null)
        {
            AudioHelper.PlayClip2D(_powerupSound, 1f);
            Debug.Log("played sfx");
        }

    }
    protected abstract IEnumerator PowerUp(GameObject playerObject);
    protected abstract void PowerDown(GameObject playerObject);
}
