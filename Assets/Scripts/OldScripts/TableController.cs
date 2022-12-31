using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    public static TableController instance;
    public Transform spawnPoint;

    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CompareTableGreen")
        {
            Debug.Log("Toplanabilir.");
            
        }
        if (other.gameObject.tag == "CompareTableRed")
        {
            Debug.Log("Karsilastirilabilir.");
        }

    }
}
