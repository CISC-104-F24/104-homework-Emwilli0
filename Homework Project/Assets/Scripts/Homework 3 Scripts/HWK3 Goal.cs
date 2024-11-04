using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3 : MonoBehaviour
{
    private Vector3 originalfavposition;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    //gain a goal with each specific ball
    private void OnTriggerEnter(Collider goalTrigger) 
    {
        
        if (goalTrigger.gameObject.CompareTag("Ball")) 
        {
            Debug.Log("Scored a Goal with your Favorite Ball!");
        } 
        
        if (goalTrigger.gameObject.CompareTag("Kickball"))
        {
            Debug.Log("Scored a Goal with the Kickball!");
        }
        
        if (goalTrigger.gameObject.CompareTag("Football"))
        {
            Debug.Log("Scored a Goal with the Football!");
        }

    }

}
