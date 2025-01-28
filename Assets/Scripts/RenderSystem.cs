using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RenderSystem : MonoBehaviour
{
    private Renderer myrender;
    [SerializeField]
    private int sortingOrderBase = 5000;
    [SerializeField]
    private int offset = 0;
    [SerializeField]
    private bool RunOnlyOnce = false;
    private float timer;
    private float timerMax = .1f;

    private void Awake()
    {
        myrender = gameObject.GetComponent<Renderer>();
    }
    
    private void LateUpdate()
    {
        timer -= Time.deltaTime;
        if (timer < 0f) 
        {
            timer = timerMax;
         myrender.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
         if (RunOnlyOnce)
         {
            Destroy(this);
         }
        }
    }

   
}
