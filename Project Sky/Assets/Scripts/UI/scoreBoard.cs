using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 



public class scoreBoard : MonoBehaviour
{

  [SerializeField] private TMP_Text scoreText;  
  private int score = 0;


   void OnEnable() {

    Messenger.AddListener(GameEvent.enemy_hit_score, enemyScoreUp);

    Messenger.AddListener(GameEvent.enemy_down_score,enemyDownScore); 

    Messenger.AddListener(GameEvent.boss_hit_score, bossHitScore);   
  }

  private void OnDisable() {
    Messenger.RemoveListener(GameEvent.enemy_down_score, enemyScoreUp); 

    Messenger.RemoveListener(GameEvent.enemy_down_score, enemyDownScore); 

    Messenger.RemoveListener(GameEvent.boss_hit_score, bossHitScore); 
  }


  private void enemyScoreUp(){

    score += 10; 

    scoreText.text = score.ToString();  

  }


  private void enemyDownScore() {

    score += 100; 

    scoreText.text = score.ToString(); 

  }


  private void bossHitScore() {

    score += 30; 

     scoreText.text = score.ToString();  
  }
}
