using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OwenScript : MonoBehaviour
{

    int MaxValue = 100;
    int currentValue;
    int ValueController;
    [SerializeField]
    GameObject Button;
    [SerializeField]
    GameObject anim;
    bool PlayerEntered = false;
   
       public co2bar DioxideLevel;
    private void Start()
    {
        currentValue = 50;
        ValueController = currentValue;
        DioxideLevel.SetMaxValue(MaxValue);
        Button.SetActive(false);
        anim.SetActive(false);
    }


    private void LateUpdate()
    {
        DioxideLevel.SetValue(currentValue);
    }

    private void Update()
    {
        if (PlayerEntered && Input.GetKeyDown(KeyCode.E))
        {
            currentValue += 5;
            if(currentValue > ValueController)
            {
                PlayerEntered = false;
                ValueController = currentValue;
            }
            
        }
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        Button.SetActive(true);
        anim.SetActive(true);
        
       if (collision.attachedRigidbody.gameObject.name=="hero")
       {
         
         PlayerEntered = true;
       }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Button.SetActive(false);
        anim.SetActive(false);
    }


}
