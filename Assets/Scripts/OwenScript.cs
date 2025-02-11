using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OwenScript : MonoBehaviour
{

    int MaxValue = 100;
    int currentValue;
    [SerializeField]
    GameObject Button;
    [SerializeField]
    GameObject anim;

    public co2bar DioxideLevel;
    private void Start()
    {
        currentValue = 50;
        DioxideLevel.SetMaxValue(MaxValue);
        Button.SetActive(false);
        anim.SetActive(false);
    }


    private void LateUpdate()
    {
        DioxideLevel.SetValue(currentValue);
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        Button.SetActive(true);
        anim.SetActive(true);
        
       if (Input.GetKeyDown(KeyCode.E) && collision.gameObject.tag == "Player")
       {
         Debug.Log("Hi");
         currentValue += 5;
       }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Button.SetActive(false);
        anim.SetActive(false);
    }


}
