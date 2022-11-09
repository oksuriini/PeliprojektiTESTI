using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Animator animator;
    public float MoveSpeed = 10f;
    public Rigidbody2D rigid;
    Vector2 movement;

    void FixedUpdate(){
        rigid.MovePosition(rigid.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update(){
       movement.x = Input.GetAxisRaw("Horizontal"); 
       movement.y = Input.GetAxisRaw("Vertical");

       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
