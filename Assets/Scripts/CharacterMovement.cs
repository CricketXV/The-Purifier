using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public Animator anim;
    public Rigidbody2D rb;

    public float speed = 200f;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime);
            anim.Play("Walking");
        }

    }
}
