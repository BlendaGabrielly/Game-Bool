using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serra : MonoBehaviour
{
    public float speed;
    private bool dirRig=true;
    public float moveTime;
    private float timer;
   
    void Update()
    {
       if(dirRig){
         transform.Translate(Vector2.right*speed*Time.deltaTime);
       }else{
         transform.Translate(Vector2.left*speed*Time.deltaTime);
       } 
       timer+=Time.deltaTime;
       if(timer>=moveTime){
        dirRig=!dirRig;
        timer=0f;
       }
    }
    
}
