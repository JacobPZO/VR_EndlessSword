using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    [SerializeField] HealthBar playerHealthBar;
    [SerializeField] Collider collision;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemySword>(out EnemySword externalEnemySword))
        {
            currentHealth -= externalEnemySword.damageNumber;
            playerHealthBar.UpdateHealthBar(currentHealth, maxHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
