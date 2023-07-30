using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelPoint : MonoBehaviour
{
    //public GameObject gameLevel;
    public string lvlName;
    public float time;

     void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.tag=="Player"){
         GameController.insta.ProximoLevel();
         Invoke("proximo",2f);
    }
    void proximo(){
         SceneManager.LoadScene(lvlName);
    }
}
}
