using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Candy : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action OnCandyCollected;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col){
       
       if(col.gameObject.name.Contains("bird")){
        OnCandyCollected.Invoke();
        gameObject.SetActive(false);
       }
    }
}
