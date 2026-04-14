using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockUI : MonoBehaviour
{
    int currentBlock;
    public TextMeshProUGUI blockNumberText;
    string s;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateBlockUI(int setBlockInt)
    {
        currentBlock = setBlockInt;

        // add code here to set a text on the ui to the current block
        s = currentBlock.ToString();
        blockNumberText.text = s;
    }
}
