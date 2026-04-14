using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public int maxBlock;
    int currentBlock;

    [SerializeField] private BlockUI blockUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemySword>(out EnemySword externalEnemySword))
        {
            currentBlock -= externalEnemySword.blockDamage;
            blockUI.UpdateBlockUI(currentBlock);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentBlock  = maxBlock;
        blockUI.UpdateBlockUI(currentBlock);
    }
}
