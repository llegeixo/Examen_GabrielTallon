using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 6.5f;
    public float Jump = 8f;
    Rigidbody2D rbody;
    SpriteRenderer sRenderer;
    public GroundSensor gSensor;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>();
        gSensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if(horizontal < 0)
        {
            sRenderer.flipX = true;
        }
        
        else if(horizontal > 0)
        {
            sRenderer.flipX = false;
        }

        if(Input.GetButtonDown("Jump") && gSensor.isGrounded)
        {
            rbody.AddForce(Vector2.up * Jump, ForceMode2D.Impulse);
        }

    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(horizontal * Speed, rbody.velocity.y);
    }

}
