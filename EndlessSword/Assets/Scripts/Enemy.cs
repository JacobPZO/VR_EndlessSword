using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public SceneChanger sceneChanger;
    [SerializeField] HealthBar enemyHealthBar;
    [SerializeField] Collider collision;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerSword>(out PlayerSword externalPlayerSword))
        {
            currentHealth -= externalPlayerSword.damageNumber;
            enemyHealthBar.UpdateHealthBar(currentHealth, maxHealth);
        }
    }

    void Die()
    {
        sceneChanger.LevelTwo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }
}
