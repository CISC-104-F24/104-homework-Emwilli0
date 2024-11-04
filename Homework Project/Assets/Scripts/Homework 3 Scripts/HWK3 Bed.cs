using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HWK3Desk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Sleeping time...");
            
        }
    }

    private void OnCollisionStay(Collision Bed)
    {
        if (Bed.gameObject.CompareTag("Player"))
        {
            Debug.Log("ZZZ...");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Back to business!");
        }
    }
}