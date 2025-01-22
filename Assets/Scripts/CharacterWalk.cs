using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterWalk : MonoBehaviour
{

    //movement speegit d in units per second
    [SerializeField]
    private float movementSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    bool isflip = true;

    Vector2 movement;
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("speed", movement.sqrMagnitude);

        if (movement.x < 0f && isflip)
        {
            FlipIt();
        }
        else if(movement.x > 0f && !isflip)
        {
            FlipIt();
        }
       
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime * movementSpeed);
    }

    void FlipIt()
    {
        isflip = !isflip;
        transform.Rotate(0f, 180f, 0f);
    }
}
