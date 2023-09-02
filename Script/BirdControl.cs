using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BirdControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float rightMagnitude=2f;
    public float upMagnitude=3f;
    public Rigidbody2D rigidbody2D;
    public int direction =1;
    public SpriteRenderer sp;
    bool IsBirdDied=false;
    public static event Action<int> OnCollidedWithWall;
    public static event Action OnBirdDied;

    void Start()
    {
        
    }
    void onEnable(){

    }

    void onDisable(){

    }
    void onDestroy(){

    }
    void BirdJump(){
      if(!IsBirdDied){
        if(Input.GetMouseButton(0)){
            // Debug.Log("Mouse Clicked");
            Vector2 rightVelocity = direction*Vector2.right * rightMagnitude;
            Vector2 upVelocity=Vector2.up*upMagnitude;
            Vector2 res=rightVelocity+upVelocity;
            rigidbody2D.velocity=res;
            rigidbody2D.gravityScale=1f;

        }
      }
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name=="column1" || col.gameObject.name=="column 2"){
            direction=-1*direction;
            sp.flipX=direction!=1f;
            OnCollidedWithWall?.Invoke(direction);

        }
        if(col.gameObject.name=="mainspikes" ){
            OnBirdDied?.Invoke();
            sp.color=Color.black;
            IsBirdDied=true;
        }
    }
    void Update()
    {
        BirdJump();
    }
}
