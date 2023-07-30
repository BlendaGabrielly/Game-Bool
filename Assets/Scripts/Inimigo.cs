using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;
    
    public float speed;

    public Transform right;
    public Transform left;

    public Transform head;

    private bool colliding;

    public LayerMask layer;
    public BoxCollider2D box;
    public CircleCollider2D circle;
    void Start()
    {
       rig=GetComponent<Rigidbody2D>();
       anim=GetComponent<Animator>(); 
    }

    
    void Update()
    {
        rig.velocity=new Vector2(speed,rig.velocity.y);

        colliding=Physics2D.Linecast(right.position,left.position,layer);

        if(colliding){
           transform.localScale=new Vector2(transform.localScale.x*-1f,transform.localScale.y);
           speed*=-1f;
        }
    }
        
        void OnCollisionEnter2D(Collision2D col){
           if(col.gameObject.tag=="Player"){
              float height=col.contacts[0].point.y-head.position.y;
              if(height>0){
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*10,ForceMode2D.Impulse);
                speed=0;
                anim.SetTrigger("die");
                box.enabled=false;
                circle.enabled=false;
                rig.bodyType=RigidbodyType2D.Kinematic;
                Destroy(gameObject,0.5f);
              }else{
                GameController.insta.ShowGameOver();
                Destroy(col.gameObject);
              }

           }
        }  
    }
