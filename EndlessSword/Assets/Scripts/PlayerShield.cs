using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public int maxBlock;
    int currentBlock;

    [SerializeField] private BlockUI blockUI;

    // Start is called before the first frame update
    void Start()
    {
        currentBlock  = maxBlock;
        blockUI.UpdateBlockUI(currentBlock);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
