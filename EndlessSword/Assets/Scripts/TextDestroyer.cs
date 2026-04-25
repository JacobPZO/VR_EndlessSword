using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestroyer : MonoBehaviour
{

    public GameObject textToDestroy;

    public void KillText()
    {
        textToDestroy.SetActive(false);
    }
}
