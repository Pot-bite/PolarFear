using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalk : MonoBehaviour
{

    //movement speed in units per second
    [SerializeField]
    private float movementSpeed = 5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

       
    }
}
