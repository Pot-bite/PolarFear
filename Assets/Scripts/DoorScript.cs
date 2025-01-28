using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{


   


    [SerializeField]
    GameObject canvas;
    [SerializeField]
    GameObject spiner;


    private void Start()
    {
       
        canvas.SetActive(false);
        
        spiner.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
           
            spiner.SetActive(true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.SetActive(false);
           
            spiner.SetActive(false);
        }
    }

}
