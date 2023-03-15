using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    private PlayerController pcontroller;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        pcontroller = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.gameObject.layer == 3)
       {
        isGrounded = true;
       }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
       if(other.gameObject.layer == 3)
       {
        isGrounded = true;
       }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
       if(other.gameObject.layer == 3)
       {
        isGrounded = false;
       }
    }
    
}
