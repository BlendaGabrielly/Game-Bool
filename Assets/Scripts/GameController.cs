using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int TotalScore;
    public Text score;
    public GameObject gameOver;
    public GameObject Prox;
    public static GameController insta;

    void Start()
    {
        insta=this;
    }
    public void UpdateScoreText(){

        score.text = TotalScore.ToString();
    }
   public void ShowGameOver(){
     gameOver.SetActive(true);
   }
   public void ProximoLevel(){
    Prox.SetActive(true);
   }
   public void Restart(string lvlName ){
    SceneManager.LoadScene(lvlName);
   }
}
