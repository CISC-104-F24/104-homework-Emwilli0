using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HWK3Player : MonoBehaviour
{
    public int restedValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider playPen)
    {

        if (playPen.gameObject.CompareTag("Player"))
        {
            Debug.Log("You're in the Playpen!");
        }
    }

    private void OnTriggerExit (Collider playPen)
    {
        if (playPen.gameObject.CompareTag("Player"))
        {
            Debug.Log("You've left the Playpen.");
        }
    }

    //the code below is for my player colliding with the bed. unity had issues when I made
    //a new script specifically for the player so here we are 
    private void OnCollisionStay(Collision Player)
    {
        if (Player.gameObject.CompareTag("Bed"))
        {
            transform.rotation = Quaternion.Euler(270f, 180f, 0f);
        }
    }
    private void OnCollisionEnter(Collision Player)
    { 
        if (Player.gameObject.CompareTag("Rug"))
        {   
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            transform.position = new Vector3 (5f, 5f, 15.87f);
        }
    }

    private void OnCollisionExit(Collision Player)
    {
        if (Player.gameObject.CompareTag("Bed"))
        {
            Debug.Log("Back to business!");
            restedValue = restedValue + 1;

        }
    }

}