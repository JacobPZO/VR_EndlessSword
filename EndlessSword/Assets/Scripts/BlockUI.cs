using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockUI : MonoBehaviour
{
    int currentBlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateBlockUI(int setBlockInt)
    {
        currentBlock = setBlockInt;
        // add code here to set a text on the ui to the current block
    }
}
