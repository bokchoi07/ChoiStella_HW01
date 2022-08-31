using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;

    TankController _tankController;

    int _treasureCount = 0;

    public bool isInvincible = false;

    //Text _treasureTextUI = GetComponent<Text>();

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
        
    }
    // Start is called before the first frame update
    private void Start()
    {
        _currentHealth = _maxHealth;
    }


    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player's health: " + _currentHealth);
    }

    public void DecreaseHealth(int amount)
    {
        if (isInvincible == false)
        {
            _currentHealth -= amount;
            Debug.Log("Player's health: " + _currentHealth);
            if (_currentHealth <= 0)
            {
                Kill();
            }
        }
    }

    public void Kill()
    {
        if(isInvincible == false)
        {
            gameObject.SetActive(false);
        }
    }

    public void IncreaseTreasureCount(int amount)
    {
        _treasureCount += amount;
        //_treasureTextUI.text = _treasureCount.ToString();
    }

    public int GetTreasureCount()
    {
        return _treasureCount;
    }
}
